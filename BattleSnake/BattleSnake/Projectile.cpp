#include "Projectile.h"


Projectile::Projectile(double x1, double y1, double x2, double y2, sf::Texture& Texture, sf::IntRect Rectangle) : VisibleObject(Texture, Rectangle)
{
	//ochrona przed dzielenim przez 0
	if (x2==0 || x2==y1) 
		x2++;
	
	_step = 1.0;

	//oblicznie wspó³czynników funkcji liniowej odpowiadaj¹cej za tor ruchu pocisku
	_b = (((x1*y2)/x2) - y1)/((x1/x2)-1);
	_a = (y2 - _b) / x2;

	WindowCoords.x = x1; 
	WindowCoords.y = y1;

	Sprite.setPosition(WindowCoords.x, WindowCoords.y);


	//aby pocisk lecia³ we w³aœciwym kierunku
	if (x1 > x2)			
		_step = -_step;
}


Projectile::~Projectile()
{
}

void Projectile::Move(sf::Time timeModifier)
{
	WindowCoords.x += _step*timeModifier.asMilliseconds();
	WindowCoords.y = WindowCoords.x * _a + _b;
	Sprite.setPosition(WindowCoords.x, WindowCoords.y);
}
