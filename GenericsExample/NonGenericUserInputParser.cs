using System;

namespace GenericsExample;
public class NonGenericUserInputParser
{
    public string GetString(string property)
    {
        var isValid = false;
        var result = string.Empty;

        while (!isValid)
        {
            Console.WriteLine($"Enter {property}:");
            result = Console.ReadLine();
            isValid = !string.IsNullOrEmpty(result);

            if (!isValid)
                Console.WriteLine("value cannot be empty");

        }

        return result;
    }

    public decimal GetDecimal(string property)
    {
        var isValid = false;
        decimal result = 0;

        while (!isValid)
        {
            Console.WriteLine($"Enter {property}:");
            var input = Console.ReadLine();
            isValid = decimal.TryParse(input, out result);

            if (!isValid)
                Console.WriteLine("not a valid number");

        }

        return result;
    }

    public DateTime GetDateTime(string property)
    {
        var isValid = false;
        DateTime result = default;

        while (!isValid)
        {
            Console.WriteLine($"Enter {property}:");
            var input = Console.ReadLine();
            isValid = DateTime.TryParse(input, out result);

            if (!isValid)
                Console.WriteLine("not a valid date");
        }

        return result;
    }
    public string GetOptionalString(string property)
    {
        Console.WriteLine($"Enter {property}:");
        var input = Console.ReadLine();
        return input;
    }

    public decimal? GetOptionalDecimal(string property)
    {
        var isValid = false;
        decimal result = 0;

        while (!isValid)
        {
            Console.WriteLine($"Enter {property}:");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                return null;

            isValid = decimal.TryParse(input, out result);

            if (!isValid)
                Console.WriteLine("not a valid number");
        }

        return result;
    }


    public DateTime? GetOptionalDateTime(string property)
    {
        var isValid = false;
        DateTime result = default;

        while (!isValid)
        {
            Console.WriteLine($"Enter {property}:");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                return null;

            isValid = DateTime.TryParse(input, out result);

            if (!isValid)
                Console.WriteLine("not a valid date");
        }

        return result;
    }
}
