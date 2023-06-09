﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine()!);

double[,] array = GetArray(m, n);
PrintArray(array);

// ----------------Заполнение массива
double[,] GetArray(int m, int n)
{
    double[,] res = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++){
            res[i, j] = Math.Round(rnd.NextDouble() * 100 + 1, 3);
        }
    }
    return res;
}

// -----------------Вывод массива-----------------
void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
