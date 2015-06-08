#include "BoardObjectFactory.h"


BoardObjectFactory::BoardObjectFactory()
{
	//�aduje tekstury z plik�w.
	_enemyTexture.loadFromFile("Textures/evil_mongoose.png");
	_emptyTexture.loadFromFile("Textures/grass.png");
	_collectibleTexture.loadFromFile("Textures/cake.png");
	srand(time(NULL));
}


BoardObjectFactory::~BoardObjectFactory()
{

}

BoardObject* BoardObjectFactory::CreateEnemy(int x, int y)
{
	//Metoda fabryczna zwracaj�c Enemy jako wska�nik na BoardObject
	Enemy* E = new Enemy(x, y, _enemyTexture, sf::IntRect(0, 0, 50, 50));
	return (E);
}
BoardObject*	BoardObjectFactory::CreateCollectible(int x, int y)
{
	//Metoda fabryczna zwracaj�c Collectible jako wska�nik na BoardObject
	Collectible* C = new Collectible(x, y, _collectibleTexture, sf::IntRect(0, 0, 50, 50));
	return (C);
}

BoardObject* BoardObjectFactory::CreateEmpty(int x, int y)
{
	//Metoda fabryczna zwracaj�ca wska�nik na BoardObject

	//Losuje wycinek trawnika z wi�kszej tekstury.
	int XOffset = rand() % 10; 
	int YOffset = rand() % 6;
	BoardObject* E = new BoardObject(x, y, _emptyTexture, sf::IntRect(0 + 50 * XOffset, 0 + 50 * YOffset, 50, 50));
	return (E);
}
