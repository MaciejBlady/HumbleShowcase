#pragma once
#include"IControl.h"
#include<list>
class ControlManager
{
public:
	ControlManager();
	~ControlManager();

	void AddToControlList(IControl* C);
	void DistributeEvents(sf::Event &E);
private:
	std::list<IControl*>_cList;
};

