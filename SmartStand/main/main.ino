#include "led.h"
#include "temperatureSensor.h"
#include "clock.h"
#include "display.h"
#include "displayOLEDI2C.h"
#include "switch.h"
#include "rgbLedStrip.h"
#include "potmeter.h"
#include "alarm.h"

#include <RTClib.h>
#include <Wire.h>
#include <SPI.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

enum DisplayStatus
{
  OFF,
  TIME,
  TEMP
};

LED led(13);
Display* display;
Switch powerSwitch(12);
Switch button(2);
RGBLedStrip strip(3, 5, 6);
Clock* clock;
Potmeter potmeter(A0);
Alarm* alarm;

bool power;
DisplayStatus displayStatus = OFF;
int counter = 0;

void setup() {
  power = true;
  display = new DisplayOLEDI2C(128, 64, -1);
  clock = new Clock();
  alarm = new Alarm();
  led.on();
  strip.setColor(0, 0, 255);
  displayStatus = TIME;

  Serial.begin(115200);

}

String displayText = "";

void loop() {

  // if(button.isOn()){
  //   clock->setDate(DateTime(2022, 3, 5, 22, 43, 30));
  // }
  ++counter;

  setPower();

  if(power){
    strip.setBrightness(potmeter.getNormalisedValue());
  }

  if(counter % 100 == 0)
  {
    if(power)
    {
      display->clear();
      //if(displayStatus == TIME)
        display->quiteWrite(clock->getTimeStringNoSec(), 0, 10, 4);
      //else if(displayStatus == TEMP)
        display->quiteWrite( String(clock->getTemperature()) + (char)247 + "C", 0, 50, 2);
      display->show();
   }
  } 
  
  if(counter % 1000 == 0)
  {
    alarm->checkCurrnetAlarm();
    processInput();
  }  

  if(counter % 5000 == 0)
  {
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

void setPower()
{
  if(powerSwitch.isOn() != power)
  {
    if(power)
      off();
    else
      on();

    power = powerSwitch.isOn();
  }
}

void on()
{
  led.on();
  strip.on();
}

void off()
{
  led.off();
  strip.off();
  display->clear();
  display->show();
}

void processInput()
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
    strip.setColor(r, g, b);
  }
}
