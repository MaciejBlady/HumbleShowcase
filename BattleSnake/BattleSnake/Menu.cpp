#include "Menu.h"
#include<iostream>


Menu::Menu()
{
}

Menu::~Menu()
{
}

GameState::State Menu::HandleClick(int x, int y)
{
	//Sprawdza czy przekazane w argumentach wsp�rz�dne klikni�cia "trafi�y" w kt�ry� przycisk
	//z listu _buttons. Je�li tak, to zwraca stan gry kt�ry owy prycisk mia� wywo�a�, je�li nie to zwraca
	//NullState.
	std::list<Button>::iterator it;
	for (it = Menu::_buttons.begin(); it!=Menu::_buttons.end(); it++)
	{
		sf::Rect<int> CurrentMenuButtonRect = (*it).ButtonBox;
		if (CurrentMenuButtonRect.contains(x, y))
		{
			return (*it).GetState();
		}
			
	}
	return GameState::NullState;
}
void Menu::GetResponse(sf::RenderWindow& window, GameState& gameState)
{
	//Oczekuje na akcj� gracza pdczas wy�wietlania menu. Wywo�uje handlera dla klikni��,
	//w przypadku gdy takie nast�pi. Gdy otrzyma z powrotem jaki� stan r�zny od NullState,
	//to ustawia go jako nowy stan gry.
	sf::Event menuEvent;
	while (true)
	{
		while (window.pollEvent(menuEvent))
		{
			if (menuEvent.type == sf::Event::Closed)
			{
				gameState.SetGameState(GameState::Exiting);
				return;
			}
			else
			if (menuEvent.type == sf::Event::MouseButtonPressed)
			{
				GameState::State S = HandleClick(menuEvent.mouseButton.x, menuEvent.mouseButton.y);
				if (S != GameState::NullState)
				{
					gameState.SetGameState(HandleClick(menuEvent.mouseButton.x, menuEvent.mouseButton.y));
					return;
				}
			}


		}

	}
}

