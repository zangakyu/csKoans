﻿using System;
using System.Collections;
using System.Collections.Generic;
using FinalTest.banque.evenements;

namespace FinalTest.banque
{
    public class CompteBancaire
    {
        private string _numéroDeCompte;
        private Montant _provision = new Montant(0);

        public CompteBancaire(CompteCréé compteCréé)
        {
            _numéroDeCompte = compteCréé.NuméroDeCompte;
        }

        public CompteBancaire(params IEvenementMetier[] evenements)
        {
            foreach (var evenement in evenements)
            {
                if (evenement is CompteCréé)
                {
                    _numéroDeCompte = ((CompteCréé) evenement).NuméroDeCompte;
                }
                else if (evenement is DépotRéalisé)
                {
                    Provision.Montant1 = Provision.Montant1 + ((DépotRéalisé) evenement).MontantDepot.Montant1;
                }
            }
        }

        private Montant Provision
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
            yield return new DépotRéalisé(_numéroDeCompte,montantDepot,dateDepot);
        }

        public IEnumerable<IEvenementMetier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {   
            if (montantRetrait.Montant1 <= Provision.Montant1)
            {
                yield return new RetraitRéalisé(_numéroDeCompte, montantRetrait, dateRetrait);
            }
            else
            {
                yield return new RetraitRéalisé(_numéroDeCompte, montantRetrait, dateRetrait);
                int difference = Provision.Montant1 - montantRetrait.Montant1;
                yield return new BalanceNégativeDétectée(_numéroDeCompte, new Montant(difference*-1), dateRetrait);
            }
        }
    }
}