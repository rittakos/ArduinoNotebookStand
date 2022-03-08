#include "main.h"

#include "alarm.h"

Main::Main()
{
  led = new LED(pins::statusLedPin);
  powerSwitch = new Switch(pins::powerSwitchPin);
  button = new Switch(pins::buttonPin);
  strip = new RGBLedStrip(pins::redPin, pins::greenPin, pins::bluePin);
  potmeter = new Potmeter(A0);
  display = new DisplayOLEDI2C(128, 64, -1);
  clock = new Clock();
  alarm = new Alarm();
}

void Main::init()
{
  power = true;
  counter = 0;
  led->on();
  strip->setColor(0, 0, 255);
  displayStatus = TIME;

  AlarmItem* item = new AlarmItem(DateTime(2022, 3, 8, 19, 34, 00), "Szia!", false, false, Repeat::NEVER);
  alarm->addAlarmItem(item, 0);

  Serial.begin(115200);
}

void Main::step()
{
  //tone(8, 262);
  // while(alarmInProgress != nullptr)
  // {

  // }

  // if(button.isOn()){
  //   clock->setDate(DateTime(2022, 3, 5, 22, 43, 30));
  // }
  ++counter;

  setPower();

  if(power){
    strip->setBrightness(potmeter->getNormalisedValue());
  }

  if(counter % 100 == 0)
  {
    if(power)
    {
      display->clear();
      //if(displayStatus == TIME)
        display->quiteWrite(clock->getTimeStringNoSec(), 0, 10, 4);
        display->quiteWrite( clock->getDayOfWeek(), 0, 50, 2);
      //else if(displayStatus == TEMP)
        display->quiteWrite( String(clock->getTemperature()) + (char)247 + "C", 50, 50, 2);
      display->show();
   }
  } 
  
  if(counter % 1000 == 0)
  {
    processInput();
  }  

  if(counter % 5000 == 0)
  {
    alarmInProgress = alarm->checkCurrentAlarm(clock->getDate());
    if(alarmInProgress != nullptr)
      display->write(alarmInProgress->getMessage(), 0, 10, 2);

    // switch (displayStatus)
    // {
    //   case TIME:
    //     displayStatus = TEMP;
    //     break;
    //   case TEMP:
    //     displayStatus = TIME;
    //     break;
    //   default:
    //     break;
    // }
    counter = 0;
  }
}

void Main::setPower()
{
  if(powerSwitch->isOn() != power)
  {
    if(power)
      off();
    else
      on();

    power = powerSwitch->isOn();
  }
}

void Main::on()
{
  led->on();
  strip->on();
}

void Main::off()
{
  led->off();
  strip->off();
  display->clear();
  display->show();
}

void Main::processInput()
{
   String data = Serial.readString();

  // if(data.indexOf("ON")!=-1)//checks if it is "ON"
  // {
  //   led.on(); // Sets the led ON
  //   state=0;// Sets the state value to 0
  // } else if(data.indexOf("OFF")!=-1)//checks if it is "OFF"
  // {
  //   led.off(); //Sets the led OFF
  //   state=0;// Sets the state value to
  // } else if(data.indexOf("STATE")!=-1)//checks if it is "STATE
  // {
  //    Serial.write("state=");//Sends the state
  //    Serial.println(state);
  // }

  if(data.indexOf("Color:")!=-1)
  {
    int r, g, b;
    int StringCount = 0;
    
    while (data.length() > 0)
    {
      int index = data.indexOf(':');

      if (index == -1)
      {
        b = data.toInt();
        break;
      }
      else
      {
        ++StringCount;
        if(StringCount == 2)
          r = data.substring(0, index).toInt();
        if(StringCount == 3)
          g = data.substring(0, index).toInt();
        data = data.substring(index+1);
      }
    }
    strip->setColor(r, g, b);
  }
}