using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class TypeReference
    {
        private int Valeur { get; set; }

        public TypeReference(int i)
        {
            Valeur = i;
        }

        public override bool Equals(object obj)
        {
            if (((TypeReference) obj).Valeur == this.Valeur)
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
