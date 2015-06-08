#pragma once
#include "VisibleObject.h"
//#include "Snake.h"

#define UPPER_MARGIN 50
#define SIDE_MARGIN 50

class BoardObject : public VisibleObject
{
public:
	BoardObject();
	BoardObject(int x, int y, sf::Texture& Texture, sf::IntRect Rectangle);
	virtual ~BoardObject();
	virtual int GetPoints();
	
	Coords GridPosition;
};

