using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class Calculatrice
    {

        private IOperation[] Operations { get; set; }

        public Calculatrice(IOperation[] operations)
        {

            if (operations != null)
            {
                foreach (var operation in operations)
                {
                    if (operation.GetType() == typeof(Multiplication)
                    {
                        
                    }
                }
            }
        }
    }
}
