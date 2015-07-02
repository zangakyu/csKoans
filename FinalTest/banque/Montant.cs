using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.banque
{
 
    public class Montant
    { 
        public int Montant1 { get; set; }

        public Montant(int montant)
        {
            Montant1 = montant;
        }

        public override string ToString()
        {
            return string.Format("Montant1: {0}", Montant1);
        }

        public override bool Equals(object obj)
        {
            if (((Montant) obj).Montant1 == Montant1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
