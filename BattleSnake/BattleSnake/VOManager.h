#pragma once
#include "IView.h"
#include <list>
class VOManager
{
public:
	VOManager();
	~VOManager();

	void AddToVOList(IView *I);
	void Draw(sf::RenderWindow& window);

private:
	std::list<IView*> _voList;
};

