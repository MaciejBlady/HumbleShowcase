#include "SnakeElement.h"


SnakeElement::SnakeElement()
{

}

SnakeElement::SnakeElement(int x, int y, sf::Texture& Texture, sf::IntRect Rectangle) : BoardObject(x,y,Texture, Rectangle)
{
}


SnakeElement::~SnakeElement()
{
}


void SnakeElement::UpdateSprite()
{
	//uaktulanianie pozycji Sprite'a
	WindowCoords.x = 50 + 50 * GridPosition.x;
	WindowCoords.y = 50 + 50 * GridPosition.y;

	Sprite.setPosition(WindowCoords.x, WindowCoords.y);
}