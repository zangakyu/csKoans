namespace FinalTest.banque.evenements
{
    public struct CompteCréé : IEvenementMetier
    {
        public string NuméroDeCompte { get; private set; }
        private int _autorisationDeCrédit;

        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit) : this()
        {
            NuméroDeCompte = numéroDeCompte;
            _autorisationDeCrédit = autorisationDeCrédit;
        }
    }
}
