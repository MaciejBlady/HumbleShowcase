#pragma once
#include <SFML/Graphics.hpp>
class IControl
{
public:
	//TODO: argumentem ma by� event (jak?)
	virtual void HandleInput(sf::Event &E) = 0;
};

