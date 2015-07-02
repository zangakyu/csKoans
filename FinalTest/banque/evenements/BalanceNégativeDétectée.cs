using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.banque.evenements
{
    public struct BalanceNégativeDétectée : IEvenementMetier
    {
        private readonly string _numéroDeCompte;
        private readonly Montant _montant1;
        private readonly DateTime _dateRetrait;

        public override string ToString()
        {
            return string.Format("NuméroDeCompte: {0}, Montant1: {1}, DateRetrait: {2}", _numéroDeCompte, _montant1, _dateRetrait);
        }

        public BalanceNégativeDétectée(string numéroDeCompte, Montant montant, DateTime dateRetrait) : this()
        {
            _numéroDeCompte = numéroDeCompte;
            _montant1 = montant;
            _dateRetrait = dateRetrait;
        }
    }
}
