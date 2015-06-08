#pragma once
#include "SFML/Window.hpp"
#include "SFML/Graphics.hpp"
#include <iostream>
#include <fstream>
#include "Points.h"
#include "GameState.h"
#include "Button.h"
#include <list>
#include <vector>

class Menu
{
public:
	Menu();
	~Menu();

	void ShowPauseMenu(sf::RenderWindow& window, GameState & gameState);
	void ShowMainMenu(sf::RenderWindow& window, GameState & gameState);
	void ShowScoreScreen(sf::RenderWindow& window, GameState & gameState);
	void ShowStartScreeen(sf::RenderWindow& window, GameState & gameState);

private:
	void ManageScores();
	void GetResponse(sf::RenderWindow& window, GameState& gameState);
	GameState::State HandleClick(int x, int y);
	std::list<Button> _buttons;
};

