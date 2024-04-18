using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Spiel;

//DISCLAIMER: Das Spiel ist natürlich "vereinfacht", wobei selbst das schon eine Monsteraufgabe war (im wahrsten Sinne des Wortes haha XD )
//Das Spiel geht solange du Lust hast Pokemon zu fangen oder zu bekämpfen (oder bis es keine mehr gibt^^), du kannst selber entscheiden wann du das Spiel beenden möchtest ;) (s. Menü im Spiel)
//ich habe den Rivalen noch drin gelassen, Trainerkämpfe implementiere ich später einmal
//Spieldauer ca. 20-30min wenn man alle Pokemon fangen möchte und auch ein bisschen rumspielen möchte (z.B. kämpfen, Karte, Menü)
//GOTTA CATCH 'EM ALL! :D
class Program
{
    //außerhalb der Main Methode = globale Variable (kann auch darunter stehen bei den anderen globalen Variablen)
    static readonly Stopwatch spielzeitStoppuhr = new Stopwatch();

    static void Main()
    {
        //ab hier Startzeit bzw ab hier Zeit messen
        spielzeitStoppuhr.Start();

        //Console.Write("[SPIEL BEGINNEN]\nDRÜCKE EINE TASTE");
        //Console.CursorVisible = true;
        //Console.ReadKey(); //wartet auf jedmögliche Eingabe

        //VisuelleEffekte.PokemonSchriftzug(5);
        //Thread.Sleep(500);
        //Console.WriteLine("\n\n\t\t\t       [START]\n");
        //Console.Write("\t\t          DRÜCKE EINE TASTE");
        //Console.CursorVisible = true;
        //Console.ReadKey();
        //Console.Clear();

        //Console.CursorVisible = false;
        //Console.WriteLine("Willkommen in der Welt der Monster!");

        //Startort festgelegt
        int aktuellerStandort = 0;

        string userName = UserNameBestimmen();

        //userName wird übergeben
        string rivalenName = RivalenNameBestimmen(userName);

     
        //Monsterauswahl für User und Rivalen bestimmen
        //hier weisen wir dem Startermonster den Wert zu, der bei der Methode zurückgegeben wurde
        Monster starterMonster = StarterMonsterBestimmen(rivalenName);
        //das Monster seinem Team hinzufügen
        Team.Add(starterMonster);
        //AlleMonster.MonsterListe.ForEach(Team.Add);
        //Team.RemoveAt(1);

        Console.Clear();
        Console.WriteLine($"Du hast {starterMonster.Name} gewählt. Gute Wahl!");
        Monster rivalenMonster = RivalenMonsterBestimmen(starterMonster);
        Thread.Sleep(1000);
        Console.WriteLine($"\n{rivalenName} hat {rivalenMonster.Name} gewählt!");
        Console.Write("\n\nDrücke eine Taste zum Fortfahren");
        Console.ReadKey();

        //vorab bestimmter aktuellerStandort und userName werden dieser Methode übergeben
        StandortBestimmen(aktuellerStandort, userName);
        //Methoden zu arg miteinander verschachtelt?

        //zu viele Parameterübergaben bei den folgenden Methoden für meinen Geschmack, neue Klasse für Spielerdaten machen?
        //Welche Methode in welche übergreift aktuell:
        //StandortBestimmen->ZufaelligesMonsterAusRouteBestimmen->MonsterInterAktion<->Kampf            <->Menue<->Team & Karte
        //                 ->Menue<->Team & Karte                                   <->MonsterFangen    ->Team  <->Menue->Karte
        //                                                                          <->Menue            -> Team & Karte

    }

    //weitere globale Variablen
    //Liste erstellt für das Team von Monstern vom User
    //Listen deshalb da sie dynamisch sind, ich kann etwas hinzufügen oder entfernen und das ist keine feste Größe wie bei Arrays z.B.
    static readonly List<Monster> Team = new List<Monster>();

    static int zaehlerGewonnen = 0; //muss alles static sein und ebenfalls außerhalb des Main Codes damit ich darauf zugreifen kann
    static int zaehlerVerloren = 0;

    //zufallsgenerator außerhalb damit er nicht ständig neu erstellt wird
    static readonly Random zufallsgenerator = new Random();

    //Methoden
    static string UserNameBestimmen()
    {
        Console.CursorVisible = false;
        Thread.Sleep(1000);
        Console.Write("\nNenn mir doch mal deinen Namen geschwind: ");

        while (true)
        {
            Console.CursorVisible = true;
            string? userName = Console.ReadLine(); //eher var statt string weil könnte auch NULL sein
            //? = bedeutet, dass es auch NULL sein darf

            if (string.IsNullOrWhiteSpace(userName) || IstEingabeUngueltig(userName))
            {
                Console.Clear();
                Console.WriteLine("Eingabe ungültig.");
                Console.Write("\nBitte gib deinen Namen nochmal ein: ");
            }
            //evtl gesonderte Ausgaben z.B. "Keine Sonderzeichen!" oder "Keine Zahlen!" usw je nach Fall
            else
            {
                Console.Clear();
                Thread.Sleep(500);
                Console.WriteLine($"Hallo {userName}!");
                return userName;
            }
        }
    }

    //Überprüfung wenn mindestens ein Zeichen kein Buchstabe ist, dann Eingabe ungültig
    static bool IstEingabeUngueltig(string eingabe)
    {
        foreach (char zeichen in eingabe)
        {
            if (!char.IsLetter(zeichen))
            {
                return true; //wenn ein Zeichen gefunden worden ist welches kein Buchstabe ist, dann true und raus
            }
        }
        return false;
    }

    static string RivalenNameBestimmen(string userName)
    {
        Console.CursorVisible = false;
        Thread.Sleep(1000);
        Console.Write("\nUnd der Name deines Rivalen? Sag ihn mir mal nochmal: ");

        while (true)
        {
            Console.CursorVisible = true;
            var rivalenName = Console.ReadLine();

            if(rivalenName == userName)
            {
                Console.Clear();
                Console.WriteLine("Dein Rivale kann nicht denselben Namen wie du haben!");
                Console.Write("\nBitte gib einen anderen Namen für deinen Rivalen ein: ");
            }
            else if(string.IsNullOrWhiteSpace(rivalenName) || IstEingabeUngueltig(rivalenName))
            {
                Console.Clear();
                Console.WriteLine("Eingabe wurde nicht erkannt.");
                Console.Write("\nBitte gib einen anderen Namen für deinen Rivalen ein: ");
            }
            else
            {
                return rivalenName;
            }
        }
    }