void Menu::ShowPauseMenu(sf::RenderWindow& window, GameState & gameState)
{
	//Pokazuje manu pauzy z dwoma przyciskami: Wyjd� i Kontynuuj
	sf::Texture tex;	
	sf::Sprite sp;
	sf::Text text;
	sf::Font font;

	tex.loadFromFile("Textures/titleEpicScreen.png");
	sp.setTexture(tex);
	font.loadFromFile("sfFonts/ArcadeClassic.ttf");

	Button exitButton(200, 450, GameState::Exiting, "Wyjdz!");
	Button continueButton(200, 300, GameState::Playing, "Kontynuuj!");


	_buttons.push_back(continueButton);
	_buttons.push_back(exitButton);

	window.draw(sp);
	std::list<Button>::iterator j;
	for (j = _buttons.begin(); j != _buttons.end(); ++j)
	{
		(*j).Draw(window);
	}


	window.display();

	Menu::GetResponse(window, gameState);
}
void Menu::ShowMainMenu(sf::RenderWindow& window, GameState & gameState)
{
	//Pokazuje G��wne Menu z dwoama przyciskami: Graj! i Wyjd�!
	sf::Texture tex;
	sf::Sprite sp;
	sf::Text text;
	sf::Font font;

	tex.loadFromFile("Textures/titleEpicScreen.png");
	sp.setTexture(tex);
	font.loadFromFile("sfFonts/ArcadeClassic.ttf");

	Button exitButton(200, 450, GameState::Exiting, "Wyjdz!");
	Button playButton(200, 300, GameState::Playing, "Graj!!");

	_buttons.push_back(playButton);
	_buttons.push_back(exitButton);

	window.draw(sp);
	std::list<Button>::iterator j;
	for (j = _buttons.begin(); j != _buttons.end(); ++j)
	{
		(*j).Draw(window);
	}

	
	window.display();
	Menu::GetResponse(window, gameState);
}
void Menu::ShowScoreScreen(sf::RenderWindow& window, GameState & gameState)
{
	//Pokazuje 
	sf::Texture tex;
	sf::Sprite sp;
	sf::Text text;
	sf::Font font;
	Button returnButton(200, 450, GameState::InMenu, "Wroc do glownego menu!");

	tex.loadFromFile("Textures/titleEpicScreen.png");
	sp.setTexture(tex);
	font.loadFromFile("sfFonts/ArcadeClassic.ttf");
	text.setFont(font);
	text.setColor(sf::Color::White);
	//text.setString("Score: " + std::to_string(score.Score));
	text.setPosition(200,200);

	_buttons.push_back(returnButton);

	std::vector<int> scores = { 0, 0, 0, 0 };
	std::ifstream in_file;
	in_file.open("Scores/gamescores.txt");
	if (in_file.is_open())
	{
		for (size_t i = 0; i < 4 && !in_file.eof(); i++)
		{
			in_file >> scores[i];
		}
	}
	else
		std::cout << "Nie mozna otworzyc pliku gamescores.txt";

	std::string textstring = "Ranking \n" + std::to_string(scores[0]) + "\n"
		+ std::to_string(scores[1]) + "\n"
		+ std::to_string(scores[2]) + "\n"
		"Twoj wynik " + std::to_string(scores[3]);

	text.setString(textstring);

	ManageScores();
	window.draw(sp);
	window.draw(text);
	std::list<Button>::iterator j;
	for (j = _buttons.begin(); j != _buttons.end(); ++j)
	{
		(*j).Draw(window);
	}

	window.display();
	Menu::GetResponse(window, gameState);
}
void Menu::ShowStartScreeen(sf::RenderWindow& window, GameState & gameState)
{
	//Pokazuje ekran startowy z napisem "Press Button".
	//Przechodzi po wci�ni�ciu klawisza do G��wnego Menu.
	sf::Texture tex;
	sf::Sprite sp;
	sf::Text text;
	sf::Font font;

	tex.loadFromFile("Textures/titleEpicScreen.png");
	sp.setTexture(tex);
	font.loadFromFile("sfFonts/ArcadeClassic.ttf");

	sf::Event menuEvent;
	text.setString("Press Button");
	text.setFont(font);
	text.setCharacterSize(30);
	text.setPosition(300, 500);
	text.setColor(sf::Color::White);
	window.draw(sp);
	window.draw(text);
	window.display();
	while (true)
	{
		while (window.pollEvent(menuEvent))
		{
			if (menuEvent.type == sf::Event::Closed)
			{
				gameState.SetGameState(GameState::Exiting);
				return;
			}
			else
			if (menuEvent.type == sf::Event::KeyPressed)
			{
				gameState.SetGameState(GameState::InMenu);
				return;
			}

		}
	}

}

void Menu::ManageScores()
{
	//Zarz�dza warto�ciami w pliku z wynikami.
	//Mog� w nim by� maksymalnie 4 warto�ci, kt�re pobiera do wektora, sortuje,
	//czy�ci plik a nast�pnie zapisuje z powrotem 3 najwy�sze wyniki.
	std::ifstream in_file;
	std::ofstream out_file;
	in_file.open("Scores/gamescores.txt");

	std::vector<int> scores = { 0, 0, 0, 0 };
	if (in_file.is_open())
	{	
		for (size_t i = 0; i < 4 && !in_file.eof(); i++)
		{
			in_file >> scores[i];
		}
	}
	else
		std::cout << "Nie mozna otworzyc pliku gamescores.txt";

	std::sort(scores.begin(),scores.end());

	out_file.open("Scores/gamescores.txt");
	if (out_file.is_open())
	{
		for (size_t i = 3; i > 0; i--)
		{
			out_file << scores[i] <<"\n";
		}
	}
	else
		std::cout << "Nie mozna otworzyc pliku gamescores.txt";
}