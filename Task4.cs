using Pz1.TaskSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz1.TaskSystem.Tasks

{
    internal class Task4 :ITaskeable
    {
        public void StartTask()
        {
            Random random = new Random();

            Console.Write("Enter the last digit of your student number: ");
            int studentNumber = int.Parse(Console.ReadLine());

            int arrayLength = 10 + studentNumber;

            int[] X = new int[arrayLength];
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = random.Next(-20, 21);
            }

            Console.Write("Enter the number M: ");
            int M = int.Parse(Console.ReadLine());

            int[] Y = X.Where(n => Math.Abs(n) > M).ToArray();

            Console.WriteLine("Given number M: " + M);
            Console.WriteLine("Array X: " + string.Join(", ", X));
            Console.WriteLine("Array Y (elements with absolute value greater than M): " + string.Join(", ", Y));
        }

        public void StopTask()
        {
            Console.Clear();
        }
    }
}