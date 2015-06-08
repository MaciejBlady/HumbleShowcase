#include "Game.h"

#define FPS 1.0/60.0;


Game::Game()
{
	//Pocz¹tkowy stan gry.
	_gameState.SetGameState(GameState::NotExisting);

	//Dodawanie pól do list menad¿erów
	_voman.AddToVOList(&_board);
	_voman.AddToVOList(&_board.Snake);

	_coman.AddToControlList(&_board.Snake);
	_coman.AddToControlList(&_gameState);

	//Restart pól odpowiadaj¹cych za czas.
	_clock.restart();
	_snakeWaiter=sf::Time::Zero;
	_boardObjectsWaiter = sf::Time::Zero;


	//wype³nianie planszy
	_board.StartingGridFill();
}

Game::~Game()
{
}

void Game::Start()
{

	//Rozpoczyna grê: tworzy okno, sprawdza pocz¹tkowy stan gry zapobiegaj¹c 
	//podwójnemu rozpoczeci. Tutaj znajduje siê g³ówna petla gry, wywo³uj¹ca metodê GameLoop(),
	//tak d³ugo a¿ gra nie bêdzie w stanie Exiting.
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
	//Najwa¿niejsza metoda gry. Na podstawie zegara i czasu który up³yn¹³ od ostatniego przebiegu,
	//zarz¹dza inputem gracza, uaktualnia œwiat gry i wyœwietla rzeczy na ekranie.

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


		//Rysuje, jeœli czas od ostatniego przebiegu by³ wiekszy od 1/60 sekundu
		//jeœli nie to czeka a¿ taki cas up³ynie (oblicza ró¿nicê).
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
	//Akcje dla innych stanów (dla wszytskich rdzajów Menu).
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
	//Na podstawie przekazanego w argumencie kwantu czasu uaktualnia œwiat gry:
	//co 150 ms porusza wê¿em, co 2s tworzy now¹ znajdŸkê/przciwnka. Porusza tak¿e
	//pociskami których przesuniêcie skaluje siê wraz z wielkoœcia przekazanego kwantu czasu.
	//Na koniec sprawdza czy w¹¿ jeszcze ¿yje, czy mo¿e nale¿y zakoñczyæ grê. Dopisuje tak¿e wynik
	//gracza na koñcu pliku z wynikami.
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
