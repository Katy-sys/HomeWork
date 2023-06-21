// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber (string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(System.Console.ReadLine());
    return result;
}

int SumNumInInterval(int numStart, int numFin)
{
    if (numStart > numFin) return 0;
    return numStart + SumNumInInterval(numStart+1, numFin);
}

//Console.Clear();
int numM = GetNumber("Задайте число M: ");
int numN = GetNumber("Задайте число N: ");

if (numM > numN)
    (numM, numN) = (numN, numM);

System.Console.WriteLine(SumNumInInterval(numM, numN));

