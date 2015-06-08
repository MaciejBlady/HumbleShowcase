#include "Snake.h"


Snake::Snake()
{
	//�adowanie tekstur u�ywanych przez w�a i pociski, oraz ustalanie pocz�tkowego stanu w�a.
	State = GoingUp;
	SnakeSkin.loadFromFile("Textures/snakeTexture.png");
	_projectileTexture.loadFromFile("Textures/Fireball.png");
}


Snake::~Snake()
{
	//dealokacja poami�ci po pociskach
	size_t max_proj = Projectiles.size();
	for (size_t i = 0; i < max_proj; i++)
	{
		Projectile* iter = Projectiles.back();
		delete iter;
		Projectiles.pop_back();
	}

	//dealokacja pami�ci po w�u
	size_t max = RealSnake.size();
	for (size_t i = 0; i < max; i++)
	{
		SnakeElement* tail = RealSnake.back();
		delete tail;
		RealSnake.pop_back();
	}
}

void Snake::Reset()
{
	//Usuwa wszytskie pociski i elemnt we�a, ustawia stan w�a na GoingUp
	size_t max_proj = Projectiles.size();
	for (size_t i = 0; i < max_proj; i++)
	{
		Projectile* iter = Projectiles.back();
		delete iter;
		Projectiles.pop_back();
	}

	Projectiles.clear();
	size_t max = RealSnake.size();

	for (size_t i = 0; i < max; i++)
	{
		SnakeElement* tail= RealSnake.back();
		delete tail;
		RealSnake.pop_back();
	}

	RealSnake.clear();
	State = SnakeState::GoingUp;
}

void Snake::HandleInput(sf::Event & E)
{
	//Implementacja interfejsu IControl. Zmienia stan w�a w zale�no�ci od rodzaju zda�enia
	//przekazanego w argumencie, albo tworzy nowy pocisk zmierzaj�cy do miejsca klikni�cia myszk�.
	switch (E.type)
	{
	case sf::Event::KeyPressed:
		if (E.key.code == sf::Keyboard::W)
			TurnUp();
		else
		if (E.key.code == sf::Keyboard::S)
			TurnDown();
		else
		if (E.key.code == sf::Keyboard::D)
			TurnRight();
		else
		if (E.key.code == sf::Keyboard::A)
			TurnLeft();
		break;

	case sf::Event::MouseButtonPressed:
		if (E.mouseButton.button == sf::Mouse::Left)
			Shoot(E.mouseButton.x, E.mouseButton.y);
		break;
	default:
		break;
	}
}

std::list<VisibleObject> Snake::ReturnVOList()
{

	//Implementacja interfejsu IView. Zwraca list� VisibleObject�w do narysowania.
	std::list<VisibleObject> TempList;

	//Konwertuje Projectile i Snake Elementy do Visible Object�
	std::list<SnakeElement*>::iterator i;
	for (i = RealSnake.begin(); i != RealSnake.end();++i)
	{
		TempList.push_back(**i);
	}

	std::vector<Projectile*>::iterator j;
	for (j = Projectiles.begin(); j != Projectiles.end(); ++j)
	{
		TempList.push_back(**j);
	}

	return TempList;
}

//Zmieniaj� kierunek poruszania si� we��.
void Snake::TurnLeft()
{
	if (State != GoingRight)
	{
		State = GoingLeft;
	}
}
void Snake::TurnRight()
{
	if (State != GoingLeft)
	{
		State = GoingRight;
	}
}
void Snake::TurnUp()
{
	if (State != GoingDown)
	{
		State = GoingUp;
	}
}
void Snake::TurnDown()
{
	if (State != GoingUp)
	{
		State = GoingDown;
	}
}

