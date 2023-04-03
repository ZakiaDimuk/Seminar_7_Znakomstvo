// Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), 
// проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, что оно найдено, 
// а также какое число стоит на этом месте или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 3 -> Такой элемент есть: 3
// i = 4, j = 2 -> такого элемента в массиве нет

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);

//-------------Основные вычисления-------------------
Console.Write("Введите значение строки i = ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение строки j = ");
int b = int.Parse(Console.ReadLine()!);

if (a < m && b < n)
{
    Console.WriteLine($"Значение элемента = {array[a,b]}");
}
else
{
    Console.WriteLine("Такого элемента в массиве нет");
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