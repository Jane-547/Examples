Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int [,] Massiv = GetIntMatrix(4, 4, 1, 10);

PrintInt(Massiv);
System.Console.WriteLine();
Revers(Massiv);
PrintInt(Massiv);

int [,] GetIntMatrix(int Rows, int Colums, int min, int max)        //рандомная интовая матрица
{
    int [,] matrix = new int [Rows, Colums];
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Colums; j++)
        {
            matrix[i,j] = new Random().Next(min, max+1);
        }
    }
    return matrix;
}


void PrintInt(int [,] matrixInt)               // Выводим нашу матрицу инт
{
    for (int i = 0; i < matrixInt.GetLength(0); i++)
    {
        for (int j = 0; j < matrixInt.GetLength(1); j++)
        {
            System.Console.Write(matrixInt[i,j] + " ");
        }
        System.Console.WriteLine();
    } 
}


void Revers(int [,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) -1, i];
        matrix[matrix.GetLength(0) -1, i]  = temp;

    }
    
}

// 2 задача

Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] ChangeArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j, i] = array[i, j];
        }
    }
    return result;
}

int[,] Massiv = GetIntMatrix(4, 4, 1, 9);
PrintInt(Massiv);
System.Console.WriteLine();
ReversRowsColumns (Massiv);
PrintInt(Massiv);

while (true)
{
    if (Massiv.GetLength(0)==Massiv.GetLength(1))
    break;
    else
    {
        System.Console.WriteLine("Неверный ввод, повторите");
    }
}


int [,] GetIntMatrix(int Rows, int Colums, int min, int max)        //рандомная интовая матрица
{
    int [,] matrix = new int [Rows, Colums];
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Colums; j++)
        {
            matrix[i,j] = new Random().Next(min, max+1);
        }
    }
    return matrix;
}


void PrintInt(int [,] matrixInt)               // Выводим нашу матрицу инт
{
    for (int i = 0; i < matrixInt.GetLength(0); i++)
    {
        for (int j = 0; j < matrixInt.GetLength(1); j++)
        {
            System.Console.Write(matrixInt[i,j] + " ");
        }
        System.Console.WriteLine();
    } 
}


void Revers (int [,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) -1, i];
        matrix[matrix.GetLength(0) -1, i]  = temp;

    }
    
}

void ReversRowsColumns (int [,] matrix)
{
    int temp;
       
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        { temp = matrix[i,j];
           matrix[i,j]=matrix[j,i];
           matrix[j,i]=temp;
        }
    }
    
}

int[,] ChangeArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j, i] = array[i, j];
        }
    }
    return result;
}



