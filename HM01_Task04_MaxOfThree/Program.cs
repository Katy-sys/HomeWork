// Which number is greater out of three
// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int  ChoosingMoreOfTwo (int a, int b, int c)
{
    if (a > b && a > c) 
    {
        return a;
    }
    else if (b > c)
    {
        return b;
    }
    else
    {
        return c;
    }
}

Console.Clear();

Console.WriteLine("Enter the first number");
int a =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("max = ");
Console.WriteLine(ChoosingMoreOfTwo(a, b, c));
