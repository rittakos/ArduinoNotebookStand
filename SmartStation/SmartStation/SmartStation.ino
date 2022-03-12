/*
 Name:		SmartStation.ino
 Created:	2022-03-12 20:14:37
 Author:	akosr
*/

#include "main.h"

Main* core;

void setup() {
	core = new Main();
	core->init();
}

void loop() {
	core->step();
}

