// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB<=0) 
{
    Console.Write($"Вы ввели неверное число");
    return;
}
int result = 1;
for (int i = 1; i <= numberB; i++)
{
    result *= numberA;
}
Console.Write($"Число [{numberA}] в степени [{numberB}] = {result}");