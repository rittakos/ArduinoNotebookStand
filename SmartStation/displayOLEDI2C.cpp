#include "displayOLEDI2C.h"
#include <Wire.h>

int OledDisplay::getScreenAddress()
{
  Wire.begin();
  int error, address;

  for(;;) {
    int nDevices;
    nDevices = 0;
    for(address = 1; address < 127; address++ ) {
      Wire.beginTransmission(address);
      error = Wire.endTransmission();
      if (error == 0) {
        Serial.print("I2C device found at address 0x");
        if (address<16) {
          Serial.print("0");
        }
        Serial.println(address,HEX);
        nDevices++;
      }
      else if (error == 4) {
        Serial.print("Unknow error at address 0x");
        if (address<16) {
          Serial.print("0");
        }
        Serial.println(address,HEX);
      }    
    }
    if (nDevices == 0) {
      Serial.println("No I2C devices found\n");
    }
    else {
      Serial.println("done\n");
    }
    delay(5000);          
  }
}


OledDisplay::OledDisplay(int width, int height, int olderReset, int screenAdress/* = 0x3C*/) : width(width), height(height), oledReset(oledReset)
{
  display = new Adafruit_SSD1306(width, height, &Wire, oledReset);
  
   if(!display->begin(SSD1306_SWITCHCAPVCC, screenAdress)) {
    Serial.println(F("SSD1306 allocation failed"));
    for(;;){}
  }

  display->display();
  delay(2000);
}


void OledDisplay::write(String text, int x, int y, int size)
{
  display->clearDisplay();

  display->setTextSize(size);
  display->setTextColor(WHITE);
  display->setCursor(x, y);
  display->println(text);
  display->display(); 
}

void OledDisplay::quiteWrite(String text, int x, int y, int size)
{
  display->setTextSize(size);
  display->setTextColor(WHITE);
  display->setCursor(x, y);
  display->println(text);
}

void OledDisplay::show()
{
  display->display();
}

void OledDisplay::clear()
{
  display->clearDisplay();
}
