#ifndef CORE_H
#define CORE_H


#include "led.h"
#include "switch.h"
#include "displayOLEDI2C.h"
#include "display.h"

#include <RTClib.h>
#include <Wire.h>
#include <SPI.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
#include <Arduino.h>

struct pins
{
	static const int statusLedPin	= 13;
	static const int powerSwitchPin = 12;
	static const int buttonPin		= 2;
	static const int redPin			= 3;
	static const int greenPin		= 5;
	static const int bluePin		= 6;
	static const int noiseMakerPin	= 8;
};

class Core
{
private:
	LED			led;
	Switch		powerSwitch;
	Display*	display;


	bool power;

	void on();
	void off();

	void setPower();

public:
	Core();

	void setup();
	void step();
};

#endif