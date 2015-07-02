using System;

namespace FinalTest.operations
{
    public class Multiplication : IOperation
    {
        public Boolean PeutCalculer(string p0)
        {
            if (!p0.Contains("*"))
            {
                return false;
            }
            else
            {
                if (!p0.Contains("+") && !p0.Contains("-") && !p0.Contains("/"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int Calculer(string s)
        {
            int a = s.IndexOf("*");

            int firstNumber = Convert.ToInt32(s.Substring(0, a));
            int secondNumber = Convert.ToInt32(s.Substring(a + 1));

            return firstNumber * secondNumber;
        }
    }
}
