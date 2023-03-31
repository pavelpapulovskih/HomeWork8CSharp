// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void FillArray(int[,,] array)
{
int num = 10;
for (int i = 0; i < 2; i++)
    for (int j = 0; j < 2; j++)
        for (int z = 0; z < 2; z++)
        {
            array[i, j, z] = num;
            num++;
        }
}


void PrintArray(int[,,] array)
{
for (int i = 0; i < 2; i++)
    for (int j = 0; j < 2; j++)
        for (int z = 0; z < 2; z++)
        {
            Console.WriteLine("array[{0},{1},{2}] = {3}", i, j, z, array[i, j, z]);
        }
}

int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintArray(array);
