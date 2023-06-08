// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Метод получения значения с консоли (для длинны массива)
int GetNumber (string message)
{
    System.Console.WriteLine(message);
    int result = int.Parse(System.Console.ReadLine()!);
    return result;
}

// Метод получения нижнего значения диапозона чисел
int BottomNumber(int charactersNumber)
{
    int bottomValue;
    if (charactersNumber < 2)
        bottomValue = 0;
    else
        bottomValue = Convert.ToInt32(Math.Pow(10, charactersNumber-1));

    System.Console.WriteLine($"Нижняя граница значений= {bottomValue}");
    return bottomValue;   
}

// Метод получения верхнего значения диапозона чисел
int TopNumber(int charactersNumber)
{
    int topValue;
    if (charactersNumber < 2)
        topValue = 9;
    else
        topValue = Convert.ToInt32(Math.Pow(10, charactersNumber) - 1);
        
    System.Console.WriteLine($"Верхняя граница значений = {topValue}");
    return topValue;   
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

// Метод определения кол-ва чисел в массиве, которые делятся на заданное число
int ArrayDiv(int[] array, int div)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        double remainder = array[i] % div;
        if (remainder == 0.00)
        {
            result = result + 1;
        }
    }
    return result;
}

// Метод для логичного вывода строковой переменной
string StringNumber (int num)
{
    string result;

    if (num == 0 || num >=5)
        result = "чисел";
    else if (num == 1)
        result = "число";
    else 
        result = "числа";

    return result;
}

// Основная программа
int lenghtArray = GetNumber("Введите колличество значений в массиве: ");
int num = GetNumber("Введите порядок знаков в числах: ");
int[] array = RandomGenerateArray(lenghtArray, BottomNumber(num), TopNumber(num));
int div = GetNumber("Введите число на которое должны делиться числа массива: ");
System.Console.WriteLine("");
PrintArray(array);
System.Console.WriteLine("");
System.Console.WriteLine($"В массиве делятся на {div} ____ {ArrayDiv(array, div)} {StringNumber(ArrayDiv(array, div))}"!);


