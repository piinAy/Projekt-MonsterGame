using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Spiel
{
    public class Attacke
    {
        public string Name { get; set; }
        public Typ Typ { get; set; }
        //public int Angriffspunkte { get; set; }
        //Nummern zuweisen?


        public Attacke(string name, Typ typ) //int angriffspunkte
        {
            Name = name;
            Typ = typ;
            //Angriffspunkte = angriffspunkte;
        }
    }
}
