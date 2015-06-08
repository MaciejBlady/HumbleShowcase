#pragma once
#include "BoardObject.h"
class SnakeElement :
	public BoardObject
{
public:
	SnakeElement();
	SnakeElement(int x, int y, sf::Texture& Texture, sf::IntRect Rectangle);
	~SnakeElement();

	void UpdateSprite();
};

