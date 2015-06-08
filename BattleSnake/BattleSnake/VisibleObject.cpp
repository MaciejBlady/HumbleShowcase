#include "VisibleObject.h"


VisibleObject::VisibleObject()
{

}

VisibleObject::VisibleObject(sf::Texture& Texture, sf::IntRect Rectangle)
{
	//ustawianie textury oraz jej wycinka do Sprite'a
	Sprite.setTexture(Texture);
	Sprite.setTextureRect(Rectangle);
}


VisibleObject::~VisibleObject()
{
}


void VisibleObject::Draw(sf::RenderWindow& window)
{
	//rysowanie Sprite'a
	window.draw(Sprite);
}