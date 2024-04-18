using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel
{
    public class Monster
    {
        public string Name { get; set; }
        public Typ Typ { get; set; } //Monster werden der Einfachheit halber nur einen Typ haben
        public List<Attacke> Attacken { get; set; } //Liste weil mehrere Attacken haben wird
        public List<Ort> Orte { get; set; } //hier das gleiche//nein hab zu einem einzigen Ort pro Monster geändert, belasse es aber als Liste

        public int Kraftpunkte { get; set; }
        //public int Level { get; set; }
        //public int Indexnummer { get; set }

        public Monster(string name, Typ typ, List<Attacke> attacken, List<Ort> orte, int kraftpunkte) //int level, int indexnummer
        {
            Name = name;
            Typ = typ;
            Attacken = attacken;
            Orte = orte;
            Kraftpunkte = kraftpunkte;

            //Level = level;
            //Indexnummer = indexnummer;
        }

    }
}

//Kraftpunkte (niedrig gehalten damit Kämpfe nicht ewig gehen, 2-3 Runden ca)
//
//3 KP: Raupy, Hornliu, Taubsi, Rattfratz, Habitak, Rettan, Sandan, Nidoran (weiblich), Nidoran (männlich), Piepi, Pummeluff, Zubat, Myrapla, Paras, Bluzuk, Digda, Quapsel, Knofensa, Tentacha, Kleinstein, Flegmon, Magnetilo, Muschas, Owei
//
//4 KP: Vulpix, Menki, Fukano, Machollo, Ponita, Porenta, Dodu, Jurob, Sleima, Nebulak, Kicklee, Nockchan, Schlurp, Smogon, Seeper, Goldini, Sterndu, Pantimos, Evoli, Amonitas, Kabuto
//
//5 KP: Bisasam, Glumanda, Schiggy, Pikachu, Mauzi, Enton, Onix, Traumato, Rihorn, Chaneira, Tangela, Kangama, Sichlor, Rossana, Elektek, Magmar, Pinsir, Tauros, Lapras, Porygon, Aerodactyl, Relaxo, Dratini (Mewtu, Mew)