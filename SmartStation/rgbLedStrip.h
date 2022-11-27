#ifndef RGB_LED_STRIP_H
#define RGB_LED_STRIP_H

#include "color.h"

class RGBLedStrip
{
private:
  int rPin;
  int gPin;
  int bPin;

  Color color;
  float brightness;

public:
  RGBLedStrip (int rPin = 0, int gPin = 0, int bPin = 0);

  RGBLedStrip(const RGBLedStrip& other);

  RGBLedStrip operator=(const RGBLedStrip& other);
  
  void connect();

  void on();
  void off();

  void setColor(Color color);
  void setBrightness(float brightness);

  Color getColor() const {return color;}
};

#endif