#ifndef TEMPERATURE_SENSOR_h
#define TEMPERATURE_SENSOR_h

class TemperatureSensor
{
  private:
    int pin;
  
  public:
    TemperatureSensor(int pin);
    float getTemperature();
};

#endif
