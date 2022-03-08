#ifndef DISPLAY_H
#define DISPLAY_H

#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

class Display
{
private:
  
public:

  virtual void write(String text, int x, int y, int size) = 0;
  virtual void quiteWrite(String text, int x, int y, int size) = 0;
  virtual void show() = 0;
  virtual void clear() = 0;
};

#endif