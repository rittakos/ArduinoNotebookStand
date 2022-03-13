#include "noiseMaker.h"
#include "Arduino.h"

NoiseMaker::NoiseMaker(int pin, int frequency, int length)
{
	this->pin = pin;
	this->frequency = frequency;
	this->length = length;

	pinMode(this->pin, OUTPUT);
}

void NoiseMaker::makeNoise(int frequency, int length)
{
	if(!muted)
		tone(pin, frequency, length);
}

void NoiseMaker::mute()
{
	muted = true; 
	noTone(pin);
}
