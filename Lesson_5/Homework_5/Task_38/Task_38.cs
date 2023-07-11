/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.WriteLine("Введите количество элементов массива:");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите элемент массива #{i + 1}:");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
double min = array[0];
double max = array[0];

for (int i = 1; i < N; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    else if (array[i] > max)
    {
        max = array[i];
    }
}
double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
Console.ReadLine();