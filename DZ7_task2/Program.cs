/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
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

void AverageCol(int[,] inArray)
{
    int summ = 0;
    double aver = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            summ += inArray[j, i];
        }
        aver = Math.Round((double)summ / inArray.GetLength(0) , 2);
        Write($"{aver} ");
        summ = 0;
        aver = 0.0;
    }
    WriteLine();
}
int n = new Random().Next(3, 7);
int m = new Random().Next(3, 7);
int[,] array = GetArray(m, n);
PrintArray(array);
WriteLine();
AverageCol(array);