#ifndef POTMETER_H
#define POTMETER_H

class Potmeter
{
private:
  int pin;
public:
  Potmeter (int pin);
  float getNormalisedValue();
  int getValue();
};

#endif