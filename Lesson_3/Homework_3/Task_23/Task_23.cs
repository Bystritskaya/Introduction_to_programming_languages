/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел от 1 до " + N + ":");

for (int i = 1; i <= N; i++)
{
    int cube = i * i * i;
    Console.WriteLine($"{i}^3 = {cube}");
}
Console.ReadLine();