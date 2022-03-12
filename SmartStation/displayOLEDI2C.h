#ifndef DISPLAY_OLED_I2C_H
#define DISPLAY_OLED_I2C_H

#include "display.h"

#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

class DisplayOLEDI2C : public Display
{
private:
  int width;
  int height;
  int oledReset;

  Adafruit_SSD1306* display = nullptr;

  int getScreenAddress();

  void testdrawline();
public:
  DisplayOLEDI2C(int width, int height, int olderReset, int screenAdress = 0x3C);
  ~DisplayOLEDI2C();

  virtual void write(String text, int x, int y, int size) override;
  virtual void quiteWrite(String text, int x, int y, int size) override;
  virtual void show() override;
  virtual void clear() override;
};

#endif