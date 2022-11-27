#include "core.h"

void Core::on()
{
	led.on();
}

void Core::off()
{
	led.off();
}

void Core::setPower()
{
	if (powerSwitch.isOn() != power)
	{
		power = powerSwitch.isOn();
		if (power)
			on();
		else
			off();
	}
}

Core::Core()
{
	Serial.begin(115200);

	led = LED(pins::statusLedPin);
	led.connect();

	powerSwitch = Switch(pins::powerSwitchPin);
	powerSwitch.connect();

	display = new OledDisplay(128, 64, -1);
	display->write("Szia!", 10, 10, 2);
	//display->show();
}

void Core::setup()
{
	led.on();
	setPower();
}

void Core::step()
{
	setPower();
}
