// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int size)
{
    int[] box = new int[size];
    for (int i = 0; i < size; i++)
    {
        box[i] = new Random().Next(-10,10);
    }
    return box;
}

int SumUneven (int[] array)
{
    int count=0;
    int size = array.Length;
    for (int i = 1; i < size; i+=2)
    {
        count=count+array[i];
    }
    return count;
}

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(size);
Console.WriteLine($"Массив: [ {String.Join(",", array)} ]");
Console.Write("Cумма всех элементом, стоящих на нечётных позоциях равна: " + SumUneven(array));