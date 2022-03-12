#ifndef COLOR_H
#define COLOR_H

class Color
{
private:
  int r_;
  int g_;
  int b_;

public:
  Color(int r = 255, int g = 255, int b = 255)
  {
    if(r < 0)
      r = 0;
    if(r > 255)
      r = 255;

    if(g < 0)
      g = 0;
    if(g > 255)
      g = 255;

    if(b < 0)
      b = 0;
    if(b > 255)
      b = 255;

    this->r_ = r;
    this->g_ = g;
    this->b_ = b;
  }

  int r() const {return r_;}
  int g() const {return g_;}
  int b() const {return b_;}
};

#endif