void Snake::Move()
{

	//Porusza w�em. Najpier przesuwa cia� (MoveBody), a potem g�ow�
	//w kirunku zaleznym od aktualnego stanu w�a
	std::list<SnakeElement*>::iterator i = RealSnake.begin();
	switch (State)
	{
		case Snake::GoingLeft:
		{
			MoveBody();
			--(**i).GridPosition.x;
			Update();
			break;
		}
		case Snake::GoingRight:
		{
			MoveBody();
			(**i).GridPosition.x++;
			Update();
			break;
		}	
		case Snake::GoingUp:
		{
			MoveBody();
			--(**i).GridPosition.y;
			Update();
			break;
		}
		case Snake::GoingDown:
		{
			MoveBody();
			++(**i).GridPosition.y;
			Update();
			break;
		}
		default:
			break;
	}
}

void Snake::MoveBody()
{
	//Poprzedni element w�a przyjmuje wsp�rz�dne nastpenego, opr�cz g�owy
	std::list<SnakeElement*>::iterator i;
	std::list<SnakeElement*>::iterator almostFirst = RealSnake.begin();
	almostFirst++;													
	for (i = --RealSnake.end(); i != RealSnake.begin(); i--)
	{
		std::list<SnakeElement*>::iterator next = i;
		next--;
		(**i).GridPosition = (**next).GridPosition;
	}
}

void Snake::MoveProjectiles(sf::Time timeModifier)
{
	//Porusza wszytskimi pociskami na planszy.
	std::vector<Projectile*>::iterator j;
	for (j = Projectiles.begin(); j != Projectiles.end(); ++j)
	{
		(**j).Move(timeModifier);
	}
}

void Snake::Shoot(int x, int y) //std::list<Projectile>& PL
{
	//Tworzy nowy pocisk zmierzajacy do punktu (x,y). Umieszcza go w li�cie pocisk�w.
	//std::cout << "PEW PEW! x= " << x << "y= " << y << std::endl;
	
	std::list<SnakeElement*>::iterator i = RealSnake.begin();
	Projectile* P = new Projectile((**i).WindowCoords.x, (**i).WindowCoords.y,x,y,_projectileTexture,sf::IntRect(0,0,72,50));
	Projectiles.push_back(P);
}

SnakeElement* Snake::CreateElement(int x, int y)
{
	//Tworzy nowy element w�a.
	SnakeElement* NewElement = new SnakeElement(x, y, SnakeSkin, sf::IntRect(51, 0, 50, 50));
	return NewElement;
}

SnakeElement* Snake::CreateHead(int x, int y)
{
	//Tworzy g�ow� w�a
	SnakeElement* Head = new SnakeElement(x, y, SnakeSkin, sf::IntRect(0, 0, 50, 50));
	return Head;
}

void Snake::CreateStartingSnake()
{
	//Tworzy w�a, jaki zaczyna s� gr�.
	State = SnakeState::GoingUp;
	RealSnake.push_back(CreateHead(7,2));
	for (size_t i = 3; i < 6; i++)
	{
		RealSnake.push_back(CreateElement(7,i));
	}
	GrowInSize();
}

void Snake::GrowInSize()
{
	//Wyd�u�a we�a o jedn� kratk�, zestrony zaleznej od stanu w�a
	SnakeElement* i = RealSnake.back();
	switch (State)
	{
	case Snake::GoingLeft:
		RealSnake.push_back(CreateElement((*i).GridPosition.x+1, (*i).GridPosition.y));
		break;
	case Snake::GoingRight:
		RealSnake.push_back(CreateElement((*i).GridPosition.x-1, (*i).GridPosition.y));
		break;
	case Snake::GoingUp:
		RealSnake.push_back(CreateElement((*i).GridPosition.x, (*i).GridPosition.y+1));
		break;
	case Snake::GoingDown:
		RealSnake.push_back(CreateElement((*i).GridPosition.x, (*i).GridPosition.y-1));
		break;
	default:
		break;
	}
}

void Snake::Update()
{
	//Uaktualnia Sprite'y Element�w we�a.
	std::list<SnakeElement*>::iterator i;
	for (i = RealSnake.begin(); i != RealSnake.end(); ++i)
	{
		(**i).UpdateSprite();
	}
}

