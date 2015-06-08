#include "Points.h"


Points::Points()
{
}


Points::~Points()
{
}

void Points::Reset()
{
	Score = 0;
}

//przeci¹¿one operatory strumieniowe
std::ostream& operator << (std::ostream &out, const Points &P)
{
	out << P.Score;
	return out;
}

std::istream& operator >> (std::istream &in, Points &P)
{
	in >> P.Score;
	return in;
}