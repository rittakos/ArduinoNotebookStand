#ifndef CLOCK_h
#define CLOCK_h

#include <Wire.h>
#include <RTClib.h>

class Clock
{
  private:
    RTC_DS3231 rtc;
    String toString(char separator, bool year, bool month, bool day, bool hour, bool minute, bool second);
  public:
    Clock();

    void setDate(DateTime newDate);

    DateTime getDate();
    int getTemperature() { return rtc.getTemperature(); }
    String getDayOfWeek();

    String getTimeString() { return toString(':', false, false, false, true, true, true); }
    String getTimeStringNoSec() { return toString(':', false, false, false, true, true, false); }


};

#endif
