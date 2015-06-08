#pragma once
#include "BoardObject.h"
class Enemy :
	public BoardObject
{
public:

	Enemy();
	Enemy(int x, int y, sf::Texture& Texture, sf::IntRect Rectangle);
	~Enemy();
	virtual int GetPoints();

	int Points;
};

