#pragma once
#include <SFML/Graphics.hpp>
#include "GameState.h"
class Button
{
public:
	Button(int x, int y, GameState::State changeOfState, std::string displayText);
	~Button();

	sf::Rect<int> ButtonBox;
	
	void Draw(sf::RenderWindow& window);
	GameState::State GetState();

private:
	sf::Texture _texture;
	sf::Sprite _sprite;
	GameState::State _changeOfState;
	sf::Text _text;
	sf::Font _font;
};

