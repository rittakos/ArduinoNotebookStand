#include "rgbLedStrip.h"
#include "Arduino.h"

RGBLedStrip::RGBLedStrip (int rPin, int gPin, int bPin) : rPin(rPin), gPin(gPin), bPin(bPin)
{
  brightness = 1.0f;
  color = Color(0, 0, 255);
}

RGBLedStrip::RGBLedStrip(const RGBLedStrip& other)
{
    this->rPin = other.rPin;
    this->rPin = other.gPin;
    this->rPin = other.bPin;

    this->brightness = other.brightness;
    this->color = other.color;
}

RGBLedStrip RGBLedStrip::operator=(const RGBLedStrip& other)
{
    if (this == &other)
        return *this;

    this->rPin = other.rPin;
    this->rPin = other.gPin;
    this->rPin = other.bPin;

    this->brightness = other.brightness;
    this->color = other.color;

    return *this;
}

void RGBLedStrip::connect()
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
}

void RGBLedStrip::setColor(Color color)
{
  this->color = color;
}
