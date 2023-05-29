//Output even numbers from 1 to N.
// Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Enter number");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (n < 1)
{
    Console.WriteLine("Please enter a positive integer greater than one.");
}
else
{
    while ( i <= n )
    {
        if (i % 2 == 0)
        {
            Console.Write(i);
        }
        //else {} 
        i++;
    }
} 

