using Calculator.Domain.Intefaces;
using System.Numerics;

namespace Calculator.Infrastructure.Repositories
{
    public class CalculatorRepository : ICalculatorRepository
    {
        public double Add(double number1, double number2) => number1 + number2;
        public double Substract(double number1, double number2) => number1 - number2;
        public double Multiply(double number1, double number2) => number1 * number2;
        public double Divide(double number1, double number2)
        {
            if (number2 == 0)
                throw new ArgumentException("No se puede dividir entre 0");
            
            return number1 / number2;
        }
        
        public BigInteger Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("El factorial esta definido para numeros positivos");

            if (number > 170)
                throw new ArgumentException("El factorial no esta definido para numeros mayores a 170.");

            if (number == 0) return 1;
            BigInteger result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }   
}