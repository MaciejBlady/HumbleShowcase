#pragma once
#include <SFML/Graphics.hpp>
#include <string>
class VisibleObject
{
public:
	VisibleObject();
	VisibleObject(sf::Texture& Texture, sf::IntRect Rectangle);
	virtual ~VisibleObject();

	struct Coords
	{
		int x;
		int y;
	};

	sf::Sprite Sprite;
	Coords WindowCoords;

	void Draw(sf::RenderWindow& window);
};

