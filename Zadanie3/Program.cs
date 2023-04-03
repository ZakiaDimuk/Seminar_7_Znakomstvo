// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);

//----------------Основные вычисления------------------
int i,j;

for (j = 0; j < n; j++)
{
    double sum = 0;
    for (i = 0; i < m; i++)
    {
        sum = sum + array[i,j];
    }
Console.Write($"{sum/(i):F1}; ");
}


//-----------------Заполнение массива--------------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m,n];
    
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++){
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

// -----------------Вывод массива-----------------
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}