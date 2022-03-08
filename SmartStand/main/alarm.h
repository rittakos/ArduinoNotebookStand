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
  bool sound;
  bool led;
  Repeat repeat;
  DateTime time;
public:
  AlarmItem(DateTime time, String message, bool sound, bool led, Repeat repeat = NEVER);
  
  String getMessage() {return message;}
  bool useLed() {return led;}
  bool useNoise() {return sound;}

  friend class Alarm;
};

class Alarm
{
private:
  AlarmItem* alarmItems[5];
  int equal(DateTime time1, DateTime time2, Repeat repeat);
public:
  Alarm() {}
  void addAlarmItem(AlarmItem* alarmItem, int idx);
  AlarmItem* checkCurrentAlarm(DateTime now);
};

#endif