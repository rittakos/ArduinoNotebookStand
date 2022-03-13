#include "led.h"
#include "temperatureSensor.h"
#include "clock.h"
#include "display.h"
#include "displayOLEDI2C.h"
#include "switch.h"
#include "rgbLedStrip.h"
#include "potmeter.h"
#include "alarm.h"
#include "stateMachine.h"
#include "noiseMaker.h"
#include "command.h"

#include <RTClib.h>
#include <Wire.h>
#include <SPI.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
#include <Arduino.h>

struct pins
{
  static const int statusLedPin    = 13;
  static const int powerSwitchPin  = 12;
  static const int buttonPin       = 2;
  static const int redPin          = 3;
  static const int greenPin        = 5;
  static const int bluePin         = 6;
  static const int noiseMakerPin   = 8;
};

class Main
{
private:
  LED* led;
  Display*      display;
  Switch*       powerSwitch;
  Switch*       button;
  RGBLedStrip*  strip;
  Potmeter*     potmeter;
  Clock*        clock;
  Alarm*        alarm;
  AlarmItem*    alarmInProgress;
  NoiseMaker*	noiseMaker;

  bool          power;
  int           counter;
  bool          alarmOn = false;

  const int alarmIterCount          = 5000;
  const int processInputIterCount   = 1000;
  const int refreshDisplayIterCount = 100;

  void setCounter();

  void setPower();
  void on();
  void off();
  Command* processInput();

  void checkAlarm();
  void refreshDisplay();

  void triggerAlarm();

  //String* parseInput(String data, char splitBy);

public:
  Main();

  void init();
  void step(); 
};