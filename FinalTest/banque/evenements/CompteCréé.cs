namespace FinalTest.banque.evenements
{
    public struct CompteCréé : IEvenementMetier
    {
        public string NuméroDeCompte { get; private set; }
        public int AutorisationDeCrédit { get; private set; }

        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit) : this()
        {
            NuméroDeCompte = numéroDeCompte;
            AutorisationDeCrédit = autorisationDeCrédit;
        }
    }
}
