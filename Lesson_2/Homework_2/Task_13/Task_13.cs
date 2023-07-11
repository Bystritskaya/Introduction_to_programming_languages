/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = GetThirdDigit(number);
if (thirdDigit != -1)
{
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
Console.ReadLine();
static int GetThirdDigit(int number)
{
    int digitCount = GetDigitCount(number);
    if (digitCount >= 3)
    {
        int divider = (int)Math.Pow(10, digitCount - 3);
        return (number / divider) % 10;
    }
    return -1;
}
static int GetDigitCount(int number)
{
    int count = 0;
    int temp = number;
    while (temp != 0)
    {
        temp /= 10;
        count++;
    }
    return count;
}