using Calculator.Domain.Intefaces;
using System.Numerics;

namespace Calculator.Application.Services
{
    public class CalculatorService
    {
        private readonly ICalculatorRepository _calculatorRepository;

        public CalculatorService(ICalculatorRepository calculatorRepository)
        {
            _calculatorRepository = calculatorRepository;
        }

        public double Add(double number1, double number2) => 
            _calculatorRepository.Add(number1, number2);
        public double Substract(double number1, double number2) =>
            _calculatorRepository.Substract(number1, number2);
        public double Multiply(double number1, double number2) =>
            _calculatorRepository.Multiply(number1, number2);
        public double Divide(double number1, double number2) =>
            _calculatorRepository.Divide(number1, number2);
        public BigInteger Factorial(int number1) =>
            _calculatorRepository.Factorial(number1);
    }
}
