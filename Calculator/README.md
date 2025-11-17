# Basic Calculator

A simple command-line calculator application written in C# that performs basic arithmetic operations.

## Features

- Addition (+)
- Subtraction (-)
- Multiplication (*)
- Division (/)
- Error handling for division by zero
- Input validation for numbers and operators
- Interactive command-line interface

## Prerequisites

- .NET SDK 10.0 or higher

To check if you have .NET installed, run:
```bash
dotnet --version
```

## Building the Application

Navigate to the Calculator directory and build the project:

```bash
cd Calculator
dotnet build
```

## Running the Application

To run the calculator, use the following command:

```bash
dotnet run
```

## How to Use

1. When the calculator starts, you'll see the welcome message: `=== Basic Calculator ===`

2. Enter the first number when prompted

3. Enter an operator (+, -, *, or /)

4. Enter the second number when prompted

5. The calculator will display the result

6. You can continue performing calculations or type `exit` to quit

### Example Usage

```
=== Basic Calculator ===

Enter first number (or 'exit' to quit):
10
Enter operator (+, -, *, /):
+
Enter second number:
5
Result: 10 + 5 = 15

Enter first number (or 'exit' to quit):
20
Enter operator (+, -, *, /):
/
Enter second number:
4
Result: 20 / 4 = 5

Enter first number (or 'exit' to quit):
exit
Goodbye!
```

## Error Handling

The calculator handles various error scenarios:

- **Invalid numbers**: If you enter non-numeric input, the calculator will prompt you to try again
- **Invalid operators**: Only +, -, *, and / are accepted
- **Division by zero**: The calculator will display an error message and allow you to continue

## Supported Operations

| Operator | Operation      | Example  | Result |
|----------|----------------|----------|--------|
| +        | Addition       | 10 + 5   | 15     |
| -        | Subtraction    | 20 - 8   | 12     |
| *        | Multiplication | 6 * 7    | 42     |
| /        | Division       | 100 / 5  | 20     |

## Notes

- The calculator supports decimal numbers (e.g., 3.14, 2.5)
- Results are displayed as decimal numbers
- The calculator runs in a continuous loop until you type 'exit'
