using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.task1
{
    internal class Task1 : Program
    {
        public void StartTask()
        {
            //для введення будь-яких чисел
            int[] numbers = new int[3];
            //інший масив для виправлення чисел
            int[] arr = new int[3];
            //щоб масив arr мав правильну порядковість
            int index = 0;
            //мій номер у группі 23
            int num = 23;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                if (numbers[i] < (10 + num) && numbers[i] > 0)
                {
                    arr[index] = numbers[i];
                    index++;
                }
            }

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }

    }
}