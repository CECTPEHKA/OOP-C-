using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.task3
{
    internal class Task3 : Program
    {
        public void StartTask()
        {
            Random random = new Random();
            //мый номер у группі 23
            int numm = 23;
            int size = 10 + numm;
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(1, 20);
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{numbers[i]}");
            }
            int max = numbers[0];
            int min = numbers[0];

            for (int i = 0; i < size; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"Max number is: {max}");
            Console.WriteLine($"Min number is: {min}");
            Console.ReadLine();
        }
    }
}