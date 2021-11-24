using System;

namespace ArithmaticExpressionValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";

            validationClass obj = new validationClass();
            if (obj.isValidExpression(expression))
            {
                Console.WriteLine("the expression is valid");
            }
            else
            {
                Console.WriteLine("the expression is not valid");
            }
        }
        
    }
}
