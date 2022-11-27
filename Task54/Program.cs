/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] CreateArray ()
{   Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m,n];
    return array;
}

int[,] FillArray (int[,] arr)
{
    for (int countColumn=0; countColumn < arr.GetLength(0); countColumn++)
    {
        for (int countLine=0; countLine < arr.GetLength(1); countLine++)
        {
            Console.WriteLine($"Введите элемент массива номер {countLine}, {countColumn}");
            arr[countColumn, countLine] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return arr;
}

int[,] SortArrayLine (int[,] array)
{
    for (int countColumn = 0; countColumn < array.GetLength(0); countColumn++)
    {
        for (int countLine = 0; countLine < array.GetLength(1); countLine++)
        {
        int temp = 0;
            for (int nextIndex = countLine + 1; nextIndex < array.GetLength(1); nextIndex++)
            {
                if (array[countColumn, countLine] < array[countColumn, nextIndex])
                {
                    temp = array[countColumn, countLine];
                    array[countColumn, countLine] = array[countColumn, nextIndex];
                    array[countColumn, nextIndex] = temp;
                }
            }
        }
    }
    
    return array;
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

PrintArray(SortArrayLine(FillArray(CreateArray())));
