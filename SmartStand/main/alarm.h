#ifndef ALARM_H
#define ALARM_H

#include <RTClib.h>

enum Repeat
{
  DAILY,
  WEEKLY,
  MONTHLY,
  YEARLY,
  NEVER
};

class AlarmItem
{
private:
  String message;
public:
  AlarmItem(DateTime time, String message, bool sound, bool led, Repeat repeat = NEVER);
  String getMessage() {return message;}
};

class Alarm
{
private:
  AlarmItem* alarmItems[5];
public:
  Alarm() {}
  void addAlarmItem(AlarmItem* alarmItem);
  AlarmItem* checkCurrnetAlarm() {return nullptr;};
};

#endif