// Задача 19

// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int AcceptMessageGiveResult (string message)
{
    System.Console.WriteLine(message);
    int res = Convert.ToInt32(System.Console.ReadLine());
    return res;
}

bool FiveDigitTest(int n)
{
    if (n > 9999 && n < 100000) 
        return true;
    else
        return false;
}

bool PolyndromOrNot (int n)
{
    if (n % 10 == n/10000) 
    {
        n = n / 10;
        n = n % 1000;
        if (n % 10 == n/100)
            return true;
    }
    return false; 
}

int number = AcceptMessageGiveResult("Введите пятизначное число");
if (FiveDigitTest(number) == true)
{
    if (PolyndromOrNot(number))
        System.Console.WriteLine("Это число является полиндромом");
    else
        System.Console.WriteLine("Это число не является полиндромом");
}
else 
    System.Console.WriteLine("Введено не пятизначное число");