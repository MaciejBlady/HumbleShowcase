#pragma once
#include <SFML/Graphics.hpp>
class IControl
{
public:
	//TODO: argumentem ma byæ event (jak?)
	virtual void HandleInput(sf::Event &E) = 0;
};

