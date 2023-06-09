﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу,которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)  Math.Pow(x, stepen)

bool IsElementExistInArray (int[, , ] arr, int genNum)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {     
                if (arr[i, j, k] == genNum)
                {
                    return true;
                }
            }
        }    
    }
    return false;
      
}

void FillArray(int[, , ] arr, int size)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {             
                int genNum = new Random().Next(100);

                while (IsElementExistInArray(arr, genNum) == true)
                {
                    genNum = new Random().Next(100);
                }

                arr[i, j, k] = genNum;
                
            }
        }
    }
}

void PrintArray(int[, , ] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k],3} ({i},{j},{k})");
            }
        System.Console.WriteLine();      
        }
    }
}


int size = 2;
Console.Clear();
int[, , ] array = new int[size, size, size];
FillArray(array, size);
PrintArray(array);


