#pragma once
#include "SFML/Window.hpp"
#include "SFML/Graphics.hpp"
#include <fstream>
#include "VisibleObject.h"
#include "BoardObject.h"
#include "Snake.h"
#include "IView.h"
#include "BoardObjectFactory.h"
#include "Points.h"
#include "typeinfo.h"

#define HEIGHT 10
#define WIDTH 14

class Board : public IView
{
public:
	Board();
	~Board();

	virtual std::list<VisibleObject> ReturnVOList();
	void StartingGridFill();
	void Update();
	void Reset();
	void RandomInsert();
	void SaveScore();

	Snake	Snake;
private:
	BoardObjectFactory _factory;
	BoardObject* _grid[WIDTH][HEIGHT];
	sf::IntRect _boundaries;
	Points _points;

	void InsertEmptyIntoGrid(int x, int y);
	void InsertEnemyIntoGrid(int x, int y);
	void InsertCollectibleIntoGrid(int x, int y);


	void CheckCollisions();
	void CheckSnakeBoardCollisions();
	void CheckSnakeSelfCollisions();
	void CheckProjectilesCollisions();

	void CheckBoundaries();

};

