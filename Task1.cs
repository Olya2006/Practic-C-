using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task1
    {
        static void Main()
        {
            Console.Write("Введіть останню цифру порядкового номеру: ");
            int groupNumberLastDigit = int.Parse(Console.ReadLine());
            int upperBound = 10 + groupNumberLastDigit;

            Console.WriteLine($"Введіть три числа, які будуть перевірятися на належність інтервалу [1, {upperBound}]");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Числа, що належать інтервалу [1, {upperBound}]:");

            if (num1 >= 1 && num1 <= upperBound)
            {
                Console.WriteLine(num1);
            }

            if (num2 >= 1 && num2 <= upperBound)
            {
                Console.WriteLine(num2);
            }

            if (num3 >= 1 && num3 <= upperBound)
            {
                Console.WriteLine(num3);
            }
        }
    }

