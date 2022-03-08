#ifndef RGB_LED_STRIP_H
#define RGB_LED_STRIP_H

class RGBLedStrip
{
private:
  const int rPin;
  const int gPin;
  const int bPin;

  int r;
  int g;
  int b;

  float brightness;
public:
  RGBLedStrip (int rPin, int gPin, int bPin);
  
  void on();
  void off();

  void setColor(int r, int g, int b);
  void setBrightness(float brightness);
};

#endif