// Which number is the greater and the lesser of the two
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int  ChoosingMoreOfTwo (int a, int b)
{
    if (a > b) 
    {
        return a;
    }
    else
    {
        return b;
    }
}

Console.Clear();

Console.WriteLine("Enter the first number");
int a =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("max = ");
Console.WriteLine(ChoosingMoreOfTwo(a, b));
