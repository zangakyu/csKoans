namespace FinalTest.operations
{
    public class TypeReference
    {
        private int Valeur { get; set; }

        public TypeReference(int i)
        {
            Valeur = i;
        }

        public override bool Equals(object obj)
        {
            if (((TypeReference) obj).Valeur == this.Valeur)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
