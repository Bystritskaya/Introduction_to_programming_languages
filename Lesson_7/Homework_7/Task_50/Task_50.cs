/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.WriteLine("Введите количество строк (m):");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n):");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateArray(m, n);
Console.WriteLine("Введите позицию элемента (строка и столбец):");

int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());

double element = GetArrayElement(array, row, column);
if (!double.IsNaN(element))
{
    Console.WriteLine($"Значение элемента: {element}");
}
    else
{
    Console.WriteLine("Такого элемента нет в массиве");
}
Console.ReadLine();

static double[,] CreateArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine($"Введите элемент массива [{i}, {j}]:");
            array[i, j] = Convert.ToDouble(Console.ReadLine());
        }
    }
    return array;
}

static double GetArrayElement(double[,] array, int row, int column)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    if (row >= 0 && row < rows && column >= 0 && column < columns)
    {
        return Math.Round(array[row, column], 2);
    }
    else
    {
        return double.NaN;
    }
}