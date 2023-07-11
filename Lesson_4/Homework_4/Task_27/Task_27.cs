/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = CalculateDigitSum(number);
Console.WriteLine($"Сумма цифр в числе: {sum}");
Console.ReadLine();

static int CalculateDigitSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = GetLastDigit(number);
        sum += digit;
        number = RemoveLastDigit(number);
    }
    return sum;
}

static int GetLastDigit(int number)
{
    return number % 10;
}

static int RemoveLastDigit(int number)
{
    return number / 10;
}