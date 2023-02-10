// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y). 

System.Console.WriteLine("Entre section number ");
int num = int.Parse(Console.ReadLine());


if(num == 1)
{
    Console.WriteLine("X>0 & Y>0");
}

else if(num==2)
{
    Console.WriteLine("X<0 & Y>0");
}
else if(num==3)
{
    Console.WriteLine("X<0 & Y<0");
}
else if(num==4)
{
    Console.WriteLine("X>0 & Y<0");
}
else
{
    Console.WriteLine("Wrong number");
}

while (true)
{
    System.Console.WriteLine("Enter quarter number ");
    quarter = int.Parse(Console.ReadLine());
    if (quarter >=1 && quarter <= 4)
    {
    break;
    }
}

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.


