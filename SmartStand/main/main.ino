#include "main.h"

#include "led.h"

Main* core;

void setup() {
  core = new Main();
  core->init();
}

void loop() {
  core->step();
}