// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3} ");
        }
       System.Console.WriteLine();      
    }
}

int SumLine (int[,] arr, int i)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
        sum = sum + arr[i,j];
    System.Console.WriteLine(sum);
    return sum;
}

int NumLineMinSum (int[,] arr)
{
    int minSum = SumLine(arr, 0);
    int nextSum = 1;
    int line = 1;
    for (int i = 0; i < arr.GetLength(0)-1; i++)
    {
        nextSum = SumLine(arr, i+1);
        if (minSum > nextSum)
            {
                minSum = nextSum;
                line = i+2;
            }
    }
    return line;
}

Console.Clear();
System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
System.Console.WriteLine($"Наименьшая сумма элементов: {NumLineMinSum(array)} строка");

// Первое решение
// int NumLineMinSum (int[,] arr)
// {
//     int minSum = SumLine(arr, 0);
//     int line = 1;
//     for (int i = 0; i < arr.GetLength(0)-1; i++)
//     {
//         if (minSum > SumLine (arr, i+1))
//         {
//             minSum = SumLine (arr, i+1);
//             line = i+2;
//         }
//         else if (minSum == SumLine (arr, i+1))
//         {
//             System.Console.WriteLine("Строк с наименьшей суммой > 1 ");
//             System.Console.WriteLine("(в ответе будет указан номер первой");
//             System.Console.WriteLine("найденной строки с минимальной суммой)");
//             System.Console.WriteLine();
//         }
//     }
//     return line;
// }
