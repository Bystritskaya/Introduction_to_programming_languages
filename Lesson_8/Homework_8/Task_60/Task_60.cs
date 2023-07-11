/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Write("Введите количество строк (m): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов (n): ");
int n = int.Parse(Console.ReadLine());

int[, ,] array = new int[m, n, 2];
Console.WriteLine("Введите неповторяющиеся двузначные числа:");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            Console.Write($"Введите число для элемента ({i},{j},{k}): ");
            int number = int.Parse(Console.ReadLine());
            // Проверяем, что число двузначное и не повторяется в массиве
            while (number < 10 || number > 99 || IsNumberRepeated(array, number))
            {
                Console.WriteLine("Некорректное число или число уже повторяется. Попробуйте еще раз.");
                Console.Write($"Введите число для элемента ({i},{j},{k}): ");
                number = int.Parse(Console.ReadLine());
            }
            array[i, j, k] = number;
        }
    }
}

Console.WriteLine("Трехмерный массив:");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");
        }
    }
}

static bool IsNumberRepeated(int[, ,] array, int number)
{
    foreach (int element in array)
    {
        if (element == number)
        {
            return true;
        }
    }
    return false;
}