#include "rgbLedStrip.h"
#include "Arduino.h"

RGBLedStrip::RGBLedStrip (int rPin, int gPin, int bPin) : rPin(rPin), gPin(gPin), bPin(bPin)
{
  pinMode(rPin, OUTPUT);
  pinMode(gPin, OUTPUT);
  pinMode(bPin, OUTPUT);
}
  
void RGBLedStrip::on()
{
  analogWrite(rPin, color.r() * brightness);
  analogWrite(gPin, color.g() * brightness);
  analogWrite(bPin, color.b() * brightness);
}

void RGBLedStrip::off()
{
  analogWrite(rPin, 0);
  analogWrite(gPin, 0);
  analogWrite(bPin, 0);
}

void RGBLedStrip::setBrightness(float brightness)
{
  if(brightness < 0)
    brightness = 0;
  
  if(brightness > 1)
    brightness = 1;

  this->brightness = brightness;
  on();
}

void RGBLedStrip::setColor(Color color)
{
  this->color = color;

  on();
}
