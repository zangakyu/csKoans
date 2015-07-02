using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class Multiplication
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
            int firstNumber = Convert.ToInt32(s.Substring(0, s.IndexOf("*", StringComparison.Ordinal)));
            int secondNumber = Convert.ToInt32(s.Substring(s.IndexOf("*", StringComparison.Ordinal)));

            return firstNumber*secondNumber;
        }
    }
}
