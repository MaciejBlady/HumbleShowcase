#pragma once
#include "Enemy.h"
#include "Collectible.h"




class BoardObjectFactory
{
public:
	BoardObjectFactory();
	~BoardObjectFactory();

	BoardObject* CreateEnemy(int x, int y);
	BoardObject* CreateCollectible(int x, int y);
	BoardObject* CreateEmpty(int x, int y);

private:
	sf::Texture _enemyTexture;
	sf::Texture _emptyTexture;
	sf::Texture _collectibleTexture;
};

