/*
Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int n = 4;
int[,] array = new int[n, n];
FillSpiralArray(array, n);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j].ToString("D2") + " ");
    }
    Console.WriteLine();
}

static void FillSpiralArray(int[,] array, int n)
{
    int num = 1;
    int top = 0;
    int bottom = n - 1;
    int left = 0;
    int right = n - 1;
    
    while (num <= n * n)
    {
        for (int i = left; i <= right; i++)
        {
            array[top, i] = num++;
        }
        top++;

        for (int i = top; i <= bottom; i++)
        {
            array[i, right] = num++;
        }
        right--;

        for (int i = right; i >= left; i--)
        {
            array[bottom, i] = num++;
        }
        bottom--;

        for (int i = bottom; i >= top; i--)
        {
            array[i, left] = num++;
        }
        left++;
    }
}