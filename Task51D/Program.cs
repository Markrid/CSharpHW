// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(50);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i, m] + "\t");
        }
        Console.WriteLine();
    }
}

int SumDiagonal(int[,] matrix)
{
    int count = 0;
    int size = matrix.GetLength(0);
    if (matrix.GetLength(0) > matrix.GetLength(1)) size = matrix.GetLength(1);

    for (int i = 0; i < size; i++)
    {
        count = count + matrix[i, i];
    }
    return count;
}

int[,] matrix = GetMatrix(5, 5);
PrintMatrix(matrix);
Console.Write($"Сумма элементов главной диагонали массива равна: {SumDiagonal(matrix)}");
