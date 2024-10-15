using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.task2
{
    internal class Task2 : Program

    {
        double[] arr = new double[3];
        public void InputNum()
        {

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter site of triangle {i + 1}: ");
                arr[i] = double.Parse(Console.ReadLine());
            }
        }

        public bool CheckIsCorrectTriangle()
        {
            return arr[0] + arr[1] > arr[2] && arr[1] + arr[2] > arr[0] && arr[0] + arr[2] > arr[1];
        }

        public double Perimetr()
        {
            return arr[0] + arr[1] + arr[2];
        }

        public double Square()
        {
            double p = Perimetr() / 2;
            return Math.Sqrt(p * (p - arr[0]) * (p - arr[1]) * (p - arr[2]));
        }
        public string TipOfTriangle()
        {
            if (arr[0] == arr[1] && arr[1] == arr[2])
            {
                return "Equilateral";
            }
            else if (arr[0] == arr[1] || arr[1] == arr[2] || arr[0] == arr[2])
            {
                return "Isosceles";
            }
            else
            {
                return "Versatile";
            }
        }
        public void Result()
        {
            if (!CheckIsCorrectTriangle())
            {
                Console.WriteLine("Invalid triangle.");
                return;
            }

            Console.WriteLine($"Sites of triangle: {arr[0]}, {arr[1]}, {arr[2]}");
            Console.WriteLine($"Perimetr of triangle: {Perimetr()}");
            Console.WriteLine($"Square of triangle: {Square()}");
            Console.WriteLine($"Tip of triangle: {TipOfTriangle()}");
            Console.ReadLine();
        }

        public void StartTask()
        {
            Task2 task2 = new Task2();
            task2.InputNum();
            task2.Result();
        }
    }
}