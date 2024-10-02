using System;

class Triangle
{
    static void Main(string[] args)
    {
        // Введення сторін трикутника
        double a = InputSide("A");
        double b = InputSide("B");
        double c = InputSide("C");

        // Перевірка на можливість існування трикутника
        if (!IsValidTriangle(a, b, c))
        {
            Console.WriteLine("Помилка: трикутник з такими сторонами не може існувати.");
            return;
        }

        // Обчислення периметра і площі
        double perimeter = CalculatePerimeter(a, b, c);
        double area = CalculateArea(a, b, c, perimeter);

        // Виведення результатів
        Console.WriteLine($"Периметр трикутника: {perimeter}");
        Console.WriteLine($"Площа трикутника: {area}");

        // Визначення і виведення типу трикутника
        string triangleType = GetTriangleType(a, b, c);
        Console.WriteLine($"Трикутник є: {triangleType}");
    }

    // Метод для введення сторони
    static double InputSide(string sideName)
    {
        double side;
        Console.WriteLine($"Введіть довжину сторони {sideName}:");
        while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
        {
            Console.WriteLine("Помилка: введене значення повинно бути додатним числом. Спробуйте ще раз.");
        }
        return side;
    }

    // Метод перевірки дійсності трикутника
    static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    // Метод для обчислення периметра
    static double CalculatePerimeter(double a, double b, double c)
    {
        return a + b + c;
    }

    // Метод для обчислення площі за формулою Герона
    static double CalculateArea(double a, double b, double c, double perimeter)
    {
        double s = perimeter / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    // Метод для визначення типу трикутника
    static string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "рівносторонній";
        }
        else if (a == b || b == c || a == c)
        {
            return "рівнобедрений";
        }
        else
        {
            return "різносторонній";
        }
    }
}
