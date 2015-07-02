using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.banque.evenements
{
    public struct DépotRéalisé : IEvenementMetier
    {
        private string _numéroDeCompte;
        public Montant MontantDepot { get; private set; }
        private DateTime _dateDepot;

        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot) : this()
        {
            _numéroDeCompte = numéroDeCompte;
            MontantDepot = montantDepot;
            _dateDepot = dateDepot;
        }
    }
}
