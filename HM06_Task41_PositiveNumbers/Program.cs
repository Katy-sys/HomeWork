// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Метод получения значения с консоли (для длинны массива)
int[] GetNumber (string message)
{
    System.Console.WriteLine(message);
    string[] line = Console.ReadLine().Split().ToArray()!;
    int[] lineInt = new int[line.Length];
    for (int i = 0; i < line.Length; i++)
    {
        lineInt[i] = Convert.ToInt32(line[i]);
    }

    return lineInt;
}

// Подсчет колличества чисел, которые больше нуля
int NumRes (int[] array)
{
    int result = 0;
    foreach (var item in array)
    {
        if (item > 0)
            result = result + 1;
    }
    return result;
}

int[] lenghtArray = GetNumber("Введите несколько чисел через пробел: ");
System.Console.WriteLine(NumRes(lenghtArray));



