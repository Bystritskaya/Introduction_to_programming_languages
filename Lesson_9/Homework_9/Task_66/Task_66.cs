/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());
int sum = SumNaturalNumbers(m, n);
Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {sum}");

static int SumNaturalNumbers(int m, int n)
{
    if (m > n)
    return 0;
    return m + SumNaturalNumbers(m + 1, n);
}