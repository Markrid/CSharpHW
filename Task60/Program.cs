// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// Сама программа:
int[,,] matrix = GetMatrix(2, 2, 2);
PrintMatrix(matrix);


// Используемые методы

/// <summary>
/// Метод генерирует трехмерный массив из случайных двузначных чисел
/// </summary>
/// <param name="width">Ширина массива</param>
/// <param name="height">Высота массива</param>
/// <param name="depth">Глубина массива</param>
/// <returns>Трехмерный массив</returns>
int[,,] GetMatrix(int width, int height, int depth)
{
    int[,,] matrix = new int[width, height, depth];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return matrix;
}

/// <summary>
/// Метод печатает (выводит в консоль) трёхмерный массив
/// </summary>
/// <param name="matrix">Трёхмерный массив для печати</param>
void PrintMatrix(int[,,] matrix)
{
    int width = matrix.GetLength(0);
    int height = matrix.GetLength(1);
    int depth = matrix.GetLength(2);

    for (int i = 0; i < width; i++)
    {
        for (int m = 0; m < height; m++)
        {
            for (int j = 0; j < depth; j++)
            {
                Console.Write($"{matrix[i, m, j]} ({i},{m},{j}) \t");
            }
        }
        Console.WriteLine();
    }
}
