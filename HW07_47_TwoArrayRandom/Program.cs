// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void FillArray(double[,] array)
{   
    Random number = new Random();
    for (int i =0;i<array.GetLength(0);i++)
    for (int j =0;j<array.GetLength(1);j++)
        array[i,j] = number.NextDouble() * (10.00 + 9.99) - 9.99;
}

int Ost (double n)
{
    int whole = (int) n;
    double frac = n - whole;
    
    int m = (int)(frac*10);
    return m;
}

double FormatN (double n)
{
    double m = Math.Round(n, 1);
    return m;
}

void PrintArray(double[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
        {
        for (int j =0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],4}    ");
        System.Console.WriteLine();
        }
}

void PrintArrayFormat(double[,] array)
{
    double n;
    for (int i =0;i<array.GetLength(0);i++)
    {
        for (int j =0;j<array.GetLength(1);j++)
        { 
            n = FormatN(array[i,j]);
            if(n == 0)
                Console.Write($"{string.Format("{0:N0}", (int)n, 4)}   ");
            else if(Ost(n) == 0)
                Console.Write($"{string.Format("{0:N0}", n, 4)}   ");
            else
                Console.Write($"{string.Format("{0:N1}", n, 4)}   ");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
System.Console.WriteLine("Введите количество строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов n:");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [rows,cols];
FillArray(array);
PrintArray(array);
PrintArrayFormat(array);