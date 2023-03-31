// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




int size = 4;
int[,] array = new int[size, size];
FillArray(array);
PrintArray(array);



void FillArray(int[,] array)
{
    int count = 1;
    int minRow = 0;
    int maxRow = size - 1;
    int minCol = 0;
    int maxCol = size - 1;

    while (count <= size * size)
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            array[minRow, i] = count;
            count++;
        }
        minRow++;

        for (int i = minRow; i <= maxRow; i++)
        {
            array[i, maxCol] = count;
            count++;
        }
        maxCol--;

        for (int i = maxCol; i >= minCol; i--)
        {
            array[maxRow, i] = count;
            count++;
        }
        maxRow--;

        for (int i = maxRow; i >= minRow; i--)
        {
            array[i, minCol] = count;
            count++;
        }
        minCol++;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

