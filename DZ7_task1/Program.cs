/* Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using System;
using static System.Console;
Clear();

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

void SeekElement(int[,] inArray, int posEl)
{
    if ((inArray.GetLength(0) * inArray.GetLength(1)) < posEl)
    {
        WriteLine(posEl + " -> такого числа в массиве нет");
    }
    else
    {
        int row = posEl % inArray.GetLength(1) == 0 ? posEl / inArray.GetLength(1) - 1 : posEl / inArray.GetLength(1);
        int column = posEl % inArray.GetLength(1) == 0 ? inArray.GetLength(1) - 1 : posEl - inArray.GetLength(1) * row - 1;
        Write("array[" + row + ", " + column + "] = ");
        WriteLine(inArray[row, column]);
    }
}

int n = new Random().Next(3, 7);
int m = new Random().Next(3, 7);
int[,] array = GetArray(m, n);
PrintArray(array);
WriteLine();
WriteLine("Введите искомую позицию pos: ");
int pos = int.Parse(ReadLine());
WriteLine();
SeekElement(array, pos);
WriteLine();