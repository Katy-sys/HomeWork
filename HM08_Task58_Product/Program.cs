// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(10);
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j],3} ");
//         }
//        System.Console.WriteLine();      
//     }
// }

// int[, ] Prodact(int[,] arrA, int[,] arrB, int[,] arrRes)
// {
//     for (int i = 0; i < arrA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrB.GetLength(1); j++)
//         {
//             arrRes[i, j] = 0;
//             for (int m = 0; m < arrB.GetLength(0); m++)
//             {
//                 arrRes[i, j] = arrRes[i, j] + arrA[i,m]*arrB[m,j];
//             }
//         }
//     }
//     return arrRes;
// }



// System.Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] arrayA = new int[rows, columns];
// int[,] arrayB = new int[columns, rows];
// int[,] arrayRes = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
// FillArray(arrayA);
// PrintArray(arrayA);
// System.Console.WriteLine();
// FillArray(arrayB);
// PrintArray(arrayB);
// System.Console.WriteLine();

// PrintArray(Prodact(arrayA, arrayB, arrayRes));


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

int[, ] Prodact(int[,] arrA, int[,] arrB, int[,] arrRes)
{
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            arrRes[i, j] = 0;
            for (int m = 0; m < arrB.GetLength(0); m++)
            {
                arrRes[i, j] = arrRes[i, j] + arrA[i,m]*arrB[m,j];
            }
        }
    }
    return arrRes;
}

Console.Clear();
System.Console.Write("Введите количество строк матрицы A: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов матрицы A: ");
int columnsA = Convert.ToInt32(Console.ReadLine());
int[,] arrayA = new int[rowsA, columnsA];

System.Console.Write("Введите количество строк матрицы B: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов матрицы B: ");
int columnsB = Convert.ToInt32(Console.ReadLine());
int[,] arrayB = new int[rowsB, columnsB];

if (columnsA != rowsB)
    System.Console.WriteLine("Умножение не возможно. Kоличество столбцов матрицы A не равно количеству строк матрицы B.");
else
{ 
    int[,] arrayRes = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    FillArray(arrayA);
    PrintArray(arrayA);
    System.Console.WriteLine();
    FillArray(arrayB);
    PrintArray(arrayB);
    System.Console.WriteLine();
    PrintArray(Prodact(arrayA, arrayB, arrayRes));
}
