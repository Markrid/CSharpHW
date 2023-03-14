// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// Сама программа:

int[,] matrix = GetMatrix(5, 5);
Console.WriteLine("Сгенерированный двумерный массив:");
PrintMatrix(matrix);
int[,] sortMatrix = SortMatrix(matrix);
Console.WriteLine("Двумерный массив после сортировки:");
PrintMatrix(sortMatrix);

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
            matrix[i, j] = new Random().Next(100);
        }
        Console.WriteLine();
    }
    return matrix;
}

/// <summary>
/// Метод печатает (выводит в консоли) двумерный массив
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
/// Метод сортирует каждую строку массива от большого к меньшему значеничю
/// </summary>
/// <param name="matrix">Сортируемый массив</param>
/// <returns>Возвращает отсортированный массив</returns>
int[,] SortMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int temp;
    for (int l = 0; l < rows; l++)
    {
        for (int k = 0; k < columns; k++)
        {
            for (int j = k + 1; j < columns; j++)
            {
                if (matrix[l, k] < matrix[l, j])
                {
                    temp = matrix[l, k];
                    matrix[l, k] = matrix[l, j];
                    matrix[l, j] = temp;
                }
            }
        }
    }
    return matrix;
}