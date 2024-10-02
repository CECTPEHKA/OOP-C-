using System;

class Triangle
{
    static void Main(string[] args)
    {
        double a, b, c;

        // Введення даних
        Console.WriteLine("Введіть довжини трьох сторін трикутника:");
        if (!double.TryParse(Console.ReadLine(), out a) || a <= 0 ||
            !double.TryParse(Console.ReadLine(), out b) || b <= 0 ||
            !double.TryParse(Console.ReadLine(), out c) || c <= 0)
        {
            Console.WriteLine("Помилка: введені дані повинні бути додатними числами.");
            return;
        }

        // Перевірка на можливість існування трикутника
        if (!IsValidTriangle(a, b, c))
        {
            Console.WriteLine("Помилка: трикутник з такими сторонами не може існувати.");
            return;
        }

        // Обчислення периметра
        double perimeter = a + b + c;
        Console.WriteLine($"Периметр трикутника: {perimeter}");

        // Обчислення площі за формулою Герона
        double s = perimeter / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        Console.WriteLine($"Площа трикутника: {area}");

        // Визначення типу трикутника за сторонами
        string triangleType = GetTriangleType(a, b, c);
        Console.WriteLine($"Трикутник є: {triangleType}");
    }

    // Функція перевірки дійсності трикутника
    static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    // Функція для визначення типу трикутника
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
