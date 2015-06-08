#include "Collectible.h"

Collectible::Collectible()
{
	Points = 100;
}

Collectible::Collectible(int x, int y, sf::Texture& Texture, sf::IntRect Rectangle) : BoardObject(x, y,Texture,Rectangle)
{
	Points = 100;
}


Collectible::~Collectible()
{
}

int Collectible::GetPoints()
{
	return Points;
}
