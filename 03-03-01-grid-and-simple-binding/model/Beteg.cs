using System;
using System.Collections.Generic;
using System.Text;


namespace oop.model
{
    /// <summary>
    /// G1.01 Modell réteg 
    /// 
    /// A korházban lévő beteg TTI meghatározása
    /// </summary>
    class Beteg
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
            Nev = string.Empty;
            Suly = 60;
            Magassag = 1.6;
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

        /// <summary>
        /// Testtömeg index
        /// kg / magasság^2
        /// </summary>
        public double TTI
        {
            get
            {
                double tti = suly / Math.Pow(magassag, 2);
                double roundedTTI = Math.Round(tti, 2);
                return roundedTTI;
            }
        }

        public string BetegAdatok
        {
            get
            {
                return nev + " beteg testőmeg indexe: " + TTI;
            }
        }
    }
}
