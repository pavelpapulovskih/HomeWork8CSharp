// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] array = new int[2, 2];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int[,] array1 = new int[2, 2];
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
int[,] arraySum = new int[2, 2];
Matrix(arraySum);
PrintArray(arraySum);



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 5);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void Matrix(int[,] arraySum)
{
    for (int i = 0; i < 2; i++)
        for (int j = 0; j < 2; j++)
        {
            int sum = 0;
            for (int k = 0; k < 2; k++)
            {
                sum += array[i, k] * array1[k, j];
            }
            arraySum[i, j] = sum;
        }
}



