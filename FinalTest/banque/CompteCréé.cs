using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.banque
{
    public struct CompteCréé : IEvenementMetier
    {
        private string NuméroDeCompte { get; set; }
        private int AutorisationDeCrédit { get; set; }

        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit) : this()
        {
            NuméroDeCompte = numéroDeCompte;
            AutorisationDeCrédit = autorisationDeCrédit;
        }
    }
}
