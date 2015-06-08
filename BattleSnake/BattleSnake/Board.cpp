#include "Board.h"

Board::Board()
{
	//granice planszy na ekranie
	_boundaries = sf::IntRect(0, 0, WIDTH * 50+50, HEIGHT * 50+50);

	//tworzenie pocz¹tkowego weza
	Snake.CreateStartingSnake();

	//zerowanie punktów
	_points.Reset();
}


Board::~Board()
{

	//dealokacja pamiêci
	for (size_t j = 0; j < HEIGHT; j++)
	{
		for (size_t i = 0; i < WIDTH; i++)
		{
			if (_grid[i][j])
				delete _grid[i][j];
		}
	}
}

void Board::Reset()
{
	//dealokacja pamieci zajetej przez obietky planszy
	for (size_t j = 0; j < HEIGHT; j++)
	{
		for (size_t i = 0; i < WIDTH; i++)
		{
			if (_grid[i][j])
				delete _grid[i][j];
		}
	}

	//ponowne wypelnienie planszy obiektami
	StartingGridFill();

	//zniszczenie wê¿a
	Snake.Reset();
	//ponowne wype³ieni wê¿a
	Snake.CreateStartingSnake();
	//reset punktów
	_points.Reset();
}

std::list<VisibleObject> Board::ReturnVOList()
{
	//implementacja interfejsu IView
	std::list<VisibleObject> TempList;
	
	//zwraca listê obiektó do narysowania na ekranie
	for (size_t j = 0; j < HEIGHT; j++)
	{
		for (size_t i = 0; i < WIDTH; i++)
		{
			(TempList).push_back(*_grid[i][j]);
		}

	}
	return TempList;
}

void Board::StartingGridFill()
{

	//pocz¹tkowe wype³nianie planszy obiektami klasy Empty
	for (size_t j = 0; j < HEIGHT; j++)
	{
		for (size_t i = 0; i < WIDTH; i++)
		{
			_grid[i][j] = _factory.CreateEmpty(i, j);
		}
	}
}

void Board::InsertEmptyIntoGrid(int x, int y)
{

	//zastêpowanie elementu o wsp (x,y) nowym elementem klasy Empty
	BoardObject * temp;

	temp = _grid[x][y];
	_grid[x][y] = _factory.CreateEmpty(y,x);
	if (temp)
	delete temp;
}
void Board::InsertEnemyIntoGrid(int x, int y)
{
	//zastêpowanie elementu o wsp (x,y) nowym elementem klasy Enemy
	BoardObject * temp;

	temp = _grid[x][y];
	_grid[x][y] = _factory.CreateEnemy(x, y);
	
	if (temp)
	delete temp;
}
void Board::InsertCollectibleIntoGrid(int x, int y)
{
	//zastêpowanie elementu o wsp (x,y) nowym elementem klasy Collectible (znajdŸka)
	BoardObject * temp;

	temp = _grid[x][y];
	_grid[x][y] = _factory.CreateCollectible(x, y);

	if (temp)
	delete temp;
}

void Board::CheckBoundaries()
{
	//sprawdza czy pociski znajduj¹ siê w granicach planszy:
	//jeœli nie to zostaj¹ usuniête
	std::vector<Projectile*>::iterator j = Snake.Projectiles.begin();
	while (j != Snake.Projectiles.end())
	{
		if (!_boundaries.contains((**j).WindowCoords.x, (**j).WindowCoords.y))
		{
			std::cout << "usuniêto z x: " << (**j).WindowCoords.x << "y: " <<(**j).WindowCoords.y << std::endl;
			delete (*j);
			j =Snake.Projectiles.erase(j);
		}
		else
		{
			j++;
		}
	}

	//sprawdza, czy g³awa wê¿a znajduje siê w granicach planszy, jeœli nie, to 
	//"przenosi" j¹ na drug¹ jej stronê
	std::list<SnakeElement*>::iterator i = Snake.RealSnake.begin();
	
	if ((**i).GridPosition.x<0) 
	{
		(**i).GridPosition.x = WIDTH-1;
	}
	else
	if ((**i).GridPosition.x>WIDTH-1)
	{
		(**i).GridPosition.x = 0;
	}
	if ((**i).GridPosition.y<0)
	{
		(**i).GridPosition.y = HEIGHT-1;
	}
	else
	if ((**i).GridPosition.y>HEIGHT-1)
	{
		(**i).GridPosition.y = 0;
	}

	//"doci¹ga" reszte cia³a do g³owy (o 1 kratkê)
	Snake.Update();
}
void Board::CheckCollisions()
{
	//wywo³uje metody sprawdzaniai rozwi¹zywania kolizji
	CheckSnakeBoardCollisions();
	CheckSnakeSelfCollisions();
	CheckProjectilesCollisions();
}


