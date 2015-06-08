#pragma once
#include <list>
#include "VisibleObject.h"
class IView
{
public:
	virtual std::list<VisibleObject> ReturnVOList() = 0;
};

