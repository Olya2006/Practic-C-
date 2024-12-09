using System;

class Task2
{
    static void Main()
    {
        Console.Write("Add 3 sides: ");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if ((a + b <= c) || (a + c <= b) || (b + c <= a))
        {
            Console.WriteLine("This is no triangle!");
            return;
        }

        int Perimeter = a + b + C;
        Console.WriteLine($"Perimeter: {Perimeter}");

        double p = Perimeter / 2.0;
        double Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine($"Area: {Area}");

        if (a == b && b == c)
        {
            Console.WriteLine("This is an equilateral triangle!");
        }
        else if (a == b || b == c || a == c)
        {
            Console.WriteLine("This triangle is isosceles!");
        }
        else
        {
            Console.WriteLine("This is a scalene triangle!");
        }
    }
}