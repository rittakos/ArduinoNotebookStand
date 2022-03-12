#ifndef RGB_LED_STRIP_H
#define RGB_LED_STRIP_H

#include "color.h"

class RGBLedStrip
{
private:
  const int rPin;
  const int gPin;
  const int bPin;

  Color color;

  float brightness;
public:
  RGBLedStrip (int rPin, int gPin, int bPin);
  
  void on();
  void off();

  void setColor(Color color);
  void setBrightness(float brightness);

  Color getColor() const {return color;}
};

#endif