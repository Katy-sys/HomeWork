// Takes an integer as input and outputs the third digit from the left
//
// Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу,
// которая принимает на вход целое число любой разрядности и на выходе 
// показывает третью цифру слева этого числа или говорит, что такой 
// цифры нет. Через строку решать нельзя.
//
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

Console.WriteLine("Enter integer");
int number = Convert.ToInt32(Console.ReadLine());

int IntegerPartNumber = number / 100;

if  (IntegerPartNumber > 0)
{
    string numberSt = Convert.ToString(number);
    System.Console.WriteLine(numberSt.Substring(2, 1));
}

else 
{
    Console.WriteLine("The number is less than three digits");
}


