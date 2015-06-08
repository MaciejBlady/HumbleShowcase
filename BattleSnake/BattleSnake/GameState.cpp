#include "GameState.h"


GameState::GameState()
{
	_realGameState = NotExisting;
}


GameState::~GameState()
{

}

GameState::State GameState::GetGameState()
{
	return _realGameState;
}

void GameState::SetGameState(State S)
{
	_realGameState = S;
}

void GameState::HandleInput(sf::Event & E)
{
	//Implenetacja interfejsu IControl:
	//sprawdza czy nie zosta³ wciœniêty klawisz Escape, jeœli tak to zmienia
	//stan gry na Paused.
	if (E.type == sf::Event::Closed)
		_realGameState=GameState::Exiting;
	else
	if (E.type == sf::Event::KeyPressed)
		if (E.key.code == sf::Keyboard::Escape)
			_realGameState = GameState::Paused;
}
