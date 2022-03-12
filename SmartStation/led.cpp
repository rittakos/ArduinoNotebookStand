#include "led.h"
#include "Arduino.h"

LED::LED(int p)
{
  pin = p;
  pinMode(p, OUTPUT);
}

void LED::on()
{
  digitalWrite(pin, HIGH);
}

void LED::off()
{
  digitalWrite(pin, LOW);
}
