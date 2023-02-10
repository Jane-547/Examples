// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int [] SomeElements(int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] Massiv = SomeElements (5, 0, 5);

Console.WriteLine(String.Join(" ", Massiv));

System.Console.Write("Введите число: ");
int temp = int.Parse(Console.ReadLine());

bool Yes = false; 

foreach (var i in Massiv)
{
    if (Math.Abs(i) == Math.Abs(temp))
    Yes = true;
}

if (Yes) System.Console.WriteLine("Да");
else
{
    System.Console.WriteLine("Нет!");
}





