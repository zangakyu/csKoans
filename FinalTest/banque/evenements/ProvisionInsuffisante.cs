using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.banque.evenements
{
    public class ProvisionInsuffisante : IEvenementMetier
    {
        public string NuméroDeCompte { get; private set; }
        public Montant MontantRetrait { get; private set; }
        public DateTime DateRetrait { get; private set; }

        public ProvisionInsuffisante(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            NuméroDeCompte = numéroDeCompte;
            MontantRetrait = montantRetrait;
            DateRetrait = dateRetrait;
        }
    }
}
