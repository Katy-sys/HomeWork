//Definition of even or odd number
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

bool DefEvenOrOdd (int x)
{
    if (x % 2 == 0)
    {
        return true; 
    }
    
    else
    {
        return false;
    }
}

//Console.Clear();

Console.WriteLine("Enter the number");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("The number is even. - It's ");
string defnum = Convert.ToString(DefEvenOrOdd(x));
Console.Write(defnum);


