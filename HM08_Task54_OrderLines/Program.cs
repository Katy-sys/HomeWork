// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void IsSorted(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j+1 < arr.GetLength(1); j++)
        {
            for (int k = 0; k+1 < arr.GetLength(1)-j; k++)
            {
                if (arr[i,k] < arr[i,k + 1])
                {
                    // int temp = arr[i,k];
                    // arr[i,k]=arr[i,k + 1];
                    // arr[i,k + 1] = temp;
                    (arr[0,j], arr[arr.GetLength(0)-1, j]) = (arr[arr.GetLength(0)-1, j], arr[0,j]); 
                }
            }
        }
    }
}

Console.Clear();
System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
IsSorted(array); 
PrintArray(array);




