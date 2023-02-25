// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

Console.WriteLine("Добро пожаловать! Программа самостоятельно генерирует массив из N элемнтов и выводит их на экран.");
Console.Write("Ввидите желаемое количество элементов: ");
string firstText = Console.ReadLine();
int size = int.Parse(firstText);
if (size < 1)
{
    Console.Write("Вы ввели некорректное значение. Повторите попытку");
    return;
}
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1000);
}
Console.Write($"Вы задали размер массива ({size}) \n Программа сгенерировала следующий массив: [{String.Join(",", array)}");

// for (int j = 0; j < size; j++)
// {
//     Console.Write(array[j]+"\t");
// }