#ifndef NOISE_MAKER_H
#define NOISE_MAKER_H

class NoiseMaker
{
private:
	int pin;
	int frequency;
	int length;

	bool muted = true;

public:
	NoiseMaker(int pin, int frequency = 500, int length = 50);
	
	void makeNoise(int frequency, int length);
	
	void makeNoise() { makeNoise(this->frequency, this->length); }

	void mute();
	void unMute() { muted = false; }

};

#endif
