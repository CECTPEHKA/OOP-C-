using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.task4
{
    internal class Task4 : Program 
    {
        public void StartTask()
        {
            Random random = new Random();
            //мій номер у группі 23
            int numm = 23;
            int size = 10 + numm;

            int[] arrray = new int[size];

            for (int i = 0; i < size; i++)
            {
                arrray[i] = random.Next(-50, 50);
            }

            Console.WriteLine("Array is:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{arrray[i]}");
            }

            int[] X = new int[size];

            Console.WriteLine("Enter (full) number: ");
            int M = Convert.ToInt32(Console.ReadLine());
            int newSize = 0;

            for (int i = 0; i < size; i++)
            {
                if (Math.Abs(arrray[i]) > Math.Abs(M))
                {
                    X[newSize] = arrray[i];
                    newSize++;
                }
            }

            Console.WriteLine("new Array X:");
            for (int i = 0; i < newSize; i++)
            {
                Console.WriteLine(X[i]);
            }
            Console.ReadLine();
        }
    }
}