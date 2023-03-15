// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Сама программа:

int[,] matrix1 = GetMatrix(2, 3);
int[,] matrix2 = GetMatrix(3, 5);
Console.WriteLine("Сгенерированный двумерный массив № 1:");
PrintMatrix(matrix1);
Console.WriteLine("Сгенерированный двумерный массив № 2:");
PrintMatrix(matrix2);
int[,] result = ProductMatrix(matrix1, matrix2);
Console.WriteLine("Произведение массивов равно:");
PrintMatrix(result);

//Используемые методы

/// <summary>
/// Метод создаёт двумерный массив целых чисел по заданным параметрам и заполняет элементами от 0 до 99
/// </summary>
/// <param name="rows">Параметр, определяющий количество строк в массиве</param>
/// <param name="columns">Параметр, определяющий количество стобцов в массиве</param>
/// <returns>Возвращает массив</returns>
int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
        Console.WriteLine();
    }
    return matrix;
}

/// <summary>
/// Метод печатает (выводит в консоль) двумерный массив
/// </summary>
/// <param name="matrix">Двумерный массив для печати</param>
void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int m = 0; m < columns; m++)
        {
            Console.Write(matrix[i, m] + "\t");
        }
        Console.WriteLine();
    }

}

/// <summary>
/// Метод перемножает два двумерных массива
/// </summary>
/// <param name="matrix1">Двумерный массив № 1</param>
/// <param name="matrix2">Двумерный массив № 2</param>
/// <returns>Возвращает двумерный массив как результата перемножения</returns>
int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] compositionMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < compositionMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < compositionMatrix.GetLength(1); j++)
            {

                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    compositionMatrix[i, j] = compositionMatrix[i, j] + matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    else
    {
        Console.Write("Ваши массивы нельзя перемножить, количество столбцов в первом массиве не соответствует количству строк во втором массиве!");
    }
    return compositionMatrix;
}