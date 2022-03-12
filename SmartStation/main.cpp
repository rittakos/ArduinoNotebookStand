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
  strip->setColor(Color (0, 0, 255));

  AlarmItem* item = new AlarmItem(DateTime(2022, 3, 12, 18, 15, 00), "Szia!", false, false, Repeat::NEVER);
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

  setPower();

  if(power){
    strip->setBrightness(potmeter->getNormalisedValue());
  }

  if(counter % refreshDisplayIterCount == 0)
  {
    if(power)
    {
      refreshDisplay();
   }
  } 
  
  if(counter % processInputIterCount == 0)
  {
    processInput();
  }  

  if(counter % alarmIterCount == 0)
  {
    checkAlarm();
  }

  setCounter();
}

void Main::setCounter()
{
  if(counter > alarmIterCount)
    counter = 0;

  ++counter;
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
    strip->setColor(Color(r, g, b));
  }
}

void Main::checkAlarm()
{  alarmInProgress = alarm->checkCurrentAlarm(clock->getDate());
    if(alarmInProgress != nullptr && !alarmInProgress->isDone())
    {
      triggerAlarm();
    }
}

void Main::triggerAlarm()
{
  display->write(alarmInProgress->getMessage(), 0, 10, 2);
  Color oldColor = strip->getColor();
  if(alarmInProgress->useLed())
  {
    
  }
  while(!button->isOn())
  {

  }
  alarmInProgress->stop();
}

void Main::refreshDisplay()
{
  display->clear();
  //if(displayStatus == TIME)
    display->quiteWrite(clock->getTimeStringNoSec(), 0, 10, 4);
    display->quiteWrite( clock->getDayOfWeek(), 0, 50, 2);
  //else if(displayStatus == TEMP)
    display->quiteWrite( String(clock->getTemperature()) + (char)247 + "C", 50, 50, 2);
  display->show();
}