void Board::CheckSnakeSelfCollisions()
{
	//sprawdz, czy w¹¿ nie zjada sam siebie porównuj¹c koordunaty jego g³owy,z reszt¹ cia³a
	std::list<SnakeElement*>::iterator i;
	SnakeElement* head = Snake.RealSnake.front();
	for (i = ++Snake.RealSnake.begin(); i != Snake.RealSnake.end(); ++i)
	{
		if ((**i).GridPosition.x == (*head).GridPosition.x && (**i).GridPosition.y == (*head).GridPosition.y)
		{
			Snake.State = Snake.Dead;
			std::cout << "Waz uderzyl w siebie! x: " << (*head).GridPosition.x << "y: " << (*head).GridPosition.y<< std::endl;
		}
	}
}
void Board::CheckSnakeBoardCollisions()
{
	//sprawdza czy nie nast¹pi³a kolizja wê¿a z wrogiem albo znjadŸk¹.
	//wykorzystuje w tym celu lokalne obiekty Enemy i Collectible,
	//z którymi porównuje (za pomoc¹ RTTI) element na planszy znajduj¹cy siê
	//pod g³ow¹ we¿a
	Collectible RefCollectible;
	Enemy RefEnemy;
	SnakeElement* (head) = Snake.RealSnake.front();


	//dla kolizji z przeciwnikiem, zabija wê¿a
	if (typeid((*_grid[(*head).GridPosition.x][(*head).GridPosition.y])) == typeid(RefEnemy))
	{
		Snake.State = Snake.Dead;
	}
	else
	if (typeid((*_grid[(*head).GridPosition.x][(*head).GridPosition.y])) == typeid(RefCollectible))
	{
		//dodaje graczowi punkty
		_points.Score  += _grid[(*head).GridPosition.x][(*head).GridPosition.y]->GetPoints();

		//usuwa "zjedzony" element
		delete _grid[(*head).GridPosition.x][(*head).GridPosition.y];

		//wstawia na miejszce zjedzonego elementy nowy Empty
		_grid[(*head).GridPosition.x][(*head).GridPosition.y] = _factory.CreateEmpty((*head).GridPosition.x, (*head).GridPosition.y);

		//wyd³u¿a wê¿a
		Snake.GrowInSize();		
	}
}


void Board::CheckProjectilesCollisions()
{
	//Sprawdza kolizje pocisków, u¿ywaj¹c porównawczego obiektu klasy Enemy.
	//Jeœli tak¹ wykryje, to niszczy pocisk, niszczy wroga i na jego mijsce wstwia BoardObject'a
	std::vector<Projectile*>::iterator j = Snake.Projectiles.begin();
	while (j != Snake.Projectiles.end())
	{
		Enemy RefEnemy;

		//Oblicza na którym polu na planszy znajduje siê pocisk
		BoardObject::Coords GridCoords;
		GridCoords.x = ((**j).WindowCoords.x - SIDE_MARGIN) / 50;
		GridCoords.y = ((**j).WindowCoords.y - UPPER_MARGIN) / 50;

		if (GridCoords.x>WIDTH || GridCoords.x<0 || GridCoords.y>HEIGHT || GridCoords.y<0)
			return;

		if (typeid((*_grid[GridCoords.x][GridCoords.y])) == typeid(RefEnemy))
		{
			//dodawnie punktów
			_points.Score += _grid[GridCoords.x][GridCoords.y]->GetPoints();

			//usuwanie wyznaczonego wroga
			delete _grid[GridCoords.x][GridCoords.y];

			//wstawianie BoardObect'a na plansze
			_grid[GridCoords.x][ GridCoords.y] = _factory.CreateEmpty(GridCoords.x, GridCoords.y);
			
			//dusuwanie pocisku
			delete (*j);
			j = Snake.Projectiles.erase(j);
		}		
		else
		{
			j++;
		}
	}
}

void Board::RandomInsert()
{
	//Wstawia w losowo wybrane miejsce na planszy obiekt klasy Enemy albo Collectible
	//(rodzaj obiektu tez jest losowy).Sprawdza czy w danym miejscu nie ma wê¿a albo innego obiektu któregoœ
	//z tych typów. Ma na znalezienie miejsca 50 prób.
	srand(time(NULL));

	BoardObject RefBO; //s³uzy tylko do porównania za pomoc¹ typeid

	int EnemyOrCollectible = rand() % 2;
	int RandX = 0;
	int RandY = 0;

	int counter = 0;

	bool SeekCoords = true;

	while (SeekCoords && counter < 50) //ma 50 prób
	{

		counter++;
		SeekCoords = false;
		RandX = rand() % WIDTH;
		RandY = rand() % HEIGHT;

		//sprawdza weza
		 std::list<SnakeElement*>::iterator i;
		 for (i = Snake.RealSnake.begin(); i != Snake.RealSnake.end(); ++i)
		 {
			 if ((**i).GridPosition.x == RandX && (**i).GridPosition.y ==RandY)
			 {
				 SeekCoords = true;
			 }
			 
		 }

		 //sprawdza planszê
		 if (typeid((*_grid[RandX][RandY])) != typeid(RefBO))
		 {
			 SeekCoords = true;
		 }
	}

	if (counter < 50)
	{
		delete _grid[RandX][RandY];
		if (EnemyOrCollectible == 0)
			_grid[RandX][RandY] = _factory.CreateEnemy(RandX,RandY);
		else
			_grid[RandX][RandY] = _factory.CreateCollectible(RandX, RandY);
	}

}
void Board::Update()
{
	//Sprawdza kolizjê i wychwytje obiekty poza granicami mapy:
	//wywo³ujj¹c metody CheckBoundaries() i CheckCollisions().
	if (Snake.State == Snake.Dead)
	{
		std::cout << "WAZ MARTWY!" << std::endl;
	}
	CheckBoundaries();
	CheckCollisions();
}



void Board::SaveScore()
{
	//Zapisuje wynik do pliku z wynikami (dopisuje go na koñcu).
	std::ofstream myfile;
	myfile.open("Scores/gamescores.txt",std::ios::app);
	if (myfile.is_open())
	{
		myfile << _points << "\n";
		myfile.close();
	}
	else
		std::cout << "Nie mozna otworzyc pliku highscore.txt";
}