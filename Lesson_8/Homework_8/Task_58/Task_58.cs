/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] matrix1 = ReadMatrix();
int[,] matrix2 = ReadMatrix();

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Невозможно умножить матрицы, так как количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    return;
}

int[,] result = MultiplyMatrices(matrix1, matrix2);
Console.WriteLine("Результат умножения матриц:");
PrintMatrix(result);

static int[,] ReadMatrix()
{
    Console.Write("Введите количество строк матрицы: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов матрицы: ");
    int columns = int.Parse(Console.ReadLine());
    int[,] matrix = new int[rows, columns];
    Console.WriteLine("Введите элементы матрицы:");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"Элемент [{i}, {j}]: ");
            matrix[i, j] = int.Parse(Console.ReadLine());
        }
    }
    return matrix;
}

static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int columns2 = matrix2.GetLength(1);
    int[,] result = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            for (int k = 0; k < columns1; k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}

static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}