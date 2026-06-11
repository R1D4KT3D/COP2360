using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine() ?? "";

        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine() ?? "";

        Divide(input1, input2);
    }

    static void Divide(string num1, string num2)
    {
        try
        {
            int a = Convert.ToInt32(num1);
            int b = Convert.ToInt32(num2);

            int result = a / b;

            Console.WriteLine($"Result: {a} / {b} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: One or both inputs are not valid integers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: One or both numbers are too large for an integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}