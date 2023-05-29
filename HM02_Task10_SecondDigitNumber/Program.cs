// Second digit of the number

// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру
// этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Enter a three-digit number");
int n = Convert.ToInt32(Console.ReadLine());
int numberDigits = (int)Math.Log10(n) + 1;


int i=numberDigits-1;
int [] array = new int [numberDigits];
while (i >= 0)
{
    array[i] = n % 10;
    i--;
    n = (int)n/10;
}


Console.WriteLine(array[1]);


