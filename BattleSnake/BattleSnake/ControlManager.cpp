#include "ControlManager.h"


ControlManager::ControlManager()
{
}


ControlManager::~ControlManager()
{
}


void ControlManager::AddToControlList(IControl* C)
{
	//Wstawia wskaünik z argumentu do listy wskünikÛw na IControl.
	_cList.push_back(C);
}
void ControlManager::DistributeEvents(sf::Event &E)
{
	//Dystrubuuje otrzymane zdarzenie wszystkim obiektom ze swojej listy
	std::list<IControl*>::iterator i;;
	for (i = _cList.begin(); i != _cList.end(); ++i)
	{
		(**i).HandleInput(E);
	}
}