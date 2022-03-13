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
  noiseMaker = new NoiseMaker(pins::noiseMakerPin, 50, 1000);
}

void Main::init()
{
  power = true;
  counter = 0;
  led->on();
  strip->setColor(Color (0, 0, 255));

  AlarmItem* item = new AlarmItem(DateTime(2022, 3, 13, 10, 54, 00), "Szia!", true, true, Repeat::NEVER);
  alarm->addAlarmItem(item);

  Serial.begin(115200);
}

void Main::step()
{
    // if(button.isOn()){
    //   clock->setDate(DateTime(2022, 3, 5, 22, 43, 30));
    // }

    setPower();

    if (power) {
        strip->setBrightness(potmeter->getNormalisedValue());
    }

    if (counter % refreshDisplayIterCount == 0)
    {
        if (power)
        {
            refreshDisplay();
        }
    }

    if (counter % processInputIterCount == 0)
    {
        processInput();
        while (Serial.read() >= 0);
        //Serial.begin(115200);
    }

    if (counter % alarmIterCount == 0)
    {
        checkAlarm();
    }

    /*if (counter % 1000000 == 0)
    {
        for (int i = 0; i < 5; ++i)
        {
            if (alarm->alarmItems[i] != nullptr)
                alarm->alarmItems[i]->start();
        }
    }*/

  setCounter();
}

void Main::setCounter()
{
  if(counter > 1000000)
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

Command* Main::processInput()
{
    String data = Serial.readString();
    //String* data = parseInput(Serial.readString(), ':');
    //String* data = parseInput(String("Color:255:0:0"), ':');

    /*if (data == nullptr)
        return nullptr;

    if (data[0] == "Color")
    {
        Serial.print("sfsdffsf");
        strip->setColor(Color(data[1].toInt(), data[2].toInt(), data[3].toInt()));
    }*/
  if(data.indexOf("Color:") != -1)
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
        if (StringCount == 2)
            r = data.substring(0, index).toInt();
        if(StringCount == 3)
          g = data.substring(0, index).toInt();
        data = data.substring(index+1);
      }
    }
    strip->setColor(Color(r, g, b));
  }
  else if (data.indexOf("Alarm:") != -1)
  {
      /*int StringCount = 0;

      String message;

      bool noise = false;
      bool light = false;
      bool onArduino = false;

      while (data.length() > 0)
      {
          int index = data.indexOf(':');

          if (index == -1)
          {
              onArduino = (data == "True");
              break;
          }
          else
          {
              ++StringCount;
              if (StringCount == 2)
                  message = data.substring(0, index);
              else if (StringCount == 3)
                  noise = (data.substring(0, index) == "True");
              else if (StringCount == 4)
                  light = (data.substring(0, index) == "True");

              data = data.substring(index + 1);
          }
      }*/

      //if (onArduino == true)
      //{
      //    //alarm->addAlarmItem(new AlarmItem(DateTime(), message, noise, light));
      //}
      //else
      //{
      //    alarmInProgress = new AlarmItem(DateTime(2000, 1, 1, 0, 0, 0), message, noise, light);
      //    triggerAlarm();
      //    delete alarmInProgress;
      //    alarmInProgress = nullptr;
      //}
  }

  return nullptr;
}

void Main::checkAlarm()
{  
    alarmInProgress = alarm->checkCurrentAlarm(clock->getDate());

    if(alarmInProgress != nullptr && !alarmInProgress->isDone())
    {
      triggerAlarm();
    }
}

void Main::triggerAlarm()
{
    if (alarmInProgress == nullptr)
        return;

    display->write(alarmInProgress->getMessage(), 0, 10, 2);
    Color oldColor = strip->getColor();

    if(alarmInProgress->useLed())
    {
        strip->setColor(Alarm::alarmColor);
        strip->setBrightness(1);
    }

    if (alarmInProgress->useNoise())
    {
        noiseMaker->unMute();
        noiseMaker->makeNoise(100, alarmInProgress->getNoiseLength());
    }

    while (!button->isOn()) 
    {
      
    }

    if (alarmInProgress->useLed())
    {
        strip->setColor(oldColor);
    }

    alarmInProgress->stop();

    alarmInProgress = nullptr;
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

//String* Main::parseInput(String d, char splitBy)
//{
//    int count = 0;
//    //String tmp = data;
//    //Serial.print(data.length());
//    while (d.length() > 0)
//    {
//        int index = d.indexOf(':');
//        Serial.print(d);
//        delay(1000);
//        ++count;
//        d = d.substring(index + 1);
//    }
//    Serial.print(count);
//
//    //String* result = new String[count];
//
//    //int idx;
//    //while (data.length() > 0)
//    //{
//    //    int index = data.indexOf(splitBy);
//
//    //    result[idx] = data.substring(0, index);
//    //    ++idx;
//    //    data = data.substring(index + 1);
//    //}
//    //result[count - 1] = data;
//
//    //return result;
//    return nullptr;
//}