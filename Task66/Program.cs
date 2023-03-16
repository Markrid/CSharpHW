// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число стартовое число M: ");
int start = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число конечное число N: ");
int end = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма всех натуральных чисел в последовательности равна: {GetSum(start, end)}");

int GetSum(int start, int end)
{
    if (start == end) return end;
    return (start + GetSum(start + 1, end));
}