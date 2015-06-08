#pragma once
#include "IControl.h"
class GameState :
	public IControl
{
public:
	GameState();
	~GameState();

	enum State 
	{
		NotExisting, 
		Playing,
		ShowingStartScreen,
		InMenu,
		Paused,
		ShowingScoreScreen,
		Exiting,
		NullState
	};
	void SetGameState(State S);
	State GetGameState();

	virtual void HandleInput(sf::Event & E);

private:
	State _realGameState;
};

