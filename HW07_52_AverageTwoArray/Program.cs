// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




void FillArray(int[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
        for (int j =0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-10,10);
}

void PrintArray(int[,] array)
{
    for (int i =0; i<array.GetLength(0); i++)
        {
        for (int j =0; j<array.GetLength(1); j++)
            Console.Write($"{array[i,j],5}   ");
        System.Console.WriteLine();
        }
}

int SumColumn (int[,] array, int cols)
{
    int j = cols;
    int sum = 0;
    for (int i =0;i<array.GetLength(0);i++)
        sum = sum + array[i,j];         
    return sum;
}


void AverageColumn (int[,] array)
{
    for (int j =0; j<array.GetLength(1); j++)
    {
        double average = Convert.ToDouble(SumColumn(array, j)) / array.GetLength(0);
        System.Console.Write($"{string.Format("{0:N2}", average), 5}   ");
    }
    
}

Console.Clear();
System.Console.WriteLine("Введите количество строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов n:");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
System.Console.WriteLine(" ");
AverageColumn(array);