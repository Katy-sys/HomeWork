
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет. Через строку решать нельзя.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Lenght(double nn) // метод определения количества цифр числа
{
    int result = 0;
    int numberOInPas = (int)nn;
    while (numberOInPas > 0)
    {
        result++;
        numberOInPas = numberOInPas / 10;
    }
    return result;
}

void FillArray(int num, int[] collection) //функция, которая заполнит массив цифрами числа
{
    int lenght = collection.Length;
    int index = lenght - 1;
    while (index >= 0)
    {
        collection[index] = num % 10;
        num = (int)(num/10);
        index--;
    }
}

void PrintArray(int[] col) // функция, которая выведет массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

void ThirdDigitOutput (int [] collect)
{
    int lenght = collect.Length;
    if (lenght < 3) Console.WriteLine($"\nТретьей цифры нет");
    else Console.WriteLine($"\nТретья цифра заданного числа = {collect[2]}"); // \n для вывода сообщения с новой строки
}

System.Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int lenghtNumber = Lenght(number); //определяем длину массива
System.Console.WriteLine(lenghtNumber); //печатаем длину массива
int[] array = new int[lenghtNumber];//определяем массив
FillArray(number, array); // заполняем массив
PrintArray(array); // печатаем массив
ThirdDigitOutput(array); // выводим результат