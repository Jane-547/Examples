// Задача 39:
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый на последнем и т.д.)
// [1 2 3 4 5]
// --> [5 4 3 2
// [6 7 3 6]
// --> [6 3 7


int EnterNumber(string number)
{
    Console.Write($"Enter {number}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}



int [] CreateArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int ArraySize = EnterNumber("Enter array size");
int minValue = EnterNumber("Enter minValue for array");
int maxValue = EnterNumber("Enter maxValue for array");
int Result = 0;
Console.WriteLine();

int [] numbers = CreateArray(ArraySize, minValue, maxValue);

Console.WriteLine(String.Join(" ", numbers));
Console.WriteLine();

Console.WriteLine(String.Join(" ", ReversArray(numbers)));

int [] ReversArray (int [] set)
{
    
    for (int i = 0; i < set.Length/2; i++)
    {
    int temp = set [i];
    set[i] = set [set.Length - 1 - i];
    set [set.Length - 1 - i] = temp;
    }
    return set;
}

/*
Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый на последнем и т.д.)
[1 2 3 4 5]
--> [5 4 3 2
[6 7 3 6]
--> [6 3 7
*/

#nullable disable

System.Console.WriteLine("Enter array legth: ");
int length = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter array minimal: ");
int min = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter array maximal: ");
int max = int.Parse(Console.ReadLine());

int[] MyArray = GetArray(length, min, max);

System.Console.WriteLine($"[{string.Join(", ", MyArray)}]");

int[] GetArray (int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+ 1);        
    }
    return result;
}

Array.Reverse(MyArray);

System.Console.WriteLine($"[{string.Join(", ", MyArray)}]");

Решение в группах задач:
Задача 40:
Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.

/*
Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

#nullable disable

System.Console.WriteLine("enter coordinates point A ");
int A = int.Parse(Console.ReadLine());

System.Console.WriteLine("enter coordinates point B");
int B = int.Parse(Console.ReadLine());

System.Console.WriteLine("enter coordinates point A");
int C = int.Parse(Console.ReadLine());

bool IsTriangle(int a,int b,int c)
{
    return (((a+b)>c)&&((a+c)>b)&&((b+c)>a));
}
if  (IsTriangle(A, B, C))
{
    System.Console.WriteLine("Can exist ");
}
else
{
    System.Console.WriteLine("Impissible ");
}

Задача 42:
Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45
--> 101101
3
--> 11
2
--> 10
20 мин

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int[]Numbers(int num)
{
    int size = 32;
    int [] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i]= num % 2;
        num /=2;
    }
    return result;
}
int[] Binary = (Numbers(number));
Array.Reverse(Binary);
Console.WriteLine("Полученный массив = "+ String.Join(" ", Binary));

split