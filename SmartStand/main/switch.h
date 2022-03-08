#ifndef SWITCH_H
#define SWITCH_H

class Switch
{
private:
  int pin;
public:
  Switch (int pin);
  bool isOn();
};

#endif