#include "temperatureSensor.h"
#include "Arduino.h"

TemperatureSensor::TemperatureSensor(int pin)
{
    this->pin = pin;
}


float TemperatureSensor::getTemperature()
{
  int sensorVal = analogRead(pin);
  float voltage = (sensorVal / 1024.0) * 5.0;
  float temp = (voltage - 0.47) * 100;
  return temp;
}
