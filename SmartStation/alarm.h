#ifndef ALARM_H
#define ALARM_H

#include <RTClib.h>

#include "color.h"

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
  bool done;

  int noiseLength = 1000;

public:
  AlarmItem(DateTime time, String message, bool sound, bool led, Repeat repeat = NEVER);
  
  String	getMessage()	{return message;}
  bool		useLed()		{return led;}
  bool		useNoise()		{return sound;}

  int	getNoiseLength()			{ return noiseLength; }
  void	setNoiseLength(int length)	{ noiseLength = length; }

  void stop()	{ done = true; }
  void start()	{ done = false; }
  bool isDone() { return done; }

  friend class Alarm;
};

class Alarm
{
private:
  int equal(DateTime time1, DateTime time2, Repeat repeat);
  int alarmitemCount = 0;
public:
  AlarmItem* alarmItems[5];
  static const Color alarmColor;

  Alarm() {}
  void addAlarmItem(AlarmItem* alarmItem);
  AlarmItem* checkCurrentAlarm(DateTime now);
};

#endif