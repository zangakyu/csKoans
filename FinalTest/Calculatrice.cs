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
            Operations = operations;
            
        }

        public int Calculer(string p0)
        {
            if (Operations != null)
            {
                foreach (var operation in Operations)
                {
                    if (operation.PeutCalculer(p0))
                    {
                        return operation.Calculer(p0);
                    }
                }
            }
            return -1;
        }
    }
}
