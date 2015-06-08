#include "Button.h"


Button::Button(int x, int y, GameState::State changeOfState,std::string displayText)
{
	//Twoorzy guizk w menu. Guzik ma 100x400 pikseli/

	_font.loadFromFile("sfFonts/ArcadeClassic.ttf");
	_texture.loadFromFile("Textures/button.png");
	_sprite.setTexture(_texture);
	_sprite.setPosition(x,y);
	ButtonBox = sf::Rect<int>(x, y, 400, 100);
	_changeOfState = changeOfState;
	_text = sf::Text(displayText,_font,30);
	_text.setPosition(x + 50, y + 30);
}


Button::~Button()
{
}

void Button::Draw(sf::RenderWindow& window)
{
	window.draw(_sprite);
	window.draw(_text);
}
GameState::State Button::GetState()
{
	return _changeOfState;
}
