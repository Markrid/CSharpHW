// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива


double[] GetArray(int size)
{
    double[] box = new double[size];
    for (int i = 0; i < size; i++)
    {
        box[i] = Math.Round(new Random().NextDouble()*100, 2);
    }
    return box;
}

double MinNum (double[] array)
{
    double min=array[0];
    double size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i]<min) min=array[i];
    }
    return min;
}

double MaxNum (double[] array)
{
    double max=array[0];
    double size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i]>max) max=array[i];
    }
    return max;
}

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = GetArray(size);
double result = Math.Round(MaxNum(array)-MinNum(array), 2);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");
Console.WriteLine($"Разница между максимальным и минимального элементов равна: {result}");