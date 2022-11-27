/*
 Name:		SmartStation.ino
 Created:	2022-03-12 20:14:37
 Author:	akosr
*/

//#include "led.h"
#include "core.h"

//#include "display.h"
//#include "displayOLEDI2C.h"

//Display* d;

Core* core;

void setup() {
	/*LED led(13);
	led.connect();
	led.on();*/
	//core.setup();
	core = new Core();
	//d = new OledDisplay(128, 64, -1);
}

void loop() {
	core->step();
}

