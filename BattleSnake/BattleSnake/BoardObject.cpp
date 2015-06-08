#include "BoardObject.h"


BoardObject::BoardObject()
{

}

BoardObject::BoardObject(int x, int y, sf::Texture& Texture, sf::IntRect Rectangle) : VisibleObject(Texture,Rectangle)
{
	//pozycja elementu w tablicy
	GridPosition.x = x;
	GridPosition.y = y;

	//pozycja elementu na ekranie
	WindowCoords.x = SIDE_MARGIN + 50 * x;
	WindowCoords.y =  UPPER_MARGIN + 50 * y;

	Sprite.setPosition(WindowCoords.x, WindowCoords.y);
}


BoardObject::~BoardObject()
{
}


int BoardObject::GetPoints()
{
	return 0;
}
