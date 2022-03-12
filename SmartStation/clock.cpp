#include "clock.h"
#include "Arduino.h"

Clock::Clock()
{
  if (!rtc.begin()) {
    while (true);
  }
}

String Clock::toString(char separator, bool year, bool month, bool day, bool hour, bool minute, bool second)
{
  String date = "";
  DateTime now = getDate();

  if(year){
    date += now.year();
    if(month)
      date += separator;
  }

  if(month){
    date += now.month();
    if(day)
      date += separator;
  }

  if(day){
    date += now.day();
    if(hour)
      date += separator;
  }

  if(hour){
    date += now.hour();
    if(minute)
      date += separator;
  }

  if(minute){
    if(now.minute() < 10)
      date += "0";
    date += now.minute();
    if(second)
      date += separator;
  }

  if(second){
    date += now.second();
  }
  
  return date;
}

DateTime Clock::getDate()
{
  return rtc.now();
}

String Clock::getDayOfWeek()
{
  int idx = rtc.now().dayOfTheWeek();

  switch(idx)
  {
    case 1:
      return "Mon";
    case 2:
      return "Tue";
    case 3:
      return "Wed";
    case 4:
      return "Thu";
    case 5:
      return "Fri";
    case 6:
      return "Sat";
    case 0:
      return "Sun";
    default:
      return "---";
  }
}

void Clock::setDate(DateTime newDate)
{

  // t.hour = newDate.hour; 
  // t.min = newDate.minute;
  // t.sec = newDate.second;
  // t.mday = newDate.day;
  // t.mon = newDate.month;
  // t.year = newDate.year;
 
  //rtc.adjust(DateTime(F(__DATE__), F(__TIME__)));
  rtc.adjust(newDate);
}