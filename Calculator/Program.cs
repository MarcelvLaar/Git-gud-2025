Console.WriteLine("=== SUPER COOL Calculator ===");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Enter first number (or 'exit' to quit):");
    string? input1 = Console.ReadLine();
    
    if (input1?.ToLower() == "exit")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    
    if (!double.TryParse(input1, out double num1))
    {
        Console.WriteLine("Invalid number. Please try again.");
        Console.WriteLine();
        continue;
    }
    
    Console.WriteLine("Enter operator (+, -, *, /):");
    string? operatorInput = Console.ReadLine();
    
    if (operatorInput != "+" && operatorInput != "-" && operatorInput != "*" && operatorInput != "/")
    {
        Console.WriteLine("Invalid operator. Please use +, -, *, or /");
        Console.WriteLine();
        continue;
    }
    
    Console.WriteLine("Enter second number:");
    string? input2 = Console.ReadLine();
    
    if (!double.TryParse(input2, out double num2))
    {
        Console.WriteLine("Invalid number. Please try again.");
        Console.WriteLine();
        continue;
    }
    
    double result = 0;
    bool validOperation = true;
    
    switch (operatorInput)
    {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "*":
            result = num1 * num2;
            break;
        case "/":
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
                validOperation = false;
            }
            else
            {
                result = num1 / num2;
            }
            break;
    }
    
    if (validOperation)
    {
        Console.WriteLine($"Result: {num1} {operatorInput} {num2} = {result}");
    }
    
    Console.WriteLine();
}
