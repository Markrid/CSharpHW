// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Вычислим пересекаются ли прямые по заданным вами координатам!");

double Input(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double k1 = Input("Введите к1: ");
double k2 = Input("Введите к2: ");
double b1 = Input("Введите b1: ");
double b2 = Input("Введите b2: ");

if (k1 == b1 && b2 == k2)
{
    Console.Write("Прямые совпадают!");
    return;
}
else if (k1 == b1)
{
    Console.Write("Прямые параллельны!");
    return;
}
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"Точка пересечения прямых имеет координаты: [{x},{y}]");