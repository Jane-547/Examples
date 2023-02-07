// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.


// Console.WriteLine("Введите число");
// int numA = Convert.ToInt32(Console.ReadLine());

// int CountNum (int number)
// {
//     int count = 1;
//     for (; number >= 10; count++)
//     {
//         number /= 10;
//     }
//     return count;
// }

// Console.WriteLine(CountNum(numA));

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

System.Console.Write("Enter number N :");
int numN = int.Parse(Console.ReadLine());



if (numN < 1)
{
    System.Console.WriteLine("Число меньше 1");
}
else
{
   
    System.Console.WriteLine($"Произведение =  {GetMult(numN)}");
}


int GetMult(int number)
{
    int Mult = 1;

    for (int i = 1; i <= number; i++)
    {
        Mult *= i;
    }

    return Mult;
}