/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("Введите количество строк (m):");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n):");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateArray(m, n);
double[] columnAverages = CalculateColumnAverages(array, m, n);
Console.WriteLine("Средние арифметические значения столбцов:");

for (int j = 0; j < n; j++)
{
    Console.WriteLine($"Столбец {j + 1}: {columnAverages[j]}");
}
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

static double[] CalculateColumnAverages(int[,] array, int m, int n)
{
    double[] columnAverages = new double[n];
    for (int j = 0; j < n; j++)
    {
        int sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum += array[i, j];
        }
        columnAverages[j] = Math.Round((double)sum / m, 1);
    }
    return columnAverages;
}