/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] arr = new int[4,4];
for (int countColumn=0; countColumn < arr.GetLength(0); countColumn++)
    {
        for (int countLine=0; countLine < arr.GetLength(1); countLine++)
        {
            arr[countColumn, countLine] = 0;
        }
    }


PrintArray(FillArraySpiral(arr));


int[,] FillArraySpiral(int[,] arr)
{
    int number = 1;
    for (int a = 0; a < arr.GetLength(0) / 2; a++)
    {
   for (int countColumns = 0 + a; countColumns < arr.GetLength(0) - a; countColumns++)
    {
        arr[0 + a, countColumns] = number;
        number++;
    }
    for (int countLines = 1 + a; countLines < arr.GetLength(1) - a; countLines++)
    {
        arr[countLines, arr.GetLength(0) - 1 - a] = number;
        number++;
    }
    for (int countColumns = 2 - a; countColumns > -1 + a; countColumns--)
    {
        arr[arr.GetLength(1) - 1 - a, countColumns] = number;
        number++;
    }
    for (int countLines = 2 - a; countLines > 0 + a; countLines--)
    {
        arr[countLines, 0 + a] = number;
        number++;
    }
    }

    return arr;
}


void PrintArray (int[,] arr)
{
    for (int countColumn=0; countColumn < arr.GetLength(0); countColumn++)
    {
        for (int countLine=0; countLine < arr.GetLength(1); countLine++)
        {
            Console.Write($"{arr[countColumn, countLine]} ");
        }
        Console.WriteLine();
    }

}


