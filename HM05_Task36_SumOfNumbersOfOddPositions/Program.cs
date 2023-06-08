// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Метод получения значения с консоли (для длинны массива)
int GetNumber (string message)
{
    System.Console.WriteLine(message);
    int result = int.Parse(System.Console.ReadLine()!);
    return result;
}

// Метод заполнения массива случайными числами
int[] RandomGenerateArray(int lenghtArray, int bottomValue, int topValue)
{
    int[] array = new int[lenghtArray];
    Random random = new Random();
    for (int i = 0; i < lenghtArray; i++)
    {
        array[i] = random.Next(bottomValue, topValue +1);
    }
    return array;
}

// Метод форматированного вывода в консоль для массива
void PrintArray(int[] array)
{
    System.Console.Write("[ ");

    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[^1]}");
    System.Console.WriteLine(" ]");
}

// Метод для подсчета суммы элементов, стоящих на нечётных позициях
int SumNumOfOddPositions (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}

// Основная программа
int lenghtArray = GetNumber("Введите колличество значений в массиве: ");
int bottomValue = GetNumber("Введите минимальное число для диапазона значений массива: ");
int topValue = GetNumber("Введите максимальное число для диапазона значений массива: ");

int[] array = RandomGenerateArray(lenghtArray, bottomValue, topValue);
PrintArray(array);
System.Console.WriteLine($"Сумма элементов на нечетных позициях = {SumNumOfOddPositions(array)}");





