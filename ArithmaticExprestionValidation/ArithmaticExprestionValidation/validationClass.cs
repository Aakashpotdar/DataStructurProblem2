using System;
using System.Collections.Generic;
using System.Text;

namespace ArithmaticExpressionValidation
{
    public class validationClass
    {
        public static bool isAnOperator(char c)
        {
            return (c == '*' || c == '/' || c == '+' || c == '-' || c == '%');
        }
        public bool isValidExpression(String expression)
        {
            expression = expression.Trim();
            
                char[] s = expression.ToCharArray();
            
            if (isAnOperator(s[0]) || isAnOperator(s[s.Length - 1]))
                    {
                return false;
            }
            int opning= 0;
            int closing = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (s[i] == '(')
                {
                    opning++;

                    if (i == expression.Length - 1) 
                    {
                        return false;
                    }
                    if (s[i + 1] == ')')
                    {
                        return false;
                    }
                }
                if (s[i] == ')')
                {
                    closing++;
                    if (i == 0) 
                    {
                        return false; 
                    }
                    if (opning<closing)
                    {
                        return false;
                    }
                }
                if (isAnOperator(s[i]))
                {
                    if (s[i - 1] == '(' || s[i + 1] == ')' || isAnOperator(s[i + 1]))
                    {
                        return false;
                    }
                }
            }
            return (opning==closing);
        }
    }
}
