// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// m = 1, n = 2 -> A(m,n) = 4
// m = 0, n = 1 -> A(m,n) = 2
// m = 0, n = 0 -> A(m,n) = 1
// m = 2, n = 2 -> A(m,n) = 7

// функция Аккермана

ushort GetNumber (string message)
{
    System.Console.WriteLine(message);
    ushort result = Convert.ToUInt16(System.Console.ReadLine());
    return result;
}

int AckermanFunction(int numM, int numN)
{
  if (numM == 0)
  {
     return numN + 1;
  }
  else
  {
    if ((numM != 0) && (numN == 0))
        return AckermanFunction(numM - 1, 1);

    else
        return AckermanFunction(numM - 1, AckermanFunction(numM, numN - 1));
  }
}

//Console.Clear();
int numM = GetNumber("Задайте число M: ");
int numN = GetNumber("Задайте число N: ");

System.Console.WriteLine($"A({numM}, {numN}) = {AckermanFunction(numM, numN)}");
