class Command
{
public:
  virtual void execute() = 0;
};

class LedStripColorCommand : public Command
{
private:
	RGBLedStrip* strip;
public:
	LedStripColorCommand(const RGBLedStrip* strip);

	virtual void execute() override
	{

	}
};