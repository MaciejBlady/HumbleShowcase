#include "Game.h"

#define FPS 1.0/60.0;


Game::Game()
{
	//Pocz�tkowy stan gry.
	_gameState.SetGameState(GameState::NotExisting);

	//Dodawanie p�l do list menad�er�w
	_voman.AddToVOList(&_board);
	_voman.AddToVOList(&_board.Snake);

	_coman.AddToControlList(&_board.Snake);
	_coman.AddToControlList(&_gameState);

	//Restart p�l odpowiadaj�cych za czas.
	_clock.restart();
	_snakeWaiter=sf::Time::Zero;
	_boardObjectsWaiter = sf::Time::Zero;


	//wype�nianie planszy
	_board.StartingGridFill();
}

Game::~Game()
{
}

void Game::Start()
{

	//Rozpoczyna gr�: tworzy okno, sprawdza pocz�tkowy stan gry zapobiegaj�c 
	//podw�jnemu rozpoczeci. Tutaj znajduje si� g��wna petla gry, wywo�uj�ca metod� GameLoop(),
	//tak d�ugo a� gra nie b�dzie w stanie Exiting.
	if (_gameState.GetGameState() != GameState::NotExisting)
		return;

	Game::_window.create(sf::VideoMode(800, 600, 32), "Battle Snake 3000");
	_gameState.SetGameState(GameState::ShowingStartScreen);

	while (Game::_gameState.GetGameState() != GameState::Exiting)
	{
		GameLoop();
	}

	Game::_window.close();
}

void Game::GameLoop()
{
	//Najwa�niejsza metoda gry. Na podstawie zegara i czasu kt�ry up�yn�� od ostatniego przebiegu,
	//zarz�dza inputem gracza, uaktualnia �wiat gry i wy�wietla rzeczy na ekranie.

	//Akcje dla stanu Playing
	if (_gameState.GetGameState() == GameState::Playing)
	{
		sf::Event currentEvent;
		sf::Time elapsedTime = _clock.restart();

		while (_window.pollEvent(currentEvent)) 
		{
			_coman.DistributeEvents(currentEvent);
		}

		Update(elapsedTime);

		if (_gameState.GetGameState() != GameState::Playing)
			return;


		//Rysuje, je�li czas od ostatniego przebiegu by� wiekszy od 1/60 sekundu
		//je�li nie to czeka a� taki cas up�ynie (oblicza r�nic�).
		if (elapsedTime.asMilliseconds() >= 1.0/60.0)
		{
			_window.clear(sf::Color::White);
			_voman.Draw(_window);
		}
		else
		{
			Sleep(1.0 / 60.0 - elapsedTime.asMilliseconds());
			_window.clear(sf::Color::White);
			_voman.Draw(_window);
		}
		_window.display();
	}
	else
	//Akcje dla innych stan�w (dla wszytskich rdzaj�w Menu).
	{
		Menu menu;
		switch (_gameState.GetGameState())
		{
		case GameState::InMenu:		
			menu.ShowMainMenu(_window,_gameState);
				break;
		case GameState::Paused:
			menu.ShowPauseMenu(_window, _gameState);
			break;
		case GameState::ShowingScoreScreen:
			menu.ShowScoreScreen(_window, _gameState);
			break;
		case GameState::ShowingStartScreen:
			menu.ShowStartScreeen(_window, _gameState);
			break;
		}
	}
	
}
void Game::Update(sf::Time ElapsedTime)
{
	//Na podstawie przekazanego w argumencie kwantu czasu uaktualnia �wiat gry:
	//co 150 ms porusza w�em, co 2s tworzy now� znajd�k�/przciwnka. Porusza tak�e
	//pociskami kt�rych przesuni�cie skaluje si� wraz z wielko�cia przekazanego kwantu czasu.
	//Na koniec sprawdza czy w�� jeszcze �yje, czy mo�e nale�y zako�czy� gr�. Dopisuje tak�e wynik
	//gracza na ko�cu pliku z wynikami.
	_snakeWaiter = _snakeWaiter + ElapsedTime;
	_boardObjectsWaiter = _boardObjectsWaiter + ElapsedTime;


	if (_snakeWaiter.asMilliseconds() >=150)
	{
		_board.Snake.Move();
		_snakeWaiter=sf::Time::Zero;
	}

	if (_boardObjectsWaiter.asSeconds() > 2)
	{
		_board.RandomInsert();
		_boardObjectsWaiter = sf::Time::Zero;
	}

	_board.Snake.MoveProjectiles(ElapsedTime);
	_board.Update();

	if (_board.Snake.State == Snake::SnakeState::Dead)
	{
		_gameState.SetGameState(GameState::ShowingScoreScreen);
		_board.SaveScore();
		_board.Reset();
	}
}
