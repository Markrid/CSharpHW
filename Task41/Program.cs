// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Укажите объём элементов для проверки: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива а{i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Итоговый массив: [{String.Join("; ", array)}]");

for (int i = 0; i < size; i++)
{
    if (array[i] > 0) count++;
}
Console.WriteLine($"Пользователь ввел {count} положительных числа");