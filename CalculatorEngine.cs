using System;

namespace DotnetCalc;

public class CalculatorEngine
{
    public double Calculate(double a, double b, string operation)
    {
        return operation switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => a / b,
            _ => throw new InvalidOperationException("Unsupported operation")
        };
    }
}