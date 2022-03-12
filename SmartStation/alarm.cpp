#include "alarm.h"
#include "Arduino.h"

 AlarmItem::AlarmItem(DateTime time, String message, bool sound, bool led, Repeat repeat)
 {
   this->time = time;
   this->message = message;
   this->sound = sound;
   this->led = led;
   this->repeat = repeat;

   this->done = false;
 }

void Alarm::addAlarmItem(AlarmItem* alarmItem, int idx)
{
  alarmItems[idx] = alarmItem;
}

AlarmItem* Alarm::checkCurrentAlarm(DateTime now) 
{
  for(int idx = 0; idx < 5; ++idx)
  {
    AlarmItem* item = alarmItems[idx];
    if(equal(now, item->time, item->repeat) == 0)
      return item;
  }

  return nullptr;
}

int Alarm::equal(DateTime time1, DateTime time2, Repeat repeat) //works only on equal
{
  if(time1.minute() != time2.minute())
    return -1;

  if(time1.hour() != time2.hour())
    return -1;

  if(time1.day() != time2.day())
  {
    if(repeat == DAILY)
      return 0;

    if(repeat == WEEKLY)
      if(time1.dayOfTheWeek() == time2.dayOfTheWeek())
        return 0;
    
    return -1;
  }

  if(time1.month() != time2.month())
  {
    if(repeat == MONTHLY)
      return 0;
    else
      return -1;
  }

  if(time1.year() != time2.year())
  {
    if(repeat == YEARLY)
      return 0;
    else
      return -1;
  }

  if(repeat == NEVER)
    return 0;

  return -1;
}