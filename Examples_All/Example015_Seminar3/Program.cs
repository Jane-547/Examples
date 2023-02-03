// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

System.Console.WriteLine("Введите число N: ");

int numN = int.Parse(Console.ReadLine());

double SqrN=1;

while (SqrN<=numN)
{
    System.Console.Write(Math.Pow(SqrN,2)+" ");
    SqrN++;
}


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

System.Console.WriteLine("Введите координаты точки A x и y: ");

double cordxA = double.Parse(Console.ReadLine());

double cordyA = double.Parse(Console.ReadLine());

double cordzA = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B x и y: ");

double cordxB = double.Parse(Console.ReadLine());

double cordyB = double.Parse(Console.ReadLine());

double cordzB = double.Parse(Console.ReadLine());

double Dsqr = Math.Sqrt((Math.Pow((cordxB-cordxA),2))+(Math.Pow((cordyB-cordyA),2)));

System.Console.WriteLine(Dsqr);


// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите четверть");

int chet = int.Parse(Console.ReadLine());

if (chet==1)
{
    System.Console.WriteLine("x>0 y>0");
}
else if (chet==2)
{
    System.Console.WriteLine("x<0 y>0");
}
else if (chet==3)
{
    System.Console.WriteLine("x<0 y<0");
}
else if (chet==4)
{
    System.Console.WriteLine("x>0 y<0");
}
else if (chet==0)
{
    System.Console.WriteLine("x=0 y=0");
}
else 
{
    System.Console.WriteLine("Wrong number");
}

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

System.Console.WriteLine("Enter number X: ");

int numX = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number Y: ");

int numY = int.Parse(Console.ReadLine());

if (numX>0 && numY>0)
{
    System.Console.WriteLine("1 section");
}
else if (numX<0 && numY>0)
{
    System.Console.WriteLine("2 section");
}
else if (numX<0 && numY<0)
{
    System.Console.WriteLine("3 section");
}
else if (numX>0 && numY<0)
{
    System.Console.WriteLine("4 section");
}
else
{
    System.Console.WriteLine("0 section");
}

