#include "rgbLedStrip.h"
#include "Arduino.h"

RGBLedStrip::RGBLedStrip (int rPin, int gPin, int bPin) : rPin(rPin), gPin(gPin), bPin(bPin)
{
  pinMode(rPin, OUTPUT);
  pinMode(gPin, OUTPUT);
  pinMode(bPin, OUTPUT);

  r = 255;
  g = 255;
  b = 255;  

  brightness = 0.5f;
}
  
void RGBLedStrip::on()
{
  analogWrite(rPin, r * brightness);
  analogWrite(gPin, g * brightness);
  analogWrite(bPin, b * brightness);
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

void RGBLedStrip::setColor(int r, int g, int b)
{
  if(r < 0)
    r = 0;
  if(r > 255)
    r = 255;

  if(g < 0)
    g = 0;
  if(g > 255)
    g = 255;

  if(b < 0)
    b = 0;
  if(b > 255)
    b = 255;

  this->r = r;
  this->g = g;
  this->b = b;

  on();
}
