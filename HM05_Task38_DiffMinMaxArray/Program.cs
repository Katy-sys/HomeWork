// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// Метод получения значения с консоли (для длинны массива)
int GetNumber (string message)
{
    System.Console.WriteLine(message);
    int result = int.Parse(System.Console.ReadLine()!);
    return result;
}

// Метод заполнения массива случайными числами
double[] RandomGenerateArray(int lenghtArray)
{
    double[] array = new double[lenghtArray];
    Random random = new Random();
    double n;
    for (int i = 0; i < lenghtArray; i++)
    {
        n = random.NextDouble()*10; // случайные числа от 0 до 10
        array[i] = Math.Round(n, 2); // округление до 2-го знака после зыпятой
    }
    return array;
}

// Метод форматированного вывода в консоль для массива
void PrintArray(double[] array)
{
    System.Console.Write("[ ");

    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.Write($"{array[^1]}");
    System.Console.WriteLine(" ]");
}

// Поиск минимаотного
double MinOfArray (double[] collection)
{
    double min = collection[0];
    foreach (var item in collection)
    {
        if (min > item)
            min = item;
    }
    return min;
}

// Поиск максимального
double MaxOfArray (double[] collection)
{
    double max = collection[0];
    foreach (var item in collection)
    {
        if (max < item)
            max = item;
    }
    return max;
}

// Разность между минимальным и максимальным числами массива
double DifferenceMinMaxArray (double min, double max)
{
    double dif = Math.Round(max - min, 2);
    return dif;
}

// Основная программа
int lenghtArray = GetNumber("Введите колличество значений в массиве: ");
double[] array = RandomGenerateArray(lenghtArray);
PrintArray(array);
System.Console.WriteLine(DifferenceMinMaxArray(MinOfArray(array), MaxOfArray(array)));
