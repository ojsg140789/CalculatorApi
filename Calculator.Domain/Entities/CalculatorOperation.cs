using System.ComponentModel.DataAnnotations;

namespace Calculator.Domain.Entities
{
    public class CalculatorOperation
    {
        [Required]
        public double Number1 { get; set; }
        [Required]
        public double Number2 { get; set; }
    }
}
