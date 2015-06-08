#include "VOManager.h"


VOManager::VOManager()
{
}


VOManager::~VOManager()
{
}

void VOManager::AddToVOList(IView  *I)
{
	//Dodaje Wska�nik na IView do swoeje listy.
	_voList.push_back(I);
}

void VOManager::Draw(sf::RenderWindow& window)
{
	//Od wszystkich element�w ze swojej listy IView'�w pobiera listy element�w do wyswietlenia
	// i je wy�ietla.
	std::list<IView*>::iterator i;
	std::list<VisibleObject>::iterator j;
	for (i = _voList.begin(); i !=_voList.end(); ++i)
	{
		std::list<VisibleObject> TempList = (**i).ReturnVOList();
		for (j = TempList.begin(); j != TempList.end(); ++j)
		{
			(*j).Draw(window);
		}
	}

}
