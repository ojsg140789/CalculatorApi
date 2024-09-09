using System.Numerics;

namespace Calculator.Domain.Intefaces
{
    public interface ICalculatorRepository
    {
        double Add(double number1, double number2);
        double Substract(double number1, double number2);
        double Multiply(double number1, double number2);
        double Divide(double number1, double number2);
        BigInteger Factorial(int number);
    }
}
