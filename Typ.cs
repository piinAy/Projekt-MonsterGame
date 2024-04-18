using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Spiel;

namespace Spiel
{
    public class Typ
    {
        public string Name { get; set; }

        public Typ(string name)
        {
            Name = name;
        }

        //in separate Klasse ausgelagert (bei anderen Klassen auch so handgehabt dann)
        //public static List<Typ> TypListe { get; } = new List<Typ>
        //{
        //    new Typ("Feuer"),
        //    new Typ("Wasser"),
        //    new Typ("Pflanze"),
        //    new Typ("Normal"),
        //    new Typ("Flug"),
        //    new Typ("Kaefer")
        //};

        //Methode, wie die Typen sich zueinander verhalten
        //habe wirkungslos ausgeschlossen und nicht alle Effektivitäten dazu genommen
        public static int EffektivitaetUndSchaden(string angreiferTyp, string verteidigerTyp)
        {
            List<string> sehrEffektiveKombinationen = new List<string>
            {
                "Wasser Feuer",
                "Feuer Pflanze",
                "Pflanze Wasser",
                "Flug Kaefer",
                "Elektro Flug",
                "Elektro Wasser",
                "Feuer Kaefer",
                "Feuer Eis",
                "Kampf Normal",
                "Kampf Flug",
                "Wasser Gestein",
                "Flug Kampf",
                "Gift Pflanze",
                "Boden Elektro",
                "Boden Gestein",
                "Gestein Feuer",
                "Gestein Eis",
                "Kaefer Pflanze",
                "Geist Psycho",
                "Psycho Kampf",
                "Psycho Gift",
                "Eis Pflanze",
                "Eis Drache"
            };

            string kombination = $"{angreiferTyp} {verteidigerTyp}";

            if (sehrEffektiveKombinationen.Contains(kombination))
            {
                //schreibe ich lieber in der program.cs
                //Console.WriteLine(" die Attacke ist sehr effektiv!");
                return 3; //wie viel Schadenspunkte abgezogen werden sollen
            }
            //Effektivität umgekehrt wenn Typen vertauscht
            if (sehrEffektiveKombinationen.Contains($"{verteidigerTyp} {angreiferTyp}"))
            {
                //Console.WriteLine(" die Attacke ist nicht sehr effektiv.");
                return 1;
            }
          
            //2 Schadenspunkte wenn Attacke weder sehr effektiv noch nicht sehr effektiv
            return 2;
        }
    }
}


