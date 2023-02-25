// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetCountNumber(int number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
int count = GetCountNumber(number);
int result = 0;
while (count > 0)
{
    result = result + number % 10;
    number = number / 10;
    count--;
}

Console.Write($"Сумма цифр в числе равна: {result} ");