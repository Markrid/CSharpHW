// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите число стартовое число M: ");
int start = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число конечное число N: ");
int end = Convert.ToInt32(Console.ReadLine());


Console.Write($"Итоговая последовательность равна: [{GetNumbers(start, end)}]");

string GetNumbers(int start, int end)
{
    if (start > end) return "Вы ввели неверные параметры!";
    if (start == end) return end.ToString();
    return (start + ", " + (GetNumbers(start + 1, end)));
}