using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTest.operations;

namespace FinalTest
{
    public class Calculatrice
    {
        private readonly IOperation[] _operations;

        public Calculatrice(IOperation[] operations)
        {
            _operations = operations;
        }

        public int Calculer(string p0)
        {
            if (_operations != null)
            {
                foreach (var operation in _operations)
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
