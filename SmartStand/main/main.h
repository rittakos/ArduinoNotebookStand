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

#include <RTClib.h>
#include <Wire.h>
#include <SPI.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

enum DisplayStatus
{
  SLEEP,
  TIME,
  TEMP
};

struct pins
{
  static const int statusLedPin    = 13;
  static const int powerSwitchPin  = 12;
  static const int buttonPin       = 2;
  static const int redPin          = 3;
  static const int greenPin        = 5;
  static const int bluePin         = 6;
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

  bool          power;
  DisplayStatus displayStatus = SLEEP;
  int           counter;
  bool          alarmOn = false;

  const int alarmIterCount          = 5000;
  const int processInputIterCount   = 1000;
  const int refreshDisplayIterCount = 100;

  void setCounter();

  void setPower();
  void on();
  void off();
  void processInput();

  void checkAlarm();
  void refreshDisplay();

  void triggerAlarm();

public:
  Main();

  void init();
  void step(); 
};