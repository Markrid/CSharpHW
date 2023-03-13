// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

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

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}

double[] AverageMean(int[,] matrix)
{
    int countRows = matrix.GetLength(0);
    int countColumns = matrix.GetLength(1);

    double[] array = new double[countColumns];
    double sum = 0;
    for (int i = 0; i < countColumns; i++)
    {
        sum = 0;
        for (int j = 0; j < countRows; j++)
        {
            sum = sum + matrix[j, i];
        }
        array[i] = sum / countRows;
    }
    return array;
}

int[,] Matrix = GetMatrix(5, 5);
PrintMatrix(Matrix);

double[] array = AverageMean(Matrix);
Console.WriteLine("Среднее арифмитическое по столбцам:");
PrintArray(array);