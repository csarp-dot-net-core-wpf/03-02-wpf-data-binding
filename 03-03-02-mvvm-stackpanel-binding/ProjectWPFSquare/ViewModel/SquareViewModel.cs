using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using oop.Model;

namespace ProjectWPFSquare.ViewModel
{
    /// <summary>
    /// MVVM.04
    /// Az MVVM olyan tervezési minta, amelynek a célja, hogy teljes egészében elválassza a megjelenítést és a mögötte lévő tevékenységeket.
    /// ViewModel
    /// A nézetmodell lehetőséget ad a modell változásainak követésére és tevékenységek végrehajtására
    /// SquareViewModel osztály
    /// Az osztályban megatalálhatók azok a tulajdonságok amelyeket meg akarunk jeleníteni az ablakban
    /// </summary>
    class SquareViewModel
    {
        // MVVM.05 A ViewModel és Model kapcsolat
        private Square square;

        public SquareViewModel()
        {
            // Példányosítunk egy alapértelmezett négyzetet
            square = new Square();
        }

        // MVVM.06 A View-n megjelenő adatok
        public string Perimeter
        {
            get
            {
                string result = square.Perimeter + " méter.";
                return result;
            }
        }

        public string Area
        {
            get
            {
                string result = square.Area + " négyzetméter.";
                return result;
            }
        }
    }
}
