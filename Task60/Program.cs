/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] CreateArray()
{
    Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите глубину массива");
    int q = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[m,n,q];
    return array;
}

int[,,] FillArrayNoRepeat(int[,,] array)
{
    Random rand = new Random();
    int index = array.GetLength(0) * array.GetLength(1) * array.GetLength(2);
    int[] arrNumbers = new int[index];
    for (int countColumn=0; countColumn < array.GetLength(0); countColumn++)
    {
        for (int countLine=0; countLine < array.GetLength(1); countLine++)
        {
            for (int countDepth=0; countDepth < array.GetLength(2); countDepth++)
            {
                int i = 0;
                int number = rand.Next(10,100);
                if (arrNumbers.Contains(number))           // метод взят из внешних источников
                {
                    countDepth--;
                }
                else
                {
                    array[countColumn, countLine, countDepth] = number;
                    arrNumbers[i] = number;
                    i++;
                }
            }
        }
    }
    return array;
}

void PrintArrayAndIndex (int[,,] array)
{
    
    for (int countColumn=0; countColumn < array.GetLength(0); countColumn++)
    {
        for (int countLine=0; countLine < array.GetLength(1); countLine++)
        {
            for (int countDepth=0; countDepth < array.GetLength(2); countDepth++)
            {
            Console.Write($"{array[countColumn, countLine, countDepth]} ({countColumn}, {countLine}, {countDepth}) ");
            }
            Console.WriteLine();
        }
    }
}

PrintArrayAndIndex(FillArrayNoRepeat(CreateArray()));