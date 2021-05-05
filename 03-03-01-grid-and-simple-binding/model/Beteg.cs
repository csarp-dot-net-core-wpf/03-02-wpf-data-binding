using System;
using System.Collections.Generic;
using System.Text;

// G1.20 Betöltjük a szükséges névteret
using System.ComponentModel;

namespace oop.model
{
    /// <summary>
    /// G1.01 Modell réteg 
    /// 
    /// A korházban lévő beteg TTI meghatározása
    /// </summary>
    /// 
    /// G1.20 A Beteg osztály az INotifyPropertyChanged interfacből származtatjuk
    ///       Ha módosítunk adatot az ablakban, akkor jelzi melyik tulajdonságot kell frissíteni
    class Beteg:INotifyPropertyChanged
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
                /// G1.23 Ha a Nev mező változik az ablakba, megadjuk melyik tulajdonságot kell frissíteni
                OnPropertyChanged("BetegAdatok");
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

        /// <summary>
        /// G1.21 Implementáljuk az interfacet
        /// 
        /// http://www.blackwasp.co.uk/INotifyPropertyChanged.aspx
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// G1.22 Megírjuk az interface szükséges metódusát. Mindig ezt kell írni
        /// </summary>
        /// <param name="property"></param>
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
