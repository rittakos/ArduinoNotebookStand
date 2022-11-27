#ifndef LED_h
#define LED_h

class LED
{
  private:
    int pin;
  public:
    LED(int p = -1);

    bool connect();

    void on();
    void off();
};


#endif
