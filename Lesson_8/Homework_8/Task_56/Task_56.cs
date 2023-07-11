/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("Введите количество строк (m):");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n):");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateArray(m, n);
int minRow = FindRowWithMinSum(array, m, n);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");
Console.ReadLine();

static int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine($"Введите элемент массива [{i}, {j}]:");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array;
}

static int FindRowWithMinSum(int[,] array, int m, int n)
{
    int minSum = int.MaxValue;
    int minRow = -1;
    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow;
}