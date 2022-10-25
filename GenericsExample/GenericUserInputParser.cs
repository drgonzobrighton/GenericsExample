using System;
using System.Globalization;

namespace GenericsExample;
public class GenericUserInputParser
{
    public T GetInput<T>(string property)
    {
        var isValid = false;
        T result = default;

        var isNullable = Nullable.GetUnderlyingType(typeof(T)) is not null;
        var prompt = $"Enter {property}";

        if (isNullable)
            prompt += " or press ENTER to skip";

        while (!isValid)
        {
            Console.WriteLine(prompt + ":");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) && isNullable)
                return result;

            try
            {
                var type = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);
                result = (T)Convert.ChangeType(input, type, CultureInfo.InvariantCulture);
                isValid = true;
            }
            catch (Exception)
            {
                Console.WriteLine($"Input is not valid, expected a {GetTypeName(result)}");
            }

        }

        return result;
    }

    private static string GetTypeName<T>(T o)
    {
        return o switch
        {
            int or double or long or float or decimal => "number",
            DateTime => "date",
            _ => o.GetType().Name
        };
    }
}
