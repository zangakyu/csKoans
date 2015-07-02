using System;
using System.Collections;
using System.Collections.Generic;

namespace FinalTest.banque
{
    public class CompteBancaire
    {
       
        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
             List<IEvenementMetier> evenements = new List<IEvenementMetier>();
            CompteCréé compteCréé = new CompteCréé(numéroDeCompte,autorisationDeCrédit);
            evenements.Add(compteCréé);
            return evenements;
        }
    }
}
