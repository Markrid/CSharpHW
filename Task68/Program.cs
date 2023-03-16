// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write(UseAkkerman(1, 2));

int UseAkkerman(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
    {
        return secondNumber + 1;
    }
    else if (firstNumber != 0 && secondNumber == 0)
    {
        return UseAkkerman(firstNumber - 1, 1);
    }
    else
    {
        return UseAkkerman(firstNumber - 1, UseAkkerman(firstNumber, secondNumber - 1));
    }
}