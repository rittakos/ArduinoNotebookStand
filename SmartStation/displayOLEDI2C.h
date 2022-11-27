#ifndef DISPLAY_OLED_H
#define DISPLAY_OLED_H

#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

#include "display.h"


class OledDisplay : public Display
{
private:
	int width;
	int height;
	int oledReset;

	Adafruit_SSD1306* display = nullptr;

	int getScreenAddress();

	void testdrawline();

public:
	OledDisplay(int width, int height, int olderReset, int screenAdress = 0x3C);
	~OledDisplay();

	virtual void write(String text, int x, int y, int size) override;
	virtual void quiteWrite(String text, int x, int y, int size) override;
	virtual void show() override;
	virtual void clear() override;
};

#endif