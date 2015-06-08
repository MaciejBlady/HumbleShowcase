#pragma once
#include "VisibleObject.h"
#include <math.h>
class Projectile :
	public VisibleObject
{
public:
	Projectile(double x1, double y1, double x2, double y2, sf::Texture& Texture, sf::IntRect Rectangle);
	~Projectile();
	void Move(sf::Time timeModifier);
private:
	double _a; //defining linear function used for calculating movement
	double _b;
	double _step; //multiplied by timeModifier gives delta of x
};

