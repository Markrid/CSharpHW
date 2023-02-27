// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве

int[] GetArray(int size)
{
    int[] box = new int[size];
    for (int i = 0; i < size; i++)
    {
        box[i] = new Random().Next(10);
    }
    return box;
}

int[] NewArray(int[] array)
{
    int sizeArray = array.Length;
    int[] box = new int[sizeArray - (sizeArray / 2)];
    int size = box.Length;
    for (int i = 0; i < size; i++)
    {
        box[i] = array[i] * array[sizeArray - 1 - i];
    }
    return box;
}

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(size);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

int[] arrayResult = NewArray(array);

Console.WriteLine($"Новый массив: [ {String.Join("; ", arrayResult)} ]");