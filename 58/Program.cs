// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.Write("Введите количество строк 1 массива: ");
int rowsA = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов 1 массива: ");
int columnsA = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк 2 массива: ");
int rowsB = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов 2 массива: ");
int columnsB = int.Parse(Console.ReadLine());

if (columnsA != rowsB)
{
    Console.WriteLine("Такие матрицы умножать невозможно!");
    return;
}

int[,] A = new int[rowsA, columnsA];
int[,] B = new int[rowsB, columnsB];
int[,] C = new int[A.GetLength(0), B.GetLength(1)];

FillMatrix(A);
PrintMatrix(A);
Console.WriteLine();
FillMatrix(B);
PrintMatrix(B);
Console.WriteLine();
GetMultiplicationMatrix(A, B, C);
PrintMatrix(C);

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (new Random().Next(1, 10));
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    const int cellWidth = 5;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}
void GetMultiplicationMatrix(int[,] A, int[,] B, int[,] C)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int k = 0; k < A.GetLength(1); k++)
            {
                C[i, j] += A[i, k] * B[k, j];
            }
        }
    }
}