    static Monster StarterMonsterBestimmen(string rivalenName)
    {
        MonsterAuswahl(rivalenName);
        Console.Write("\n\nDeine Wahl: ");

        while(true)
        {
            Console.CursorVisible = true;
            var eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "1":
                    //wenn Eingabe ist 1, dann das Bisasam direkt durch das return zurückgeben und im gleichen Zug raus aus der Methode
                    return AlleMonster.MonsterListe.First(monster => monster.Name.Equals("Bisasam", StringComparison.OrdinalIgnoreCase));//vergleicht strings unabhängig ob Buchstaben groß oder klein
                    //find durch first ersetzt, hört auf weiter zu suchen sobald gefunden
                case "2":
                    return AlleMonster.MonsterListe.First(monster => monster.Name.Equals("Glumanda", StringComparison.OrdinalIgnoreCase));
                case "3":
                    return AlleMonster.MonsterListe.First(monster => monster.Name.Equals("Schiggy", StringComparison.OrdinalIgnoreCase));
                default:
                    MonsterAuswahl(rivalenName);
                    Console.WriteLine("\n\nUngültige Eingabe.");
                    Console.Write("Bitte wiederholen: ");
                    break;
            }
        }
    }

    static void MonsterAuswahl(string rivalenName)
    {
        Console.Clear();
        Console.WriteLine($"Super! Du und {rivalenName} dürft nun ein Pokémon auswählen.\n");
        Console.WriteLine("[1] Bisasam");
        Console.WriteLine("[2] Glumanda");
        Console.WriteLine("[3] Schiggy");
    }

    static Monster RivalenMonsterBestimmen(Monster starterMonster)
    {

        //Rivalenmonster abhängig von der Wahl des Users bestimmen lassen
        //wenn Name vom Startermonster so und so, dann suche Monster für Rivale aus das so und so heißt und direkt zuweisen und raus aus der Methode
        switch (starterMonster.Name)
        {
            case "Bisasam":
                return AlleMonster.MonsterListe.First(monster => monster.Name.Equals("Glumanda", StringComparison.OrdinalIgnoreCase)); //anstatt .First kann ich auch hier .Find und Monster? machen
            case "Glumanda":
                return AlleMonster.MonsterListe.First(monster => monster.Name.Equals("Schiggy", StringComparison.OrdinalIgnoreCase));
            case "Schiggy":
                return AlleMonster.MonsterListe.First(monster => monster.Name.Equals("Bisasam", StringComparison.OrdinalIgnoreCase));
            default:
                throw new Exception("Monster nicht gefunden.");
                //besser eine Exception werfen anstatt return null (weil wollte irgendeinen Wert zurückgeben, also habe ich mich für den Wert "nichts" entschieden)
        }
    }

    static void StandortBestimmen(int aktuellerStandort, string userName)
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine($"Aktueller Standort: Route {aktuellerStandort}");
            Console.CursorVisible = false;
            Thread.Sleep(750);

            RoutenAuswahl(aktuellerStandort);
            Console.WriteLine("\n\nWähle und bestätige mit Enter.");
            Console.Write("Deine Wahl: ");

            while (true)
            {
                Console.CursorVisible = true;
                var benutzerEingabe = Console.ReadLine();

                if (benutzerEingabe?.ToUpper() == "M")
                {
                    //wenn wir in der Menue Methode "S" für Spiel beenden eingeben, dann lass ich mir ein true zurückgeben, dann beenden wir die Methode
                    if (Menue(userName, aktuellerStandort)) //Methode wird aufgerufen und kann auch direkt in einer Bedingung stehen da die Methode gleichzeitig einen Wert zurückgibt
                    {
                        return;
                    }
                    break;
                }
                if (string.IsNullOrWhiteSpace(benutzerEingabe))
                {
                    Console.Clear();
                    Console.WriteLine($"Du bleibst auf Route {aktuellerStandort}");

                    //Methode in der Methode aufrufen
                    if (ZufaelligesMonsterAusRouteBestimmen(aktuellerStandort, userName))
                    {
                        return;
                    }
                    break;
                }
                //Überprüfung ob Eingabe eine Zahl ist, die mit den vorgeschlagenen Routen übereinstimmt
                if (int.TryParse(benutzerEingabe, out int ausgewaehlteRoute) && Ort.Verbindungen[aktuellerStandort].Contains(ausgewaehlteRoute))
                {
                    Console.Clear();
                    Console.WriteLine($"Du gehst zur Route {ausgewaehlteRoute}");
                    //neuer aktueller Standort
                    aktuellerStandort = ausgewaehlteRoute;
                    //Standort wird an die nächste Methode übergeben
                    if (ZufaelligesMonsterAusRouteBestimmen(aktuellerStandort, userName))
                    {
                        return;
                    }
                    break;
                }

                Console.Clear();
                Console.WriteLine($"Aktueller Standort: Route {aktuellerStandort}");
                RoutenAuswahl(aktuellerStandort);
                Console.Write("\n\nUngültige Eingabe.\nBitte wiederholen: ");
            }
        }
    }

    static void RoutenAuswahl(int aktuellerStandort)
    {
        Console.WriteLine("\nWohin möchtest du gehen?\n");

        //alle Routenabzweigungen zeigen/vorschlagen
        foreach (var verbundeneRoute in Ort.Verbindungen[aktuellerStandort])
        {
            Console.WriteLine($"[{verbundeneRoute}] Route {verbundeneRoute}");
        }

        Console.WriteLine("\n[ENTER] Auf der Route bleiben");
        Console.WriteLine("\n\n[M]ENÜ");
    }

    static bool ZufaelligesMonsterAusRouteBestimmen(int aktuellerStandort, string userName)
    {

        //aus der gesamten Liste meiner Monster eine Liste erstellen, in der nur die Monster drin sind, bei denen mindestens ein Ort mit dem aktuellen Standort des Users übereinstimmt
        List<Monster> monsterAufDieserRoute = AlleMonster.MonsterListe
            .Where(monster => monster.Orte.Any(ort => ort.Nummer == aktuellerStandort))
            .ToList();

        //der Einfachheit halber, schließe ich bereits im Team befindende Monster aus, sodass es zu keinen Kollisionen kommen, da beide Listen auf die selbe Liste zugreifen. So ist jedes Monster nur einmal verfügbar, und dem User begegnen nicht immer wieder dieselben Monster. Wenn alle Monster gefangen, kann er zur nächsten Route gehen. Wenn die Monster freigelassen worden sind, dann kann er sie wieder dort finden, wo er sie gefangen hatte
        //später mit Interfaces bzw : ICloneable arbeiten um Listen unabhängig klonen zu können, sprich, ich kann die eine Liste ändern ohne dass die andere Liste beeinflusst wird
        monsterAufDieserRoute = monsterAufDieserRoute
            .Where(monster => !Team.Any(teamMonster => teamMonster.Name == monster.Name))
            .ToList();

        //Bedingung wenn mindestens ein Monster in der Liste ist bzw auf dieser Route vorhanden ist
        if (monsterAufDieserRoute.Count > 0)
        {
            //zufälliges Monster bestimmen mit Zufallsgenerator aus der vorherigen generierten Liste
            int anzahlDerMonsterInDerNeuenListe = monsterAufDieserRoute.Count;
            //hier reicht "nur" EIN Wert hinter der Next Methode, d.h. der Bereich geht von 0 bis automatisch zur maximalen Anzahl, exklusive der Höchstzahl. Das passt insofern, da der Index bei 0 anfängt und auch die letzte Stelle um 1 niedriger ist als die Gesamtanzahl in der Liste
            int zufaelligerIndex = zufallsgenerator.Next(anzahlDerMonsterInDerNeuenListe);
            Monster zufallsMonster = monsterAufDieserRoute[zufaelligerIndex];

            //zur nächsten Methode, was mit dem Monster gemacht wird
            if (MonsterInteraktion(zufallsMonster, userName, aktuellerStandort))
            {
                return true;
            }
        }
        else
        {
            Console.CursorVisible = false;
            Thread.Sleep(1000);
            Console.WriteLine("\nAuf dieser Route gibt es keine Monster.");
            Console.Write("\n\nDrücke eine Taste um zurückzukehren");
            Console.CursorVisible = true;
            Console.ReadKey();
        }
        return false;
    }

    //folgende Methoden werden innerhalb vorheriger Methoden aufgerufen

    static bool MonsterInteraktion(Monster zufallsMonsterAusRoute, string userName, int aktuellerStandort)
    {
        Console.WriteLine();
        VisuelleEffekte.AufzaehlendePunkteZufaelligeLaenge();
        VisuelleEffekte.StroboskopEffekt(11); //wenn langsamer dann nur 6 Durchläufe
        Console.CursorVisible = false;
        Thread.Sleep(1000);

        var gueltigeEingabe = true;

        while (true)
        {

            Console.WriteLine($"Ein wildes {zufallsMonsterAusRoute.Name} erscheint!\n");
            Console.WriteLine("Was möchtest du tun?");
            Console.WriteLine("\n[1] Kämpfen");
            Console.WriteLine("[2] Fangen");
            Console.WriteLine("[3] Flüchten");
            Console.WriteLine("\n[M]ENÜ");

            Console.Write(gueltigeEingabe ? "\n\nDeine Wahl: " : "\n\nUngültige Eingabe.\nBitte wiederholen: ");
            //verkürzte Variante einer if-else Anweisung, ? steht für die Bedingung, danach folgt wenn es true ist, und nach dem Doppelpunkt folgt wenn was false ist
            //aber eingeschränkt nutzbar


            Console.CursorVisible = true;
            var benutzerEingabe = Console.ReadLine();

            switch (benutzerEingabe?.ToUpper())
            {
                case "1":
                    //wechsle in Kampf Methode und nehme folgende Werte mit
                    Kampf(Team[0], zufallsMonsterAusRoute);
                    return false;
                case "2":
                    MonsterFangen(zufallsMonsterAusRoute, userName);
                    return false;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Du bist geflohen!");
                    Console.Write("\nDrücke eine Taste"); //habe mich gegen Thread.Sleep() entschieden, sonst ist es entweder zu schnell oder zu langsam weg, lieber manuell fortsetzen
                    Console.CursorVisible = true;
                    Console.ReadKey();
                    return false;
                case "M":
                    if (Menue(userName, aktuellerStandort))
                    {
                        return true;
                    }
                    Console.Clear();
                    break;

                default:
                    Console.Clear();
                    gueltigeEingabe = false;
                    break; //hier auch, endet nur die switch, daher passt das hier in diesem Fall
            }
        }
    }

    //ich übergebe die Werte vom Monster vom Team vom User an der ersten Stelle (s. oben mit index 0) welches jetzt als userMonster den Kampf antritt und das zufallsMonster ist unser gegnerMonster jetzt
    //ein paar Sachen hier noch auslagern auf jeden Fall
    static void Kampf(Monster userMonster, Monster gegnerMonster)
    {

        var attackenUserMonster = userMonster.Attacken;
        var attackenGegnerMonster = gegnerMonster.Attacken;

        //Kraftpunkte der Monster vorher speichern da nach dem Kampf wieder KP voll sein sollen (da ich (noch?) kein PokemonCenter oder Items habe)
        var userMonsterAusgangsKP = userMonster.Kraftpunkte;
        var gegnerMonsterAusgangsKP = gegnerMonster.Kraftpunkte;

        Console.CursorVisible = false;

        KraftpunkteAnzeigenLassen(gegnerMonster, userMonster, string.Empty);


        //evtl Menü rein? z.b. monster wechseln, und von da zurück option, dann genau zu dem stand zurück wo man war
        //und sonst auch zurück option von kampf wenn man doch fangen/flüchten will
        //wenn hier gefangen oder geflohen, dann Kraftpunkte zurücksetzen nicht vergessen!

        //Konsoleninhalt nochmal ausgegeben mit Satz in der Mitte
        Thread.Sleep(1250);

        KraftpunkteAnzeigenLassen(gegnerMonster, userMonster, "Der Kampf beginnt!");

        Console.WriteLine("\n\n");
        Thread.Sleep(1000);

        //Kampf geht nur solange beide Monster noch Kraftpunkte haben
        while (userMonster.Kraftpunkte > 0 && gegnerMonster.Kraftpunkte > 0)
        {

            AttackenAnzeigenLassen(attackenUserMonster);

            Console.Write("\nWähle eine Attacke: ");

            //Variable für Benutzereingabe wenn er eine Attacke auswählt
            int ausgewaehlterIndex;

            while (true)
            {
                Console.CursorVisible = true;
                if (int.TryParse(Console.ReadLine(), out ausgewaehlterIndex) && ausgewaehlterIndex >= 1 && ausgewaehlterIndex <= attackenUserMonster.Count)
                {
                    break;
                }
                else
                {
                    KraftpunkteAnzeigenLassen(gegnerMonster, userMonster, string.Empty);

                    Console.WriteLine("\n\n");

                    AttackenAnzeigenLassen(attackenUserMonster);

                    Console.Write("\nUngültige Eingabe. Bitte wiederholen: ");

                }
            }

            var ausgewaehlteAttacke = attackenUserMonster[ausgewaehlterIndex - 1];

            Console.CursorVisible = false;

            //Methode Angriff
            //dabei noch einen Parameter für das Monster, welches angreift, da sich das abwechselt
            Angriff(userMonster, gegnerMonster, userMonster, ausgewaehlteAttacke);

            //es wird geschaut wie viel Schadenspunkte es gibt in Abhängigkeit von den Typen der Attacke und des angegriffenen Monsters und auch ausgegeben wie effektiv diese Attacke war oder nicht oder nichts ausgegeben wenn es "neutral" ist
            var schadenAmGegner = Typ.EffektivitaetUndSchaden(ausgewaehlteAttacke.Typ.Name, gegnerMonster.Typ.Name);
            Console.WriteLine();
            //diese werden dann von den Kraftpunkten abgezogen
            gegnerMonster.Kraftpunkte -= schadenAmGegner;

            //Bild 6, Effektivität der Attacke wird ausgegeben
            Thread.Sleep(1000);
            KraftpunkteAnzeigenLassen(gegnerMonster, userMonster, Schaden(schadenAmGegner));

            //wenn Gegner besiegt wurde
            if (gegnerMonster.Kraftpunkte <= 0)
            {
                //da ich keine Minuszahlen will
                gegnerMonster.Kraftpunkte = 0;

                Console.CursorVisible = false;
                Thread.Sleep(1000);
                Console.WriteLine($"\n\n{gegnerMonster.Name} wurde besiegt!");
                zaehlerGewonnen++;
                //level up?
                //Attacken erlernen?

                //Kraftpunkte nach Kampf wieder zurücksetzen
                userMonster.Kraftpunkte = userMonsterAusgangsKP;
                gegnerMonster.Kraftpunkte = gegnerMonsterAusgangsKP;

                break;
            }

            Console.Write("\n\n\nDrücke eine Taste");
            Console.CursorVisible = true;
            Console.ReadKey();


            ////////////////////////////////////////////umgekehrt jetzt bzw Gegner greift an
            

            //Attacke vom Gegner wird per Zufall auswählen
            Attacke gegnerAttacke = attackenGegnerMonster[zufallsgenerator.Next(attackenGegnerMonster.Count)];

            //hier ist der Parameter für das angreifende Monster und die Attacke jetzt vom Gegner
            Angriff(userMonster, gegnerMonster, gegnerMonster, gegnerAttacke);

            //Schaden am eigenen Monster und Effektivitätausgabe
            int schadenAmEigenenMonster = Typ.EffektivitaetUndSchaden(gegnerAttacke.Typ.Name, userMonster.Typ.Name);
            //Abzug der Kraftpunkte des eigenen Monsters
            userMonster.Kraftpunkte -= schadenAmEigenenMonster;

            Thread.Sleep(1000);

            KraftpunkteAnzeigenLassen(gegnerMonster, userMonster, Schaden(schadenAmEigenenMonster));

            //wenn User besiegt wurde
            if (userMonster.Kraftpunkte <= 0)
            {
                userMonster.Kraftpunkte = 0;

                Console.CursorVisible = false;
                Thread.Sleep(1000);
                Console.WriteLine($"\n\n{userMonster.Name} wurde besiegt!");
                zaehlerVerloren++;
                userMonster.Kraftpunkte = userMonsterAusgangsKP;
                gegnerMonster.Kraftpunkte = gegnerMonsterAusgangsKP;

                break;
            }
            //jetzt fängt es wieder von vorne an bzw der User darf dann wieder eine Attacke auswählen
            Thread.Sleep(1000);
            Console.WriteLine("\n\n");
        }

        //ich kann auch hier schreiben wenn das userMonster besiegt worden ist, da man die Schleife sowieso nicht mehr betreten würde, da ja eines der Monster 0 KP hat, beim anderen muss ich es nach dem Angriff machen, sonst greift es an obwohl es das nicht mehr dürfte
        Console.Write("\n\n\nDrücke eine Taste");
        Console.CursorVisible = true;
        Console.ReadKey();
    }

    static void AttackenAnzeigenLassen(List<Attacke> attackenUserMonster)
    {
        foreach (var attacke in attackenUserMonster)
        {
            Console.WriteLine($"[{attackenUserMonster.IndexOf(attacke) + 1}] {attacke.Name} (Typ: {attacke.Typ.Name})");
        }
    }

    static void KraftpunkteAnzeigenLassen(Monster gegnerMonster, Monster userMonster, string kampfinfo)
    {
        Console.Clear();

        Console.Write($"{gegnerMonster.Name} (Typ: {gegnerMonster.Typ.Name}) Kraftpunkte:");
        VisuelleEffekte.Kraftpunkte(gegnerMonster.Kraftpunkte);
        Console.WriteLine($"\n\n{kampfinfo}");
        Console.Write($"\n{userMonster.Name} (Typ: {userMonster.Typ.Name}) Kraftpunkte:");
        VisuelleEffekte.Kraftpunkte(userMonster.Kraftpunkte);
    }

    static void Angriff(Monster userMonster, Monster gegnerMonster, Monster angreifendesMonster, Attacke angreifendeAttacke)
    {
        //das sieht jetzt sehr repetitiv aus, aber nur weil ich einen optischen Effekt erreichen wollte. Da die Konsole nur nacheinander Zeilen darstellen kann, ich aber eine Zeile mittendrin "aktualisieren" möchte, muss ich also den kompletten Konsoleninhalt löschen und nochmal neu ausgeben lassen aber mit dieser einen Änderung/Aktualisierung. Methode ginge leider nur bedingt da ja jedes "Bild" anders aussieht
        //Bild 1, mittlere Zeile ist leer
        Console.CursorVisible = false;

        Thread.Sleep(1000);
        KraftpunkteAnzeigenLassen(gegnerMonster, userMonster, string.Empty);

        var angriffText = $"{angreifendesMonster.Name} setzt {angreifendeAttacke.Name} ein!";

        //Bild 2, Monster setzt Attacke ein
        Thread.Sleep(1000);
        KraftpunkteAnzeigenLassen(gegnerMonster, userMonster, angriffText);

        //Bild 3, ein Punktzeichen
        Thread.Sleep(500);
        KraftpunkteAnzeigenLassen(gegnerMonster, userMonster, angriffText + " .");

        //Bild 4, zwei Punktzeichen
        Thread.Sleep(500);
        KraftpunkteAnzeigenLassen(gegnerMonster, userMonster, angriffText + " . .");

        //Bild 5, drei Punktzeichen
        Thread.Sleep(500);
        KraftpunkteAnzeigenLassen(gegnerMonster, userMonster, angriffText + " . . .");
    }
    static string Schaden(int schaden)
    {
        //wenn die KP weniger haben als abgezogen werden, dann stimmt die Ausgabe nicht ganz, aber ich belasse es dabei
        if (schaden == 1)
        {
            return $" . . . es wurde {schaden} KP abgezogen! Die Attacke ist nicht sehr effektiv . . .";
        }
        else if (schaden == 2)
        {
            return $" . . . es wurden {schaden} KP abgezogen!";

        }
        //wenn schaden ist 3
        return $" . . . es wurde {schaden} KP abgezogen! Die Attacke ist sehr effektiv!";
    }

    static void MonsterFangen(Monster zufallsMonsterFangen, string userName)
    {

        //50%ige Chance dass das Monster beim ersten Versuch gefangen wird
        int erfolgschance = 50;

        while(true)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Thread.Sleep(1000);
            Console.WriteLine("*Wirft Pokeball*");
            Console.WriteLine();
            VisuelleEffekte.AufzaehlendePunkteZufaelligeLaenge();


            //wir haben einen Zahlenbereich von 1-100 (da 101 ausgeschlossen). Wenn wir jetzt eine Bedingung machen, wo das Monster nur bei 50%iger Wahrscheinlichkeit gefangen werden soll, dann können wir sagen, wir akzeptieren nur die Hälfte aller Zahlen (z.B. mit <=50), das wären dann 50 von 100, bzw 50/100 bzw 50 Hundertstel = 50%. (75 von 100 dann 75% usw usw)
            int zufallszahl = zufallsgenerator.Next(1, 101);

            if (zufallszahl <= erfolgschance)
            {
                Console.WriteLine($" {zufallsMonsterFangen.Name} wurde gefangen!\n");

                //wir fügen das gefangene Monster zu unserem Team hinzu
                Team.Add(zufallsMonsterFangen);

                Console.WriteLine($"{Team.Count} Monster von {AlleMonster.MonsterListe.Count} gefangen.\n");

                if (AlleMonsterGefangen())
                {
                    Console.CursorVisible = true;
                    Console.Write("\n\nDrücke eine Taste");
                    Console.ReadKey();
                    Console.CursorVisible = false;
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.WriteLine("Du hast ALLE Monster gefangen? ");
                    Thread.Sleep(1250);
                    Console.WriteLine("\nWow...nicht schlecht");
                    Thread.Sleep(1250);
                    Console.WriteLine("\n...Hast du keine Hobbies oder so? XD");
                    Thread.Sleep(1500);
                    Console.WriteLine("\nSpaß beiseite! Hier eine Belohnung für dich!");
                    Thread.Sleep(1000);
                    Console.Write("\n\nDrücke eine Taste, Tipp: Fenster auf Vollbild machen: ");
                    Console.CursorVisible = true;
                    Console.ReadKey();
                    Console.CursorVisible = false;
                    Console.Clear();
                    Thread.Sleep(1000);
                    VisuelleEffekte.BelohnungASCII();
                    Thread.Sleep(1000);
                    Console.WriteLine("\n\n\nGut gemacht! Professor Eich wäre Stolz auf dich!");
                    Thread.Sleep(1000);
                    Console.Write("\n\nDrücke eine Taste");
                    Console.CursorVisible = true;
                    Console.ReadKey();
                    Console.CursorVisible = false;
                    Console.Clear();

                    DeinTeamNacheinanderAbspielend();
                    Console.WriteLine();
                    Console.WriteLine("DEINE STATISTIK");
                    Console.WriteLine($"Spielername:\t\t{userName}");
                    MenueDaten();
                    Console.Write("\n\nDrücke eine Taste");
                    Console.CursorVisible = true;
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("\n[T]EAM\t\t[ENTER] Zurück");
                Console.Write("\nDeine Wahl: ");
                while(true)
                {
                    Console.CursorVisible = true;
                    var benutzerEingabe = Console.ReadLine()?.ToUpper();
                    if (benutzerEingabe == "T")
                    {
                        Console.Clear();
                        TeamAnschauen();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(benutzerEingabe))
                    {
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nUngültige Eingabe!\n\n");
                        Console.WriteLine($"{Team.Count} Monster von {AlleMonster.MonsterListe.Count} gefangen.\n");
                        Console.WriteLine("\n[T]EAM\t\t[ENTER] Zurück");
                        Console.Write("\nBitte wiederhole: ");
                    }
                }

            }
            else
            {
                Console.WriteLine($" {zufallsMonsterFangen.Name} hat sich befreit!");
                Console.WriteLine("\nMöchtest du es nochmal probieren?");
                Console.WriteLine("\n[1] JA\n[2] NEIN");
                //Console.WriteLine("\n[K]ampf starten stattdessen");
                //menü auch hier ergänzen? dann parameter username und standort übergeben
                Console.Write("\nDeine Wahl: ");

                do
                {
                    Console.CursorVisible = true;
                    var benutzerEingabe = Console.ReadLine()?.ToUpper();

                    if (benutzerEingabe == "N" || benutzerEingabe == "NEIN" || benutzerEingabe == "2")
                    {
                        Console.Clear();
                        Console.WriteLine($"{zufallsMonsterFangen.Name} ist geflohen!");
                        Console.Write("\nDrücke eine Taste");
                        Console.CursorVisible = true;
                        Console.ReadKey();
                        return;
                    }
                    else if (benutzerEingabe == "J" || benutzerEingabe == "JA" || benutzerEingabe == "1")
                    {
                        break; // Raus aus der do-while-Schleife
                    }
                    //else if (benutzerEingabe.ToUpper() == "K")
                    //{
                    //    Kampf(Team[0], zufallsMonsterFangen, userName, aktuellerStandort);
                    //    //und was wenn ich zurück aus Kampf will und doch fangen?
                    //}

                    Console.Clear();
                    Console.WriteLine("Eingabe nicht erkannt.");
                    Console.WriteLine($"\nMöchtest du {zufallsMonsterFangen.Name} fangen?");
                    Console.WriteLine("\n[1] JA\n[2] NEIN");
                    //Console.WriteLine("\n[K]ampf starten stattdessen");
                    Console.Write("\n\nWähle: ");
                }
                while (true);

                //+15% höhere Chance pro Versuch=
                //1. Versuch 40%
                //2. Versuch 55%
                //3. Versuch 70%
                //4. Versuch 85%
                //5. Versuch 100 (spätestens beim 5. mal klappt es sicher)
                //eventuell schon bei 3 Versuchen fangbar machen?
                //von 40 zu 70 zu 100? mit je +30%
                //oder 50 zu 75 zu 100? mit +25% pro versuch
                erfolgschance += 25; //verkürzte Schreibweise für erfolgschance = erfolgschance + 25
                //derselbe Wert wird genommen und damit verrechnet (Zusammengesetzte Zuweisung = Compound Assignment)
            }
        }
    }

    //diese Methode ist eventuell nur vorübergehend bis ich das Problem mit doppelten Monstern gelöst habe
    static bool AlleMonsterGefangen()
    {
        //wir gehen durch die ganze MonsterListe durch und schauen ob die Monster in unserem Team sind
        foreach (var monster in AlleMonster.MonsterListe)
        {
            if (!Team.Contains(monster))
            {
                //wenn ein Monster nicht im Team ist dann gehen wir aus der Methode raus und geben false zurück
                return false;
            }
        }

        //ansonsten wenn wir nicht vorzeitig mit false rausgehen dann haben wir alle Monster und wir geben true zurück
        return true;
    }

    static bool Menue(string userName, int aktuellerStandort)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("INFO");
            Console.WriteLine($"Spielername:\t\t{userName}");

            MenueDaten();
            Console.WriteLine("\n[T]EAM\t[K]ARTE");
            Console.WriteLine("\n\n[ENTER] Zurück\t\t[S]piel beenden");
            Console.Write("\n\nDeine Wahl: ");

            while (true)
            {
                Console.CursorVisible = true;
                var benutzerEingabe = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(benutzerEingabe))
                {
                    return false; //raus aus der Methode aber Spiel wird nicht beendet, also nur zurück zur Routenauswahl
                }
                else if (benutzerEingabe.ToUpper() == "T")
                {
                    Console.Clear();
                    TeamAnschauen();
                    Console.CursorVisible = true;
                    break;
                }
                else if (benutzerEingabe.ToUpper() == "K")
                {
                    KarteAnschauen(aktuellerStandort);
                    break;
                }
                else if (benutzerEingabe.ToUpper() == "S")
                {
                    Console.Clear();
                    return SpielBeenden(); //also je nach dem true oder false
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("INFO");
                    Console.WriteLine($"Spielername:\t\t{userName}");
                    MenueDaten();
                    Console.WriteLine("\n[T]EAM\t[K]ARTE"); //[BEUTEL]
                    Console.WriteLine("\n\n[ENTER] Zurück\t\t[S]piel beenden");
                    Console.WriteLine("\n\nUngültige Eingabe.");
                    Console.Write("Eingabe wiederholen: ");
                }
            }
        }
    }
    static void MenueDaten()
    {
        Console.WriteLine($"Gefangene Monster:\t{Team.Count} von 71");
        Console.WriteLine($"Kämpfe gewonnen:\t{zaehlerGewonnen}");
        Console.WriteLine($"Kämpfe verloren:\t{zaehlerVerloren}");
        Console.WriteLine($"Spielzeit:\t\t{spielzeitStoppuhr.Elapsed.Hours:D2} Std : {spielzeitStoppuhr.Elapsed.Minutes:D2} Min : {spielzeitStoppuhr.Elapsed.Seconds:D2} Sek");
        //Console.WriteLine($"Orden:\t\t{anzahlOrden}");
        //Console.WriteLine($"Geld:\t\t{geld} Pokedollar");
    }

    static bool SpielBeenden()
    {
        Console.CursorVisible = false;
        Thread.Sleep(1000);
        Console.WriteLine("Bist du dir sicher?");
        Thread.Sleep(1250);
        Console.WriteLine("\n[J]A\t[N]EIN");
        Console.Write("\nDeine Wahl: ");

        while (true)
        {
            Console.CursorVisible = true;
            var benutzerEingabe = Console.ReadLine()?.ToUpper();

            if (benutzerEingabe == "J" || benutzerEingabe == "JA")
            {
                Console.CursorVisible = false;
                Console.Clear();
                Thread.Sleep(750);
                Console.WriteLine("Ganz ganz sicher?");
                Thread.Sleep(1250);
                Console.WriteLine("\n[J]A\t[N]EIN");
                Console.Write("\nDeine Wahl: ");

                while(true)
                {
                    Console.CursorVisible = true;
                    benutzerEingabe = Console.ReadLine()?.ToUpper();

                    if (benutzerEingabe == "J" || benutzerEingabe == "JA")
                    {
                        Console.CursorVisible = false;
                        Console.Clear();
                        Thread.Sleep(1250);
                        Console.Write("Schwach");
                        Thread.Sleep(750);
                        VisuelleEffekte.AufzaehlendePunkte(3);
                        Thread.Sleep(750);
                        Console.WriteLine("\nNein Spaß :P");
                        Thread.Sleep(1250);
                        Console.WriteLine("\nDanke für's Spielen!");
                        Console.WriteLine("Bis zum nächsten Mal! Byeeeeee");
                        Thread.Sleep(1250);
                        Console.WriteLine("\n\nDEINE STATISTIK");
                        MenueDaten();
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
                        return true; //hier gebe ich den Wert true an Menue zurück wenn man das Spiel beenden will den wir für die StandortBestimmen Methode brauchen um da rauszukommen
                    }
                    if (benutzerEingabe == "N" || benutzerEingabe == "NEIN")
                    {
                        break; //hier springen wir zum nächsten if, damit das "N"/"NEIN" dort genommen wird, dann spare ich mir das doppelt zu schreiben
                    }

                    Console.Clear();
                    Console.WriteLine("Ganz ganz sicher?");
                    Console.WriteLine("\n[J]A\t[N]EIN");
                    Console.Write("\nEingabe nicht erkannt, bitte wiederholen: ");
                    
                }
            }
            if (benutzerEingabe == "N" || benutzerEingabe == "NEIN") //hier muss ein if statt else if sonst kommen wir hier nicht rein, weil ich möchte von dem oberen break hier reingehen
            {
                Console.CursorVisible = false;
                Console.Clear();
                Thread.Sleep(500);
                Console.WriteLine("Gut, dann spielen wir weiter! B-)");
                Console.Write("\n\nDrücke eine Taste");
                Console.CursorVisible = true;
                Console.ReadKey();
                return false;
            }
           
            Console.Clear();
            Console.WriteLine("Bist du dir sicher?");
            Console.WriteLine("\n[J]A\t[N]EIN");
            Console.Write("\nEingabe nicht erkannt, bitte wiederholen: ");
        }
    }

    static void TeamAnschauen()
    {
        while (true)
        {
            bool aeußereSchleifeVerlassen = false;
            DeinTeam();
            Console.WriteLine("\n\n[A]ktives Monster tauschen\t[F]reilassen");
            Console.WriteLine("\n[ENTER] Zurück");
            Console.Write("\nDeine Wahl: ");
            while(!aeußereSchleifeVerlassen)
            {
                var benutzerEingabe = Console.ReadLine();

                if (benutzerEingabe?.ToUpper() == "A")
                {
                    if (Team.Count > 1)
                    {
                        Console.Clear();
                        DeinTeam();
                        Console.WriteLine("\n\n\n\n[ENTER] Zurück");
                        Console.Write("\nGib die aktuelle Position des Monsters ein, welches du an die erste Stelle zu setzen möchtest (oder gehe zurück): ");

                        while (true)
                        {
                            Console.CursorVisible = true;
                            benutzerEingabe = Console.ReadLine(); //wird neu zugewiesen

                            //Variable gleicher Name aber in der if drin, also nicht betroffen davon
                            if (benutzerEingabe == "1")
                            {
                                Console.Clear();

                                DeinTeam();
                                Console.WriteLine("\n\n\n\n[ENTER] Zurück");
                                Console.WriteLine($"\n{Team[0].Name} ist schon auf Position 1 ;)");
                                Console.Write("\nGib die aktuelle Position des Monsters ein, welches du an die erste Stelle zu setzen möchtest (oder gehe zurück): ");
                            }
                            else if (int.TryParse(benutzerEingabe, out int zahlEingabe) && (zahlEingabe - 1) >= 0 && (zahlEingabe - 1) < Team.Count)
                            {
                                //Monster wird zuerst zwischengespeichert
                                Monster zuBewegendesMonster = Team[zahlEingabe - 1];
                                //dann wird es entfernt
                                Team.RemoveAt(zahlEingabe - 1);
                                //und das gespeicherte Monster an die Stelle gebracht           
                                Team.Insert(0, zuBewegendesMonster);

                                Console.Clear();
                                DeinTeam();
                                Console.WriteLine($"\n{zuBewegendesMonster.Name} wurde an die erste Stelle verschoben!");
                                Console.WriteLine("\n\n[ENTER] Zurück");
                                Console.Write("\nGib die aktuelle Position des Monsters ein, welches du an die erste Stelle zu setzen möchtest (oder gehe zurück): ");
                                //evtl auch die Endposition bestimmen können? Dann halt noch eine dritte Eingabe
                            }
                            else if (string.IsNullOrWhiteSpace(benutzerEingabe))
                            {
                                Console.Clear();
                                aeußereSchleifeVerlassen = true;
                                break;
                            }
                            else
                            {
                                Console.Clear();

                                DeinTeam();
                                Console.WriteLine("\n\n\n\n[ENTER] Zurück");
                                Console.Write("\nUngültige Eingabe. Bitte gib die aktuelle Position des Monsters ein, welches du an die erste Stelle zu setzen möchtest (oder gehe zurück): ");
                            }
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(benutzerEingabe))
                    {

                        Console.Clear();

                        DeinTeam();
                        Console.WriteLine("\n\n[A]ktives Monster tauschen\t[F]reilassen");
                        Console.WriteLine("\n[ENTER] Zurück");
                        Console.WriteLine("\nWas willst du da bitte tauschen xDDD");
                        Console.Write("\nDeine Wahl: ");
                    }
                }
                //user darf nicht sein letztes Monster freilassen da das nicht erlaubt ist im Spiel ;)
                else if (benutzerEingabe?.ToUpper() == "F")
                {
                    if (Team.Count > 1)
                    {
                        Console.Clear();

                        DeinTeam();
                        Console.WriteLine("\n\n\n\n[ENTER] Zurück");
                        Console.Write("\nGib die Position des Monsters ein, welches du freilassen möchtest (oder gehe zurück): ");

                        while (Team.Count > 1)
                        {
                            Console.CursorVisible = true;
                            benutzerEingabe = Console.ReadLine();

                            if (int.TryParse(benutzerEingabe, out int zahlEingabe) && (zahlEingabe - 1) >= 0 && (zahlEingabe - 1) < Team.Count)
                            {
                                Monster freigelassenesMonster = Team[zahlEingabe - 1];
                                Team.RemoveAt(zahlEingabe - 1);

                                if (Team.Count > 1)
                                {
                                    Console.Clear();

                                    DeinTeam();
                                    Console.WriteLine($"\n{freigelassenesMonster.Name} wurde freigelassen!");
                                    Console.WriteLine("\n\n[ENTER] Zurück");
                                    Console.Write("\nGib die Position des Monsters ein, welches du freilassen möchtest (oder gehe zurück): ");
                                    //evtl. auch Anzahl eingeben können von einer Gruppe?

                                }
                                else
                                {
                                    aeußereSchleifeVerlassen = true;
                                    Console.Clear();

                                    DeinTeam();
                                    Console.WriteLine($"\n{freigelassenesMonster.Name} wurde freigelassen!");
                                    Console.Write("\n\n\nDrücke eine Taste um zurückzukehren");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else if (string.IsNullOrWhiteSpace(benutzerEingabe))
                            {
                                Console.Clear();
                                aeußereSchleifeVerlassen = true;
                                break;
                            }
                            else
                            {
                                Console.Clear();

                                DeinTeam();
                                Console.WriteLine("\n\n\n\n[ENTER] Zurück");
                                Console.Write("\nUngültige Eingabe. Bitte gib die Position des Monsters ein, welches du freilassen möchtest (oder gehe zurück): ");
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        DeinTeam();
                        Console.WriteLine("\n\n[A]ktives Monster tauschen\t[F]reilassen");
                        Console.WriteLine("\n[ENTER] Zurück");
                        Console.WriteLine("\nDu darfst nicht 0 Monster haben!");
                        Console.Write("\nDeine Wahl: ");
                    }
                }
                else if (string.IsNullOrWhiteSpace(benutzerEingabe))
                {
                    return;
                }
                else
                {
                    Console.Clear();

                    DeinTeam();
                    Console.WriteLine("\n\n[A]ktives Monster tauschen\t[F]reilassen");
                    Console.WriteLine("\n[ENTER] Zurück");
                    Console.Write("\nUngültige Eingabe. Bitte wiederholen: ");
                }
            }
        }
    }

    static void DeinTeam()
    {
        Console.WriteLine("Dein Team:");

        //gefangene Monster bzw Monster aus dem Team ausgeben lassen, dabei gebe ich keine doppelten Monster aus sondern lasse sie gruppieren und gebe jeweils ein Monster aus und jeweils die Anzahl davon
        var gruppierteMonster = Team.GroupBy(monster => monster.Name);
        int position = 1;

        foreach (var monsterGruppe in gruppierteMonster)
        {
            foreach (var monster in monsterGruppe)
            {
                Console.CursorVisible = false;
                Console.CursorVisible = true;
                Console.WriteLine($"{position}. {monsterGruppe.Count()}x {monster.Name} (Typ: {monster.Typ.Name})");
                position++;
                //Kraftpunkte und Attacken auch anzeigen lassen?
                //dann Möglichkeit Attacken zu erlernen oder zu entfernen? Dann aber Items dazu
            }
        }
    }

    static void DeinTeamNacheinanderAbspielend()
    {
        Console.WriteLine("Deine gefangenen Monster:");

        var gruppierteMonster = Team.GroupBy(monster => monster.Name);
        int position = 1;

        foreach (var monsterGruppe in gruppierteMonster)
        {
            foreach (var monster in monsterGruppe)
            {
                Console.CursorVisible = false;
                Thread.Sleep(20);
                Console.CursorVisible = true;
                Console.WriteLine($"{position}. {monsterGruppe.Count()}x {monster.Name} (Typ: {monster.Typ.Name})");
                position++;
            }
        }
    }

    static void KarteAnschauen(int aktuellerStandort)
    {
        Console.Clear();
        Console.WriteLine($"Dein aktueller Standort: Route {aktuellerStandort}");
        Console.CursorVisible = true;

        switch (aktuellerStandort)
        {
            case 0:
                Karte.Route0();
                break;
            case 1:
                Karte.Route1();
                break;
            case 2:
                Karte.Route2();
                break;
            case 3:
                Karte.Route3();
                break;
            case 4:
                Karte.Route4();
                break;
            case 5:
                Karte.Route5();
                break;
            case 6:
                Karte.Route6();
                break;
            case 7:
                Karte.Route7();
                break;
            case 8:
                Karte.Route8();
                break;
            case 9:
                Karte.Route9();
                break;
            case 10:
                Karte.Route10();
                break;
            case 11:
                Karte.Route11();
                break;
            case 12:
                Karte.Route12();
                break;
            case 13:
                Karte.Route13();
                break;
            default:
                Console.WriteLine("Ungültiger Standort.");
                break;
        }
        Console.Write("\nDrücke eine Taste um zurückzukehren");
        Console.ReadKey();
    }

}

//TO DO's:
//Level ups ermöglichen? nach 1 Kampf +1 lvl, dann erst nach 2 kämpfen +1 etc, open end?
//Entwicklungen durch Level erreichen und Entwicklungssteinen?
//Items auf Routen sammeln und in einem Beutel?
//Kraftpunkte nicht resetten und PokemonCenter und Shop mit Trank usw erstellen?
//verschiedene Trainer zusätzlich auf Routen die man immer wieder bekämpfen kann
//nach jedem Gewinn Geld erhöhen?
//wenn alle Orden, dann Meldung zum Pokemonmeister (vereinfacht)
//Pokedex mit Monster und ihren Standorten?

//Trainer Klasse mit Name, Monster, Standort
//AlleTrainer Klasse für Trainer Liste
//Item Klasse mit Name, Standort und spezielle Eigenschaft?
//AlleItems Klasse für Items Liste
//nicht alle Items aber evtl Trank, Pokebälle, Sonderbonbons, Entwicklungssteine?, Nuggets wenn ich n Shop habe?

//Spielstand speichern können?