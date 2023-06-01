// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int AcceptMessageGiveResult (string message)        //принимаем, потом выводим сообщение
{
    System.Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());  //читаем и конвертируем введенное значение
    return num;
}

int NumberOfDigits (int digit)                      //считаем колличество цифр в числе
{
    int numbers = 0;
    while (digit > 0)
    {
        digit = digit / 10;
        numbers++;
    }
    return numbers;
}

void FillArray (int n, int[] collection)            //заполняем созданный в основной программе массив
{
    int len = collection.Length;
    int index = len - 1;
    while (index >= 0)
    {
        collection[index] = n % 10;
        n = (int)(n / 10);
        index--;
    }
}

int SumOfDigitsInNumber (int[] array)               //считаем сумму чисел в массиве
{
    int len = array.Length;
    int sum = 0;
    for (int i = 0; i < len; i++)
        sum = sum + array[i];
    return sum;
}

int number = AcceptMessageGiveResult("Введите целое число"); //вводим данные
int len = NumberOfDigits(number);                            //определяем кол-во цифр в числе
int[] array = new int [len];                                 //создаем массив под нужное кол-во цифр
FillArray(number, array);                                    //заполняем массив
System.Console.WriteLine($"Сумма цифр в числе {number} = {SumOfDigitsInNumber(array)}"); //считаем сумму и выводим результат