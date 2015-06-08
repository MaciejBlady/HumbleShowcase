#include "Board.h"

Board::Board()
{
	//granice planszy na ekranie
	_boundaries = sf::IntRect(0, 0, WIDTH * 50+50, HEIGHT * 50+50);

	//tworzenie pocz�tkowego weza
	Snake.CreateStartingSnake();

	//zerowanie punkt�w
	_points.Reset();
}


Board::~Board()
{

	//dealokacja pami�ci
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

	//zniszczenie w�a
	Snake.Reset();
	//ponowne wype�ieni w�a
	Snake.CreateStartingSnake();
	//reset punkt�w
	_points.Reset();
}

std::list<VisibleObject> Board::ReturnVOList()
{
	//implementacja interfejsu IView
	std::list<VisibleObject> TempList;
	
	//zwraca list� obiekt� do narysowania na ekranie
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

	//pocz�tkowe wype�nianie planszy obiektami klasy Empty
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

	//zast�powanie elementu o wsp (x,y) nowym elementem klasy Empty
	BoardObject * temp;

	temp = _grid[x][y];
	_grid[x][y] = _factory.CreateEmpty(y,x);
	if (temp)
	delete temp;
}
void Board::InsertEnemyIntoGrid(int x, int y)
{
	//zast�powanie elementu o wsp (x,y) nowym elementem klasy Enemy
	BoardObject * temp;

	temp = _grid[x][y];
	_grid[x][y] = _factory.CreateEnemy(x, y);
	
	if (temp)
	delete temp;
}
void Board::InsertCollectibleIntoGrid(int x, int y)
{
	//zast�powanie elementu o wsp (x,y) nowym elementem klasy Collectible (znajd�ka)
	BoardObject * temp;

	temp = _grid[x][y];
	_grid[x][y] = _factory.CreateCollectible(x, y);

	if (temp)
	delete temp;
}

void Board::CheckBoundaries()
{
	//sprawdza czy pociski znajduj� si� w granicach planszy:
	//je�li nie to zostaj� usuni�te
	std::vector<Projectile*>::iterator j = Snake.Projectiles.begin();
	while (j != Snake.Projectiles.end())
	{
		if (!_boundaries.contains((**j).WindowCoords.x, (**j).WindowCoords.y))
		{
			std::cout << "usuni�to z x: " << (**j).WindowCoords.x << "y: " <<(**j).WindowCoords.y << std::endl;
			delete (*j);
			j =Snake.Projectiles.erase(j);
		}
		else
		{
			j++;
		}
	}

	//sprawdza, czy g�awa w�a znajduje si� w granicach planszy, je�li nie, to 
	//"przenosi" j� na drug� jej stron�
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

	//"doci�ga" reszte cia�a do g�owy (o 1 kratk�)
	Snake.Update();
}
void Board::CheckCollisions()
{
	//wywo�uje metody sprawdzaniai rozwi�zywania kolizji
	CheckSnakeBoardCollisions();
	CheckSnakeSelfCollisions();
	CheckProjectilesCollisions();
}


void Board::CheckSnakeSelfCollisions()
{
	//sprawdz, czy w�� nie zjada sam siebie por�wnuj�c koordunaty jego g�owy,z reszt� cia�a
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
	//sprawdza czy nie nast�pi�a kolizja w�a z wrogiem albo znjad�k�.
	//wykorzystuje w tym celu lokalne obiekty Enemy i Collectible,
	//z kt�rymi por�wnuje (za pomoc� RTTI) element na planszy znajduj�cy si�
	//pod g�ow� we�a
	Collectible RefCollectible;
	Enemy RefEnemy;
	SnakeElement* (head) = Snake.RealSnake.front();


	//dla kolizji z przeciwnikiem, zabija w�a
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

		//wyd�u�a w�a
		Snake.GrowInSize();		
	}
}


void Board::CheckProjectilesCollisions()
{
	//Sprawdza kolizje pocisk�w, u�ywaj�c por�wnawczego obiektu klasy Enemy.
	//Je�li tak� wykryje, to niszczy pocisk, niszczy wroga i na jego mijsce wstwia BoardObject'a
	std::vector<Projectile*>::iterator j = Snake.Projectiles.begin();
	while (j != Snake.Projectiles.end())
	{
		Enemy RefEnemy;

		//Oblicza na kt�rym polu na planszy znajduje si� pocisk
		BoardObject::Coords GridCoords;
		GridCoords.x = ((**j).WindowCoords.x - SIDE_MARGIN) / 50;
		GridCoords.y = ((**j).WindowCoords.y - UPPER_MARGIN) / 50;

		if (GridCoords.x>WIDTH || GridCoords.x<0 || GridCoords.y>HEIGHT || GridCoords.y<0)
			return;

		if (typeid((*_grid[GridCoords.x][GridCoords.y])) == typeid(RefEnemy))
		{
			//dodawnie punkt�w
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
	//(rodzaj obiektu tez jest losowy).Sprawdza czy w danym miejscu nie ma w�a albo innego obiektu kt�rego�
	//z tych typ�w. Ma na znalezienie miejsca 50 pr�b.
	srand(time(NULL));

	BoardObject RefBO; //s�uzy tylko do por�wnania za pomoc� typeid

	int EnemyOrCollectible = rand() % 2;
	int RandX = 0;
	int RandY = 0;

	int counter = 0;

	bool SeekCoords = true;

	while (SeekCoords && counter < 50) //ma 50 pr�b
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

		 //sprawdza plansz�
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
	//Sprawdza kolizj� i wychwytje obiekty poza granicami mapy:
	//wywo�ujj�c metody CheckBoundaries() i CheckCollisions().
	if (Snake.State == Snake.Dead)
	{
		std::cout << "WAZ MARTWY!" << std::endl;
	}
	CheckBoundaries();
	CheckCollisions();
}



void Board::SaveScore()
{
	//Zapisuje wynik do pliku z wynikami (dopisuje go na ko�cu).
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