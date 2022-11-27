#include "led.h"
#include "Arduino.h"

LED::LED(int p)
{
  pin = p;
}

bool LED::connect()
{
	if (pin == -1)
		return false;
	pinMode(pin, OUTPUT);
	return true;
}

void LED::on()
{
  digitalWrite(pin, HIGH);
}

void LED::off()
{
  digitalWrite(pin, LOW);
}
