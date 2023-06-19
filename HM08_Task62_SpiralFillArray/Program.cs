// Задача 62. Напишите программу, которая заполнит спирально массив N на N.
// N вводит с клавиатуры пользователь.
// Например, N=4 и на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillArray (int[,] array, int N)
{
    int n = 1;
    int shift = 0; 
    int i = 0;
    int j = 0;
    int size = N - 1;

    while (n <= N*N && (size - shift) > 0)
    {
        i = shift;
        for (j = shift; j < (size - shift); j++)
        {
            array[i, j] = n;
            n++;
            
        }
        j = size - shift;
        for (i = shift; i < size - shift; i++)
        {
            array[i, j] = n;
            n++;
            
        }
        i = size - shift;
        for (j = size - shift; j > shift; j--)
        {
            array[i, j] = n;
            n++;
        }
        j = shift;
        for (i = size - shift; i > shift; i--)
        {
            array[i, j] = n;
            n++;
        }     
        shift++;
    }

    if (N%2 != 0)
        array[size/2,size/2] = N*N;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3 :d2} ");
        }
       System.Console.WriteLine();      
    }
}

Console.Clear();
System.Console.Write("Введите количество строк или столбцов матрицы: N = ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] arrayN = new int[N, N];
FillArray(arrayN, N);
PrintArray(arrayN);

