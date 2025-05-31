
using static System.Runtime.InteropServices.JavaScript.JSType;

public class BasicCalculator
{
    static int a,b;
    static int result;
    static string error = "";
    public static void Main()
    {
        Console.WriteLine("Introduce your first number");
        a=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce your second number");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What do you want to do?");

        switch (Console.ReadLine())
        {
            case ("+"):
                result = a + b;
                break;
            case ("-"):
                result = a - b;
                break;
            case ("*"):
                result = a * b;
                break;
            case ("/"):
                if (b == 0) error = "Error: Division by zero";
                else result = a / b;
                break;
            default: error = "Invalid operation"; break;

        }
        if (error != "") Console.WriteLine(error);
        else Console.WriteLine($"Result: {result}");
        
    }
}
