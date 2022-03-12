#include "switch.h"
#include "Arduino.h"

Switch::Switch (int pin) : pin(pin)
{
  pinMode(pin, INPUT);
}


bool Switch::isOn()
{
  return digitalRead(pin) == HIGH;
}