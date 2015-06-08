#pragma once
#include "IView.h"
#include "IControl.h"
#include "SnakeElement.h"
#include "Projectile.h"
#include<iostream>
#include <list>
class Snake :public IView, public IControl
{
public:
	Snake();
	~Snake();

	enum SnakeState
	{
		GoingLeft,
		GoingRight,
		GoingUp,
		GoingDown,
		Dead
	};

	SnakeState State;
	std::list<SnakeElement*> RealSnake;
	std::vector<Projectile*> Projectiles;

	virtual void HandleInput(sf::Event & E);
	virtual std::list<VisibleObject> ReturnVOList();

	void CreateStartingSnake();
	void Move();
	void MoveProjectiles(sf::Time timeModifier);
	void Update();
	void GrowInSize();
	void Reset();

private:
	void TurnLeft();
	void TurnRight();
	void TurnUp();
	void TurnDown();
	void MoveBody();
	SnakeElement* CreateElement(int x, int y);
	SnakeElement* CreateHead(int x, int y);
	void Shoot(int x, int y);

	sf::Texture SnakeSkin;
	sf::Texture _projectileTexture;
	
};

