using ConsoleApp1.task1;
using ConsoleApp1.task2;
using ConsoleApp1.task3;
using ConsoleApp1.task4;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter task (1.2.3.4): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                
                Console.WriteLine("Connecting Task1...");
                Task1 task1 = new Task1();
                task1.StartTask();
            }
            else if (choice == "2")
            {
                
                Console.WriteLine("Connecting Task2...");
                Task2 task2 = new Task2();
                task2.StartTask();
            }
            else if (choice == "3")
            {

                Console.WriteLine("Connecting Task3...");
                Task3 task3 = new Task3();
                task3.StartTask();
            }
            else if (choice == "4")
            {

                Console.WriteLine("Connecting Task4...");
                Task4 task4 = new Task4();
                task4.StartTask();
            }
            else
            {
                Console.WriteLine("Invalid choise.");
            }
        }
    }
}