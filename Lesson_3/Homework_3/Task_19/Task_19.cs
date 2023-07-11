/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int originalNumber = number;
int reversedNumber = 0;

for (int i = 0; i < 5; i++)
{
    int digit = number % 10;
    reversedNumber = reversedNumber * 10 + digit;
    number /= 10;
}

if (originalNumber == reversedNumber)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
Console.ReadLine();