/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateArraySquare ()
{   Console.WriteLine("Введите длину строки и столбца");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m,m];
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

int[] CreateLineSumArray (int[,] array)
{
    int [] lineSumArray = new int[array.GetLength(0)];
    for (int countColumn = 0; countColumn < array.GetLength(0); countColumn++)
    {
        int lineSum = 0;
        for (int countLine = 0; countLine < array.GetLength(1); countLine++)
        {
            lineSum = lineSum + array[countColumn, countLine];
        }
        lineSumArray[countColumn] = lineSum;
    }
    return lineSumArray;
}

void PrintLowestArrayNumber (int[] arr)
{
    int result = arr[0];
    int resultNumber = 0;
    for (int count = 0; count < arr.Length; count++)
    {
        if (arr[count] < result) 
        {
            result = arr[count];
            resultNumber = count;
        }
    }
    Console.WriteLine ($"Номер строки с наименьшей суммой элементов {resultNumber}");

}

PrintLowestArrayNumber(CreateLineSumArray(FillArray(CreateArraySquare())));
