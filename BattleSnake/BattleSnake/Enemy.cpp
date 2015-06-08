#include "Enemy.h"

Enemy::Enemy()
{
	Points = 50;
}

int Enemy::GetPoints()
{
	return Points;
}

Enemy::Enemy(int x, int y, sf::Texture& Texture, sf::IntRect Rectangle) : BoardObject(x, y,Texture,Rectangle)
{
	Points = 50;
}


Enemy::~Enemy()
{
}

