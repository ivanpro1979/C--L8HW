// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

Console.WriteLine("Введите строки массива колонки массива: ");
int[,] mat = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];

SpiraleFillMatrix(mat);
PrintMatrix(mat);

void SpiraleFillMatrix(int[,] matrix)
{
    int num = 1;
    int VertikaleNum = matrix.GetLength(0) - 1; 
    int HorisotaleNum = matrix.GetLength(1) - 1; 
    int stars = 0;
    int i = 0;
    int j = 0;

    while (VertikaleNum != 0 && HorisotaleNum != 0)
    {
        for (j = stars; j <= HorisotaleNum; j++)
        {
            matrix[i, j] = num;
            num++;
        }
        j--;
        stars++;
        for (i = stars; i <= VertikaleNum; i++)
        {
            matrix[i, j] = num;
            num++;
        }
        i--;
        stars--;
        HorisotaleNum--;
        for (j = HorisotaleNum; j >= stars; j--)
        {
            matrix[i, j] = num;
            num++;
        }
        j++;
        stars++;
        VertikaleNum--;
        for (i = VertikaleNum; i >= stars; i--)
        {
            matrix[i, j] = num;
            num++;
        }
        i++;        
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j] : 0#}");
        }
        Console.WriteLine($" ");
    }
    Console.WriteLine();
}