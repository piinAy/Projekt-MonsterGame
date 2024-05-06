using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel
{
    public class AlleAttacken //ein Teil von den Attacken bzw. 65 Stück von 165 (nach Typ oder alphabetisch ordnen?), "einfache" Attacken gewählt
    {
        public static List<Attacke> AttackenListe { get; } = new List<Attacke>
        {
            new Attacke("Rasierblatt", AlleTypen.TypListe.First(typ => typ.Name == "Pflanze")),
            new Attacke("Tackle", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Glut", AlleTypen.TypListe.First(typ => typ.Name == "Feuer")),
            new Attacke("Kratzer", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Aquaknarre", AlleTypen.TypListe.First(typ => typ.Name == "Wasser")),
            new Attacke("Biss", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            //new Attacke("Fadenschuss", AlleTypen.TypListe.First(typ => typ.Name == "Kaefer")),
            new Attacke("Giftstachel", AlleTypen.TypListe.First(typ => typ.Name == "Gift")),
            new Attacke("Flügelschlag", AlleTypen.TypListe.First(typ => typ.Name == "Flug")),
            new Attacke("Ruckzuckhieb", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Schnabel", AlleTypen.TypListe.First(typ => typ.Name == "Flug")),
            new Attacke("Furienschlag", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Wickel", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Donnerschock", AlleTypen.TypListe.First(typ => typ.Name == "Elektro")),
            new Attacke("Sternschauer", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Hornattacke", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Duplexhieb", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Pfund", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Blättertanz", AlleTypen.TypListe.First(typ => typ.Name == "Pflanze")),
            new Attacke("Blutsauger", AlleTypen.TypListe.First(typ => typ.Name == "Kaefer")),
            new Attacke("Schaufler", AlleTypen.TypListe.First(typ => typ.Name == "Boden")),
            new Attacke("Schlitzer", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Zahltag", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Konfusion", AlleTypen.TypListe.First(typ => typ.Name == "Psycho")),
            new Attacke("Geowurf", AlleTypen.TypListe.First(typ => typ.Name == "Kampf")),
            new Attacke("Fuchtler", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Bodycheck", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Blubber", AlleTypen.TypListe.First(typ => typ.Name == "Wasser")),
            new Attacke("Karateschlag", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Fußkick", AlleTypen.TypListe.First(typ => typ.Name == "Kampf")),
            new Attacke("Rankenhieb", AlleTypen.TypListe.First(typ => typ.Name == "Pflanze")),
            new Attacke("Säure", AlleTypen.TypListe.First(typ => typ.Name == "Gift")),
            new Attacke("Steinwurf", AlleTypen.TypListe.First(typ => typ.Name == "Gestein")),
            new Attacke("Feuerwirbel", AlleTypen.TypListe.First(typ => typ.Name == "Feuer")),
            new Attacke("Stampfer", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Ultraschall", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Bohrschnabel", AlleTypen.TypListe.First(typ => typ.Name == "Flug")),
            new Attacke("Triplette", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Kopfnuss", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Aurorastrahl", AlleTypen.TypListe.First(typ => typ.Name == "Eis")),
            new Attacke("Schlammbad", AlleTypen.TypListe.First(typ => typ.Name == "Gift")),
            new Attacke("Eisstrahl", AlleTypen.TypListe.First(typ => typ.Name == "Eis")),
            new Attacke("Nachtnebel", AlleTypen.TypListe.First(typ => typ.Name == "Geist")),
            new Attacke("Traumfresser", AlleTypen.TypListe.First(typ => typ.Name == "Psycho")),
            new Attacke("Klammergriff", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Psychokinese", AlleTypen.TypListe.First(typ => typ.Name == "Psycho")),
            new Attacke("Klammer", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Stakkato", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            //new Attacke("Solarstrahl", AlleTypen.TypListe.First(typ => typ.Name == "Pflanze")),
            new Attacke("Knochenkeule", AlleTypen.TypListe.First(typ => typ.Name == "Boden")),
            new Attacke("Turmkick", AlleTypen.TypListe.First(typ => typ.Name == "Kampf")),
            new Attacke("Megakick", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Megahieb", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Konter", AlleTypen.TypListe.First(typ => typ.Name == "Kampf")),
            new Attacke("Slam", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Smog", AlleTypen.TypListe.First(typ => typ.Name == "Gift")),
            new Attacke("Hornbohrer", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Kometenhieb", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Irrschlag", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Schlecker", AlleTypen.TypListe.First(typ => typ.Name == "Geist")),
            new Attacke("Eishieb", AlleTypen.TypListe.First(typ => typ.Name == "Eis")),
            new Attacke("Donnerschlag", AlleTypen.TypListe.First(typ => typ.Name == "Elektro")),
            new Attacke("Feuerschlag", AlleTypen.TypListe.First(typ => typ.Name == "Feuer")),
            new Attacke("Bodyslam", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Psystrahl", AlleTypen.TypListe.First(typ => typ.Name == "Psycho")),
            new Attacke("Dornkanone", AlleTypen.TypListe.First(typ => typ.Name == "Normal")),
            new Attacke("Drachenwut", AlleTypen.TypListe.First(typ => typ.Name == "Drache"))

        };
    }

}

//Fadenschuss und Teleporter ziehen keine Schadenspunkte ab
//Absorber fügt dem Ausführer eigentlich die abgezogenen Kraftpunkte des Gegners hinzu
//oder so programmieren aber für diesen Anwendungsfall eher ungeeignet

//Flügelschlag, Blättertanz und Säure ohne Umlaute schreiben?




//(nur Statistiken für mich)
//Anzahl Übersicht wie viele Attacken diesen Typ haben und wie viele Monster diesen Typ haben:
//
//Typ       Attacken    Monster
//
//Feuer     3x          5x
//Wasser    2x          12x
//PFlanze   3x          5x
//Normal    25x         10x
//Flug      3x          5x
//Kaefer    1x          6x
//Elektro   2x          4x
//Gestein   1x          4x
//Psycho    5x          4x (inkl. Mew und Mewtu)
//Geist     2x          1x
//Drache    1x          1x
//Boden     2x          4x
//Kampf     4x          4x
//Gift      4x          6x
//Eis       3x          1x


//Anzahl pro verwendeter Attacke
//
//Glut              3x
//Rasierblatt       1x
//Aquaknarre        3x
//Kratzer           6x
//Schnabel          2x
//Tackle            10x
//Biss              4x
//Flügelschlag      3x
//Giftstachel       4x
//Ruckzuckhieb      7x
//Furienschlag      2x
//Wickel            2x
//Donnerschock      2x
//Sternschauer      3x
//Hornattacke       2x
//Duplexhieb        5x
//Pfund             5x
//Blättertanz       1x
//Blutsauger        2x
//Schaufler         1x
//Schlitzer         4x
//Zahltag           1x
//Konfusion         3x
//Geowurf           1x
//Fuchtler          2x
//Bodycheck         2x
//Blubber           3x
//Karateschlag      1x
//Fußkick           1x
//Rankenhieb        1x
//Säure             2x
//Steinwurf         2x
//Feuerwirbel       1x
//Stampfer          3x
//Ultraschall       2x
//Bohrschnabel      1x
//Triplette         1x
//Kopfnuss          3x
//Aurorastrahl      1x
//Schlammbad        1x
//Eisstrahl         2x
//Nachtnebel        1x
//Traumfresser      1x
//Klammergriff      2x
//Psychokinese      3x
//Klammer           1x
//Stakkato          1x
//Knochenkeule      1x
//Turmkick          1x
//Megakick          1x
//Megahieb          1x
//Konter            1x
//Slam              3x
//Smog              2x
//Hornbohrer        1x
//Kometenhieb       1x
//Irrschlag         1x
//Schlecker         1x
//Eishieb           1x
//Donnerschlag      1x
//Feuerschlag       1x
//Bodyslam          2x
//Psystrahl         1x
//Dornkanone        1x
//Drachenwut        1x
