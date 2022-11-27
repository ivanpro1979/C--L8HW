// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.Write("Введите размеры массива через пробел: ");
// string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]) });
// PrintArray(array);

Console.Clear();

Console.Write("Введите cтроки  матицы: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите колонки матицы: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите слои  матицы: ");
int length = int.Parse(Console.ReadLine());
if ( (row * column * length) >= 89)
{
    Console.WriteLine("Размер матрицы не позволяет не повторять двузначные числа (максимум 89 элементов)!");
    return;
}
int[,,] array = new int[row, column, length];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine();

const int cellWidth = 3;

void FillMatrix(int[,,] matrix)
{
    int[] uniqueArray = new int[89];
    int num;

    for (int i = 0; i < uniqueArray.Length; i++)
    {
        num = new Random().Next(10, 100);
        for (int j = i; j >= 0; j--)
        {
            if (uniqueArray[j] == num)
            {
                num = new Random().Next(10, 100);
                j = i;
            }
        }
        uniqueArray[i] = num;
    }
    num = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {            
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = uniqueArray[num];
                num++;                     
            } 
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           for (int k = 0; k < matrix.GetLength(2); k++)
           {
            Console.Write($"{matrix[i, j, k],cellWidth}({i}, {j}, {k})");
           } 
           Console.WriteLine($"");            
        }        
    }
    Console.WriteLine();
}
