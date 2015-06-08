#pragma once
#include <iostream>
class Points
{	
public:
	int Score;
	Points();
	~Points();
	void Reset();

	friend std::ostream& operator<< (std::ostream &out,const Points &P);
	friend std::istream& operator>> (std::istream &in, Points &P);
};


