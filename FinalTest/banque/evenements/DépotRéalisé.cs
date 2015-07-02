using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.banque.evenements
{
    public struct DépotRéalisé : IEvenementMetier
    {
        public string NuméroDeCompte { get; set; }
        public Montant MontantDepot { get; set; }
        public DateTime DateDepot { get; set; }

        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot) : this()
        {
            NuméroDeCompte = numéroDeCompte;
            MontantDepot = montantDepot;
            DateDepot = dateDepot;
        }
    }
}
