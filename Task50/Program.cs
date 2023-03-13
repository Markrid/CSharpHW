// // Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что 
// такого элемента нет.

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

void ShowValue(int numberRow, int numberColumn, int[,] array)
{
    int value=0;
    value=array[numberRow, numberColumn];
    Console.Write($"Значение элемента по адресу [{numberRow+1}, {numberColumn+1}] равно: {value}.");
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

int numberRow;
int numberColumn;

Console.WriteLine("Программа генерирует случайный двумерный массив из натуральных чисел 5 на 5" + "\n" + "и показывает любой элемент по вашему запросу!");
Console.Write("Введите номер строки: ");
numberRow=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
numberColumn=Convert.ToInt32(Console.ReadLine());

int[,] matrix = GetMatrix(5, 5);
PrintMatrix(matrix);

if (numberRow-1>=0 && numberRow-1 < 5 && numberColumn-1>=0 && numberColumn-1 < 5 )
{
    ShowValue(numberRow-1, numberColumn-1, matrix);
}
else {
    Console.Write("Такой позиции в массиве не существует!");
}
