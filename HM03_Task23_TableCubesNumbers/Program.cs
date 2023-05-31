// Задача 23

// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = AcceptMessageGiveResult("Введите целое число");

int AcceptMessageGiveResult (string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.WriteLine("|\tX\t|\tX3\t|");
Console.WriteLine("---------------------------------");

for (int j=1; j<=number; j++)
    Console.WriteLine($"|\t{j}\t|\t{Math.Pow(j, 3)}\t|");

Console.WriteLine("---------------------------------");

