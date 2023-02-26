// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] box = new int[size];
    for (int i = 0; i < size; i++)
    {
        box[i] = new Random().Next(minValue, maxValue + 1);
    }
    return box;
}

int CountPositive(int[] array)
{
    int count = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

int[] array = GetArray(100, 100, 1000);
Console.WriteLine($"Массив: [ {String.Join(",", array)} ]");
Console.Write("Колличество чётных чисел в массиве: " + CountPositive(array));