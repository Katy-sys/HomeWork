// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Метод получения значения с консоли (для длинны массива)
double GetNumber (string message)
{
    System.Console.WriteLine(message);
    double result = double.Parse(System.Console.ReadLine()!);
    return result;
}

double CoordinateX (double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double CoordinateY (double k1, double b1, double x)
{
    double y = k1* x + b1;
    return y;
}



double k1 = GetNumber("Введите k1: ");
double b1 = GetNumber("Введите b1: ");
double k2 = GetNumber("Введите k2: ");
double b2 = GetNumber("Введите b2: ");


double x = CoordinateX(k1, b1, k2, b2);
double y = CoordinateY(k1, b1, x);
System.Console.WriteLine($"( x = {x}; y = {y} )");

