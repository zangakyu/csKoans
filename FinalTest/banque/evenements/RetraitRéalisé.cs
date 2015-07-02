using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.banque.evenements
{
    public struct RetraitRéalisé : IEvenementMetier
    {
        private readonly string _numéroDeCompte;
        private Montant MontantRetrait { get; set; }
        private readonly DateTime _dateRetrait;

        public override string ToString()
        {
            return string.Format("NuméroDeCompte: {0}, DateRetrait: {1}, MontantRetrait: {2}", _numéroDeCompte, _dateRetrait, MontantRetrait);
        }

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait) : this()
        {
            _numéroDeCompte = numéroDeCompte;
            MontantRetrait = montantRetrait;
            _dateRetrait = dateRetrait;
        }
    }
}
