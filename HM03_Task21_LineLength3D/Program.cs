// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координаты (x y z) для точки A через пробел");
string[] arrayA = Console.ReadLine()!.Split();

System.Console.WriteLine("Введите координаты (x y z) для точки B через пробел");
string[] arrayB = Console.ReadLine()!.Split()!;

double DistanceCalculation3D (string [] collectA, string [] collectB)
{
    double ax = Convert.ToDouble(collectA[0]);
    double ay = Convert.ToDouble(collectA[1]);
    double az = Convert.ToDouble(collectA[2]);
    double bx = Convert.ToDouble(collectB[0]);
    double by = Convert.ToDouble(collectB[1]);
    double bz = Convert.ToDouble(collectB[2]);

    double res = 0.00;

    return res = Math.Sqrt((Math.Pow((bx-ax), 2)) + (Math.Pow((by-ay), 2)) + (Math.Pow((bz-az), 2)));
 
}

System.Console.WriteLine($"Расстояние между двумя точками в 3D пространстве = {Math.Round(DistanceCalculation3D(arrayA, arrayB), 2)}");