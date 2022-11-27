/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] CreateMatrix()
{
    Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m,n];
    return array;
}

int[,] FillMatrix(int[,] arr)
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

int[,] ProductMatrix(int[,] mat1, int[,] mat2)
{
    if (mat1.GetLength(1) != mat2.GetLength(0)) throw new Exception("Перемножение невозможно"); //способ взят из дополнительных источников
    int[,] resultMatrix = new int[mat1.GetLength(0), mat2.GetLength(1)];
        for (int i = 0; i < mat1.GetLength(0); i++)
        {
            for (int j = 0; j < mat2.GetLength(1); j++)
            {
                for (int q = 0; q < mat2.GetLength(0); q++)
                {
                    resultMatrix[i, j] += mat1[i, q] * mat2[q, j];
                }
            }
        }
    return resultMatrix;
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

PrintArray(ProductMatrix(FillMatrix(CreateMatrix()), FillMatrix(CreateMatrix())));