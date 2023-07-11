/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

Console.WriteLine("Введите количество чисел:");
int M = Convert.ToInt32(Console.ReadLine());
int count = CountPositiveNumbers(M);
Console.WriteLine($"Количество чисел больше 0: {count}");
Console.ReadLine();

static int CountPositiveNumbers(int M)
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine($"Введите число #{i + 1}:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            count++;
        }
    }
    return count;
}