// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
// число A в натуральную степень B. Math.Pow юзать нельзя.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int AcceptMessageGiveResult (string message)
{
    System.Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int RaisesToNaturalPower (int number, int degree)
{
    int numberInSt = 1;
    for (int i=1; i<=degree; i++)
        numberInSt = numberInSt*number;
    return numberInSt;
}

int numberA = AcceptMessageGiveResult("Введите целое число A");
int numberB = AcceptMessageGiveResult("Введите целое число B");

System.Console.WriteLine(RaisesToNaturalPower(numberA, numberB));
    

