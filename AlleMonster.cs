using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel
{
    public class AlleMonster
    {

        //Meine erstellten Monster/Monster Repertoire
        //habe alle Entwicklungen erst mal weggelassen, Überlegung wegen Level und Entwicklungen und Entwicklungssteinen etc
        //Abra, Karpador und Ditto* auch erst mal weg wegen Attacken und die legendären Vögel auch erst mal
        //exakt 73 Pokemon also ca. Hälfte der First Gen (71 ohne Mew und Mewtu)

        //Abra kann nur Teleport, Karpador nur Platscher
        //*Dittos Wandler evtl auf die Attacken des Gegners zugreifen und dann auch per Zufall auswählen lassen
        public static List<Monster> MonsterListe { get; } = new List<Monster>
        {
            new Monster
            (
                "Bisasam", // Name
                AlleTypen.TypListe.Find(typ => typ.Name == "Pflanze"), //Typ
                new List<Attacke>
                {   
                    //Attacken
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Rasierblatt"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Tackle")
                },
                new List<Ort>
                {
                    //Fundorte
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 2")
                },
                5 //Kraftpunkte
            ),

            new Monster
            (
                "Glumanda",
                AlleTypen.TypListe.Find(typ => typ.Name == "Feuer"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Glut"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Kratzer")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 1")
                },
                5
            ),

            new Monster
            (
                "Schiggy",
                AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Aquaknarre"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Biss")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 3"),
                },
                5
            ),

            new Monster
            (
                "Raupy",
                AlleTypen.TypListe.Find(typ => typ.Name == "Kaefer"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Tackle"),
                    //AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Fadenschuss")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 8"),
                },
                3
            ),

            new Monster
            (
                "Hornliu",
                AlleTypen.TypListe.Find(typ => typ.Name == "Kaefer"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Gift"), //sowieso nur ein Typ
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Giftstachel")//,
                    //AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Fadenschuss")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 13")
                },
                3
            ),

            new Monster
            (
                "Taubsi",
                AlleTypen.TypListe.Find(typ => typ.Name == "Flug"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Normal")
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Flügelschlag"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Ruckzuckhieb")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 1")
                },
                3
            ),

            new Monster
            (
                "Rattfratz",
                AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Ruckzuckhieb"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Tackle")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 2")
                },
                3
            ),

            new Monster
            (
                "Habitak",
                AlleTypen.TypListe.Find(typ => typ.Name == "Flug"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Schnabel"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Furienschlag")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 3")
                },
                3
            ),

            new Monster
            (
                "Rettan",
                AlleTypen.TypListe.Find(typ => typ.Name == "Gift"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Giftstachel"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Wickel")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 11")
                },
                3
            ),

            new Monster
            (
                "Pikachu",
                AlleTypen.TypListe.Find(typ => typ.Name == "Elektro"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Donnerschock"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Ruckzuckhieb")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 1")
                },
                5
            ),

            new Monster
            (
                "Sandan",
                AlleTypen.TypListe.Find(typ => typ.Name == "Boden"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Kratzer"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Sternschauer")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 3")
                },
                3
            ),

            new Monster
            (
                "Nidoran (weiblich)",
                AlleTypen.TypListe.Find(typ => typ.Name == "Gift"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Biss"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Giftstachel")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 6")
                },
                3
            ),

            new Monster
            (
                "Nidoran (männlich)",
                AlleTypen.TypListe.Find(typ => typ.Name == "Gift"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Hornattacke"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Gitstachel")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 5")
                },
                3
            ),

            new Monster
            (
                "Piepi",
                AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Duplexhieb"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Pfund")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 10")
                },
                3
            ),

            new Monster
            (
                "Vulpix",
                AlleTypen.TypListe.Find(typ => typ.Name == "Feuer"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Glut"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Ruckzuckhieb")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 8")
                },
                4
            ),

            new Monster
            (
                "Pummeluff",
                AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Pfund"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Duplexhieb")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 9")
                },
                3
            ),

            new Monster
            (
                "Zubat",
                AlleTypen.TypListe.Find(typ => typ.Name == "Gift"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Flug"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Flügelschlag"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Biss")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 13")
                },
                3
            ),

            new Monster
            (
                "Myrapla",
                AlleTypen.TypListe.Find(typ => typ.Name == "Pflanze"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Gift"),
                new List<Attacke>
                {
                    //AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Absorber"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Blättertanz"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Säure")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 10")
                },
                3
            ),

            new Monster
            (
                "Paras",
                AlleTypen.TypListe.Find(typ => typ.Name == "Kaefer"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Pflanze"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Blutsauger"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Kratzer")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 7")
                },
                3
            ),

            new Monster
            (
                "Bluzuk",
                AlleTypen.TypListe.Find(typ => typ.Name == "Kaefer"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Gift"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Blutsauger"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Tackle")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 1")
                },
                3
            ),

            new Monster
            (
                "Digda",
                AlleTypen.TypListe.Find(typ => typ.Name == "Boden"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Schaufler"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Schlitzer")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 9")
                },
                3
            ),

            new Monster
            (
                "Mauzi",
                AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Kratzfurie"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Zahltag")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 3")
                },
                5
            ),

            new Monster
            (
                "Enton",
                AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Konfusion"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Kratzer")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 2")
                },
                5
            ),

            new Monster
            (
                "Menki",
                AlleTypen.TypListe.Find(typ => typ.Name == "Kampf"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Fuchtler"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Geowurf")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 9")

                },
                4
            ),

            new Monster
            (
                "Fukano",
                AlleTypen.TypListe.Find(typ => typ.Name == "Feuer"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Glut"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Bodycheck")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 4")

                },
                4
            ),

            new Monster
            (
                "Quapsel",
                AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Blubber"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Duplexhieb")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 4")

                },
                3
            ),

            //new Monster //hat von Natur aus nur Teleport als Attacke
            //(
            //    "Abra",
            //    AlleTypen.TypListe.Find(typ => typ.Name == "Psycho"),
            //    new List<Attacke>
            //    {
            //        AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Teleport")
            //    },
            //    new List<Ort>
            //    {
            //        AlleOrte.OrtListe.Find(o => o.Name == "Route ")

            //    },
            //    3
            //),

            new Monster
            (
                "Machollo",
                AlleTypen.TypListe.Find(typ => typ.Name == "Kampf"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Karateschlag"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Fußkick")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 11")
                },
                4
            ),

            new Monster
            (
                "Knofensa",
                AlleTypen.TypListe.Find(typ => typ.Name == "Pflanze"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Gift"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Rankenhieb"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Säure")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 8")
                },
                3
            ),

            new Monster
            (
                "Tentacha",
                AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Gift"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Giftstachel"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Wickel")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 6")
                },
                3
            ),

            new Monster
            (
                "Kleinstein",
                AlleTypen.TypListe.Find(typ => typ.Name == "Gestein"),
                //AlleTypen.TypListe.Find(typ => typ.Name == Boden"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Steinwurf"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Tackle")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 12")
                },
                3
            ),

            new Monster
            (
                "Ponita",
                AlleTypen.TypListe.Find(typ => typ.Name == "Feuer"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Feuerwirbel"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Stampfer")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 3")
                },
                4
            ),

            new Monster
            (
                "Flegmon",
                AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Psycho"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Aquaknarre"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Konfusion")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 5")
                },
                3
            ),

            new Monster
            (
                "Magnetilo",
                AlleTypen.TypListe.Find(typ => typ.Name == "Elektro"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Ultraschall"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Donnerschock")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 7")
                },
                3
            ),

            new Monster
            (
                "Porenta",
                AlleTypen.TypListe.Find(typ => typ.Name == "Flug"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Schnabel"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Furienschlag")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 7")
                },
                4
            ),

            new Monster
            (
                "Dodu",
                AlleTypen.TypListe.Find(typ => typ.Name == "Flug"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Bohrschnabel"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Triplette")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 4")
                },
                4
            ),

            new Monster
            (
                "Jurob",
                AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Kopfnuss"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Aurorastrahl")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 11")
                },
                4
            ),

            new Monster
            (
                "Sleima",
                AlleTypen.TypListe.Find(typ => typ.Name == "Gift"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Schlammbad"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Pfund")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 2")
                },
                4
            ),

            new Monster
            (
                "Muschas",
                AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Tackle"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Eisstrahl")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 11")
                },
                3
            ),

            new Monster
            (
                "Nebulak",
                AlleTypen.TypListe.Find(typ => typ.Name == "Geist"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Gift"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Nachtnebel"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Traumfresser")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 1")
                },
                4
            ),

            new Monster
            (
                "Onix",
                AlleTypen.TypListe.Find(typ => typ.Name == "Gestein"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Boden"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Steinwurf"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Klammergriff")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 4")
                },
                5
            ),

            new Monster
            (
                "Traumato",
                AlleTypen.TypListe.Find(typ => typ.Name == "Psycho"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Psychokinese"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Kopfnuss")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 12")
                },
                5
            ),

            new Monster
            (
                "Krabby",
                AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Blubber"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Krabhammer")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 7")
                },
                3
            ),

            new Monster
            (
                "Voltobal",
                AlleTypen.TypListe.Find(typ => typ.Name == "Elektro"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Ultraschall"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Tackle")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 13")
                },
                3
            ),

            new Monster
            (
                "Owei",
                AlleTypen.TypListe.Find(typ => typ.Name == "Pflanze"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Psycho"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Stakkato"),
                    //AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Solarstrahl")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 12")
                },
                3
            ),

            new Monster
            (
                "Tragosso",
                AlleTypen.TypListe.Find(typ => typ.Name == "Boden"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Knochenkeule"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Fuchtler")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 9")
                },
                3
            ),

            new Monster
            (
                "Kicklee",
                AlleTypen.TypListe.Find(typ => typ.Name == "Kampf"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Turmkick"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Megakick")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 6")
                },
                4
            ),

            new Monster
            (
                "Nockchan",
                AlleTypen.TypListe.Find(typ => typ.Name == "Kampf"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Megahieb"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Konter")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 8")
                },
                4
            ),

            new Monster
            (
                "Schlurp",
                AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Stampfer"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Slam")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 7")
                },
                4
            ),

            new Monster
            (
                "Smogon",
                AlleTypen.TypListe.Find(typ => typ.Name == "Gift"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Smog"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Tackle")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 13")
                },
                4
            ),

            new Monster
            (
                "Rihorn",
                AlleTypen.TypListe.Find(typ => typ.Name == "Boden"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Hornbohrer"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Bodycheck")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 6")
                },
                5
            ),

            new Monster
            (
                "Chaneira",
                AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Pfund"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Duplexhieb")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 11")
                },
                5
            ),

            new Monster
            (
                "Tangela",
                AlleTypen.TypListe.Find(typ => typ.Name == "Pflanze"),
                new List<Attacke>
                {
                    //AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Absorber"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Klammergriff"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Slam")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 4")
                },
                5
            ),

            new Monster
            (
                "Kangama",
                AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Kometenhieb"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Irrschlag")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 12")
                },
                5
            ),

            new Monster
            (
                "Seeper",
                AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Blubber"),
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 2")
                },
                4
            ),

            new Monster
            (
                "Goldini",
                AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Hornattacke"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Kaskade")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 6")
                },
                4
            ),

            new Monster
            (
                "Sterndu",
                AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Aquaknarre"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Sternschauer")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 4")
                },
                4
            ),

            new Monster
            (
                "Pantimos",
                AlleTypen.TypListe.Find(typ => typ.Name == "Psycho"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Konfusion"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Duplexhieb")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 5")
                },
                4
            ),

            new Monster
            (
                "Sichlor",
                AlleTypen.TypListe.Find(typ => typ.Name == "Kaefer"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Flug"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Schlitzer"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Ruckzuckhieb")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 9")
                },
                5
            ),

            new Monster
            (
                "Rossana",
                AlleTypen.TypListe.Find(typ => typ.Name == "Eis"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Psycho"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Schlecker"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Eishieb")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 10")
                },
                5
            ),

            new Monster
            (
                "Elektek",
                AlleTypen.TypListe.Find(typ => typ.Name == "Elektro"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Donnerschlag"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Ruckzuckhieb")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 13")
                },
                5
            ),

            new Monster
            (
                "Magmar",
                AlleTypen.TypListe.Find(typ => typ.Name == "Feuer"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Feuerschlag"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Smog")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 7")
                },
                5
            ),

            new Monster
            (
                "Pinsir",
                AlleTypen.TypListe.Find(typ => typ.Name == "Kaefer"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Schlitzer"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Klammer")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 11")
                },
                5
            ),

            new Monster
            (
                "Tauros",
                AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Stampfer"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Raserei")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 10")
                },
                5
            ),

            new Monster
            (
                "Lapras",
                AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Eis"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Eisstrahl"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Bodyslam")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 9")
                },
                5
            ),

            new Monster
            (
                "Evoli",
                AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Tackle"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Ruckzuckhieb")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 2")
                },
                4
            ),

            new Monster
            (
                "Porygon",
                AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Psystrahl"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Tackle")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 5")
                },
                5
            ),

            new Monster
            (
                "Amonitas",
                AlleTypen.TypListe.Find(typ => typ.Name == "Gestein"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Dornkanone"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Auqaknarre")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 10")
                },
                4
            ),

            new Monster
            (
                "Kabuto",
                AlleTypen.TypListe.Find(typ => typ.Name == "Gestein"),
                //AlleTypen.TypListe.Find(typ => typ.Name == "Wasser"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Kratzer"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Schlitzer")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 5")
                },
                4
            ),

            new Monster
            (
                "Aerodactyl",
                //AlleTypen.TypListe.Find(typ => typ.Name == "Gestein"),
                AlleTypen.TypListe.Find(typ => typ.Name == "Flug"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Flügelschlag"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Biss")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 13")
                },
                5
            ),

            new Monster
            (
                "Relaxo",
                AlleTypen.TypListe.Find(typ => typ.Name == "Normal"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Bodyslam"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Kopfnuss")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 12")
                },
                5
            ),

            new Monster
            (
                "Dratini",
                AlleTypen.TypListe.Find(typ => typ.Name == "Drache"),
                new List<Attacke>
                {
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Drachenwut"),
                    AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Slam")
                },
                new List<Ort>
                {
                    AlleOrte.OrtListe.Find(o => o.Name == "Route 8")
                },
                5
            ),

            //new Monster
            //(
            //    "Mewtu",
            //    AlleTypen.TypListe.Find(typ => typ.Name == "Psycho"),
            //    new List<Attacke>
            //    {
            //        AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Psychokinese"),
            //        AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Sternschauer")
            //    },
            //    new List<Ort>
            //    {
            //        //AlleOrte.OrtListe.Find(o => o.Name == "Route ")
            //    },
            //    5
            //),

            //new Monster
            //(
            //    "Mew",
            //    AlleTypen.TypListe.Find(typ => typ.Name == "Psycho"),
            //    new List<Attacke>
            //    {
            //        AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Psychokinese"),
            //        AlleAttacken.AttackenListe.Find(attacke => attacke.Name == "Pfund")
            //    },
            //    new List<Ort>
            //    {
            //        //AlleOrte.OrtListe.Find(o => o.Name == "Route ")
            //    },
            //    5
            //)

        };
        
    }
}


//Raupy, Hornliu und Seeper werden nur eine Attacke haben, haben sonst ohne TM's nicht viele nützliche Attacken


//wenn alle Monster gefangen, dann Mewtu auftauchen lassen?
//Mew wechselnder Standort? "Wanderpokemon"
//Belohnungen bei Anzahl von gewonnenen Kämpfen oä?