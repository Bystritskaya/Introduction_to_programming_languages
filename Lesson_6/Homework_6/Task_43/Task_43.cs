/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("Введите значение k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b1:");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = CalculateIntersectionX(k1, b1, k2, b2);
double y = CalculateIntersectionY(k1, b1, x);
Console.WriteLine($"Точка пересечения: ({x}, {y})");
Console.ReadLine();
    
static double CalculateIntersectionX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

static double CalculateIntersectionY(double k, double b, double x)
{
    double y = k * x + b;
    return y;
}