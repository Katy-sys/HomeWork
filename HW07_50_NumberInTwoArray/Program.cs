// Задача 50. Напишите программу, которая на вход принимает
// значение элемента в двумерном массиве, и возвращает позицию
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


void FillArray(int[,] array)
{
    Random number = new Random();
    for (int i =0;i<array.GetLength(0);i++)
        for (int j =0;j<array.GetLength(1);j++)
            array[i,j] = number.Next(10);
}

void PrintArray(int[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
        {
        for (int j =0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],1}    ");
        System.Console.WriteLine();
        }
}

int NumQuantity (int[,] array, int number)
{
    int n = 0;
    for (int i =0; i<array.GetLength(0); i++)
        for (int j =0; j<array.GetLength(1); j++)
            if (array[i,j] == number)
                n++;
    return n;        
}

void NumSearchPosition (int[,] array, int number, int quantity)
{
    int[,] arrayRes = new int [quantity,2];
    int n = 0;
    for (int i =0; i<array.GetLength(0); i++)
        for (int j =0; j<array.GetLength(1); j++)
            if (array[i,j] == number)
            {   
                arrayRes[n,0] = i;
                arrayRes[n,1] = j;
                n++;
            }
    PrintArray(arrayRes);  
}

Console.Clear();
System.Console.WriteLine("Введите количество строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов n:");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine("Введите число для поиска ");
int numSearch = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("");
int numQ = NumQuantity(array, numSearch);
if (numQ == 0)
    Console.WriteLine($"Число {numSearch} не найдено");

else
    NumSearchPosition(array, numSearch, numQ);
