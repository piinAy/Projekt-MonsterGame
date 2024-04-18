using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel
{
    public class AlleTypen //15 Typen die in der First Gen vorkamen
    {
        public static List<Typ> TypListe { get; } = new List<Typ>
        {
            new Typ("Feuer"),
            new Typ("Wasser"),
            new Typ("Pflanze"),
            new Typ("Normal"),
            new Typ("Flug"),
            new Typ("Kaefer"),
            new Typ("Elektro"),
            new Typ("Gestein"),
            new Typ("Kampf"),
            new Typ("Boden"),
            new Typ("Drache"),
            new Typ("Geist"),
            new Typ("Gift"),
            new Typ("Eis"),
            new Typ("Psycho")

        };
      
    }
}
