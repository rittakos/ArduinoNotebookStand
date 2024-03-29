enum state
{
  ON,
  OFF,
  ALARM
};

enum event
{
  BUTTON,
  TURNON,
  TURNOFF,
  ALARMON
};

static state currrentState = state::ON;

class StateMachine
{
private:
  static state currentState;
public:

  static state getState() {return currentState;}

  static state nextState(event e)
  {
    
    switch(currentState)
    {
      case ON:
      {
        switch(e)
        {
          case TURNOFF:
            currentState = OFF;
            break;
          default:
            break;
        }
        break;
      }
      case OFF:
      {
        switch(e)
        {
          case TURNON:
            currentState = ON;
            break;
          default:
            break;
        }
        break;
      }
      case ALARM:
      {
        switch(e)
        {
          case TURNOFF:
            currentState = OFF;
            break;
          case BUTTON:
            currentState = ON;
            break;
          default:
            break;
        }
        break;
      }
      default:
        break;
    }
    return currentState;
  }
};