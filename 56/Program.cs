// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrixSort = new int[rows, columns];

FillMatrix(matrixSort);
PrintMatrix(matrixSort);
Console.WriteLine();
GetRowMinSumNumber(matrixSort);
Console.WriteLine($"Строка с наименьшей суммой -{GetRowMinSumNumber(matrixSort)} строка");

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
int GetRowMinSumNumber(int[,] matrix)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minsum += matrix[0, i];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}