#include "potmeter.h"
#include "Arduino.h"

Potmeter::Potmeter (int pin)
{
  this->pin = pin;
}


float Potmeter::getNormalisedValue()
{
  return analogRead(pin) / 1023.0f;
}


int Potmeter::getValue()
{
  return analogRead(pin);
}