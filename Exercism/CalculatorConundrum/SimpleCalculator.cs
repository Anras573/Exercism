namespace Exercism.CalculatorConundrum;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        ArgumentNullException.ThrowIfNull(operation);
        
        if (string.IsNullOrWhiteSpace(operation))
            throw new ArgumentException("Value cannot be whitespace or empty.", nameof(operation));

        if (operation is "/" && (operand1 is 0 || operand2 is 0))
            return "Division by zero is not allowed.";
        
        return operation switch
        {
            "+" => $"{operand1} {operation} {operand2} = {SimpleOperation.Addition(operand1, operand2)}",
            "*" => $"{operand1} {operation} {operand2} = {SimpleOperation.Multiplication(operand1, operand2)}",
            "/" => $"{operand1} {operation} {operand2} = {SimpleOperation.Division(operand1, operand2)}",
            _ => throw new ArgumentOutOfRangeException($"Invalid operation: {operation}")
        };
    }
}