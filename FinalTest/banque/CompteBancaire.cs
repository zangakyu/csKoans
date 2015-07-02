using System;
using System.Collections;
using System.Collections.Generic;
using FinalTest.banque.evenements;

namespace FinalTest.banque
{
    public class CompteBancaire
    {
        private string NuméroDeCompte;
        private Montant _provision = new Montant(0);

        public CompteBancaire(CompteCréé compteCréé)
        {
            NuméroDeCompte = compteCréé.NuméroDeCompte;
        }

        public CompteBancaire(params IEvenementMetier[] evenements)
        {
            foreach (var evenement in evenements)
            {
                if (evenement is CompteCréé)
                {
                    NuméroDeCompte = ((CompteCréé) evenement).NuméroDeCompte;
                }
                else if (evenement is DépotRéalisé)
                {
                    Provision.Montant1 = Provision.Montant1 + ((DépotRéalisé) evenement).MontantDepot.Montant1;
                }
            }
        }

        public Montant Provision
        {
            get { return _provision; }
            set { _provision = value; }
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
           yield return  new CompteCréé(numéroDeCompte,autorisationDeCrédit);
        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            yield return new DépotRéalisé(NuméroDeCompte,montantDepot,dateDepot);
        }

        public IEnumerable<IEvenementMetier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            if (montantRetrait.Montant1 <= Provision.Montant1)
            {
                yield return new RetraitRéalisé(NuméroDeCompte, montantRetrait, dateRetrait);
            }
            else
                yield return new ProvisionInsuffisante(NuméroDeCompte, montantRetrait, dateRetrait);
        }
    }
}
