namespace TTIProject.Model
{
    public class Beteg
    {
        /// <summary>
        /// Beteg neve
        /// </summary>
        private string nev;
        /// <summary>
        /// Beteg súlya (kg)
        /// </summary>
        private double suly;
        /// <summary>
        /// Beteg magassága (méter)
        /// </summary>
        private double magassag;

        /// <summary>
        /// Alapértelmezett konstruktor
        /// </summary>
        public Beteg()
        {
            nev = string.Empty;
            suly = 60;
            magassag = 1.6;
        }

        /// <summary>
        /// Írható tulajdonságok
        /// </summary>
        public string Nev
        {
            set
            {
                nev = value;
            }
        }
        public double Suly
        {
            set
            {
                suly = value;
            }
        }

        public double Magassag
        {
            set
            {
                magassag = value;
            }
        }
    }
}
