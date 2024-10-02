using System;

class Program
{
    static void Main()
    {
        // Введіть останню цифру порядкового номеру у списку групи
        Console.Write("Введіть останню цифру порядкового номеру у списку групи: ");
        string? input = Console.ReadLine();
        int numberInGroup = ParseInput(input);

        // Введіть три цілі числа
        Console.Write("Введіть перше ціле число: ");
        input = Console.ReadLine();
        int a = ParseInput(input);

        Console.Write("Введіть друге ціле число: ");
        input = Console.ReadLine();
        int b = ParseInput(input);

        Console.Write("Введіть третє ціле число: ");
        input = Console.ReadLine();
        int c = ParseInput(input);

        // Інтервал [1, 10 + №]
        int lowerBound = 1;
        int upperBound = 10 + numberInGroup;

        Console.WriteLine($"Числа, що належать інтервалу [{lowerBound}, {upperBound}]:");

        // Перевірка кожного числа на належність інтервалу
        if (a >= lowerBound && a <= upperBound)
        {
            Console.WriteLine(a);
        }

        if (b >= lowerBound && b <= upperBound)
        {
            Console.WriteLine(b);
        }

        if (c >= lowerBound && c <= upperBound)
        {
            Console.WriteLine(c);
        }
    }

    static int ParseInput(string? input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Введене значення є некоректним. Використовується значення за замовчуванням 0.");
            return 0;
        }

        return int.Parse(input);
    }
}
