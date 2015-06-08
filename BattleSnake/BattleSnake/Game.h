#pragma once
#ifdef SFML_STATIC
#pragma comment(lib, "glew.lib")
#pragma comment(lib, "freetype.lib")
#pragma comment(lib, "jpeg.lib")
#pragma comment(lib, "opengl32.lib")
#pragma comment(lib, "winmm.lib")
#pragma comment(lib, "gdi32.lib")  
#endif // SFML_STATIC


#include <SFML/Graphics.hpp>
#include "Windows.h"
#include"Menu.h"
#include"GameState.h"
#include"IView.h"
#include"Board.h"
#include"VOManager.h"
#include"ControlManager.h"


#include<iostream>
class Game
{
public:

	Game();
	~Game();
	void Start();
private:
	GameState _gameState;
	sf::RenderWindow _window;
	sf::Clock _clock;
	sf::Time _snakeWaiter;
	sf::Time _boardObjectsWaiter;
	sf::Font _font;
	Board _board;
	VOManager _voman;
	ControlManager _coman;

	void GameLoop();
	void Update(sf::Time ElapsedTime);
};

