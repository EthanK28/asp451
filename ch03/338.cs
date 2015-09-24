using System;


enum Direction
{
	Forward, 
	Backward, 
	Left,
	Right
}

enum Fruit { Apple = 5, Banana, Grape = 10, Orange };

enum Gender : byte { Male, Female }
class Program
{


static void Main(string[] args)
{
    Direction dir = Direction.Left;
    bool isLeft = (dir == Direction.Left);
    int dirValue = (int)dir;
    string dirName = Enum.GetName(typeof (Direction), 3);
        
    Console.WriteLine("{0}, {1}, {2}", isLeft, dirValue, dirName);

    Console.WriteLine("{0}, {1}, {2}", (int)Fruit.Apple, (int)Fruit.Banana, (int)Fruit.Grape, (int)Fruit.Orange);
}

}