// Задача 64: Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int GetNumber (string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(System.Console.ReadLine());
    return result;
}

int OutputOfNumGap (int num)
{
    if (num == 1) return 0;
    System.Console.Write($"{num}, ");
    if (num == 2) System.Console.Write($"{num-1}");
    return OutputOfNumGap(num-1);
}

//Console.Clear();
int num = GetNumber("Задайте число N: ");
System.Console.WriteLine();
System.Console.Write("\"");
OutputOfNumGap(num);
System.Console.Write("\"");


 

