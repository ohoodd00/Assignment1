// See https://aka.ms/new-console-template for more information
using System;

using System;

using System;

class SimpleCalculator
{
    static void Main()
    {
        // Input first number
        Console.WriteLine("Enter the first number: ");
        int FirstNum = int.Parse(Console.ReadLine());

        // Input second number
        Console.WriteLine("Enter the second number: ");
        int SecondNum = int.Parse(Console.ReadLine());

        // Input operation
        Console.Write("Choose an operation (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Perform calculation based on the operation
        int result = 0;
        bool validOperation = true;

        if (operation == '+')
        {
            result = FirstNum + SecondNum;
        }
        else if (operation == '-')
        {
            result = FirstNum - SecondNum;
        }
        else if (operation == '*')
        {
            result = FirstNum * SecondNum;
        }
        else if (operation == '/')
        {
            if (SecondNum != 0)
            {
                result = FirstNum / SecondNum;
            }
            else
            {
                Console.WriteLine("Error! Division by zero.");
                validOperation = false;
            }
        }
        else
        {
            Console.WriteLine("Invalid operation!");
            validOperation = false;
        }

        // Display result if the operation was valid
        if (validOperation)
        {
            Console.WriteLine($"Result: {FirstNum} {operation} {SecondNum} = {result}");
        }
    }
}