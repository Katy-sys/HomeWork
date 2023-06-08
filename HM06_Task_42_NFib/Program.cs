// Задача НЕГАФИБОНАЧЧИ необязательная.

// Задайте число. Составьте массив чисел НегаФибоначчи, 
// в том числе для отрицательных индексов.

// Пример:

// для k = 9 массив будет выглядеть так:
// [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]


void PrintArray(int[] array) 
{ 
    foreach (var item in array) 
        Console.Write($"{item} "); 
    System.Console.WriteLine(); 
} 
 
void Fib(int[] array) 
{ 
    array[0] = 0; 
    array[1] = 1; 
    for (int i = 2; i < array.Length; i++) 
    { 
        array[i] = array[i - 1] + array[i - 2]; 
    } 
}

void NegFib(int[] array) 
{ 
    array[^1] = 1; 
    array[^2] = -1; 
    for (int i = array.Length - 3; i >= 0; i--) 
    { 
        array[i] = array[i + 2] - array[i + 1]; 
    } 
}

int[] Concatenate (int[] array, int[] arrayN)
{
    return arrayN.Concat(array).ToArray();
}
 
System.Console.WriteLine("Введите число "); 
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N]; 
Fib(array); 
PrintArray(array);

int[] arrayN = new int[N-1];
NegFib(arrayN);
PrintArray(arrayN);

PrintArray(Concatenate(array, arrayN));
