#pragma once
#include "BoardObject.h"
class Collectible :
	public BoardObject
{
public:
	Collectible();
	Collectible(int x, int y, sf::Texture& Texture, sf::IntRect Rectangle);
	~Collectible();
	virtual int GetPoints();

	int Points;
};

