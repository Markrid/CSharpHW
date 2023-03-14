// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// Сама программа:

int[,] matrix = GetMatrix(11, 10);
Console.WriteLine("Сгенерированный двумерный массив:");
PrintMatrix(matrix);
int[] arraySum = SumNumberInRow(matrix);
PrintArraySum(arraySum);
PrintRowMinSum(arraySum);

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
/// Метод формирует массив высчитывая сумму элементов в каждой строке двумерного массива
/// </summary>
/// <param name="matrix">В качестве параметра используется двумерный массив</param>
/// <returns>Массив сумм элементов в каждой строке</returns>
int[] SumNumberInRow(int[,] matrix)
{
    int countRows = matrix.GetLength(0);
    int countColumns = matrix.GetLength(1);

    int[] array = new int[countRows];
    int sum = 0;
    for (int i = 0; i < countRows; i++)
    {
        sum = 0;
        for (int j = 0; j < countColumns; j++)
        {
            sum = sum + matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}

/// <summary>
/// Метод печатает массив в котором в качестве элементов содержаться суммы элементов по строкам двумерного массива.
/// </summary>
/// <param name="array">Массив сумм</param>
void PrintArraySum(int[] array)
{
    int size = array.Length;
    Console.WriteLine("Сумма элементов по строкам равна:");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{i + 1}. {array[i]} \n");
    }
}

/// <summary>
/// Метод проводит анализ сумм элементов массива и выводит в консоль номер строки с минимальной суммой элементов.
/// </summary>
/// <param name="array">В качестве параметра массив</param>
void PrintRowMinSum(int[] array)
{
    int numberRowMinValue = 0;
    int minNumber = array[0];
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        if (minNumber > array[i])
        {
            minNumber=array[i];
            numberRowMinValue = i;
        }
    }
    Console.Write($"Строка № {numberRowMinValue+1} имеет минимальную сумму элементов!");
}