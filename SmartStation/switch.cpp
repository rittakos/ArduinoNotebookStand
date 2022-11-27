#include "switch.h"
#include "Arduino.h"

Switch::Switch (int pin) : pin(pin)
{
}

bool Switch::connect()
{
	if (pin == -1)
		return false;
	pinMode(pin, INPUT);
	return true;
}


bool Switch::isOn()
{
  return digitalRead(pin) == HIGH;
}