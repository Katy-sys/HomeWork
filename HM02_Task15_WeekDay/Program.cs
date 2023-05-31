// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



string[] arrayDaysOfTheWeek = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};


void outputDayOffOrNot (int n, string[] array)
{
    int i = n-1;
    if (n <= 5)
        {System.Console.WriteLine($"Это {arrayDaysOfTheWeek[i]} - рабочий день");}
    else
        {System.Console.WriteLine($"Это {arrayDaysOfTheWeek[i]} - выходной день");}
}


System.Console.WriteLine("Введите номер дня недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

if (day <= 0 || day > 7)
    System.Console.WriteLine("Такого дня недели не существует");
else
    outputDayOffOrNot(day, arrayDaysOfTheWeek);


