// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// void AcceptMessageGiveResult (string message, int n)        //принимаем, потом выводим сообщение
// {
//     System.Console.WriteLine(message);

//     int []array = new int[n];
//     for (int i = 0; i <(n-1); i++)
//         array[i]= Convert.ToInt32(Console.ReadLine());  //читаем и конвертируем введенное значение
// }

// AcceptMessageGiveResult("Введите числа элементов массива через {, }", 8);

void PrintArray(int[] array)
{
    var result = array.SkipLast(1);
    foreach (var item in result)
        Console.Write($" {item},");
    Console.Write($" {array[^1]}");
}

int AcceptArraySize()
{
    Console.WriteLine("Введите размер массива:");
    int len =  Convert.ToInt32(Console.ReadLine());
    return len;
}

int[] arr = new int[AcceptArraySize()];

Console.WriteLine("Введите порядок случайных чисел через (Пробел), в соответствие указанному размеру массива:");
string [] arrayNumber =  Console.ReadLine()!.Split(' ');
    
for (int i =0; i < arrayNumber.Length; i++)
{
    arr[i] = int.Parse(arrayNumber[i]);
}

Console.Write("[");
PrintArray(arr);
Console.WriteLine(" ]");




