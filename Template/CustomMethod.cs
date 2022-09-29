namespace Template;

public class CustomMethod
{
    public static string GetName()
    {
        Console.Write("Please enter your name: ");
        var name = Console.ReadLine();
        while (string.IsNullOrEmpty(name))
        {
            Console.Write("Please enter a valid name: ");
            name = Console.ReadLine();
        }

        return name;
    }
 
    public static int ParseStringToInt(string? inputText)
    {
        var loop = true;
        var result = 0;
        while (loop)
        {
            var tryParse = int.TryParse(inputText, out result);
            if (string.IsNullOrEmpty(inputText) | !tryParse)
            {
                Console.Write("please enter a valid number: ");
                inputText = Console.ReadLine();
            }
            else
            {
                loop = false;
            }
        }

        return result;
    }
    public static double ParseStringToDouble(string? inputText)
    {
        var loop = true;
        var result = 0.0;
        while (loop)
        {
            var tryParse = double.TryParse(inputText, out result);
            if (string.IsNullOrEmpty(inputText) | !tryParse)
            {
                Console.Write("please enter a valid value: ");
                inputText = Console.ReadLine();
            }
            else
            {
                loop = false;
            }
        }
        return result;
    }
}