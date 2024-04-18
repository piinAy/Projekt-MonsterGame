using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel
{
    public class VisuelleEffekte
    {
        public static void StroboskopEffekt(int anzahlFlackern)
        {
            Console.CursorVisible = false;

            for (int i = 0; i < anzahlFlackern; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Thread.Sleep(1); //eher 100 wenn man empfindlich ist?

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Thread.Sleep(1);
            }
        }

        public static void AufzaehlendePunkte(int anzahlPunkte)
        {
            Console.CursorVisible = false;

            for (int i = 0; i < anzahlPunkte; i++)
            {
                Thread.Sleep(200);
                Console.Write(" .");
                Thread.Sleep(200);
            }
        }     

        public static void AufzaehlendePunkteZufaelligeLaenge()
        {
            Console.CursorVisible = false;

            Random zufallsgenerator = new Random();
            int anzahlPunkte = zufallsgenerator.Next(3, 13);

            for (int i = 0; i < anzahlPunkte; i++)
            {
                Thread.Sleep(200);
                Console.Write(" .");
                Thread.Sleep(200);
            }      
        }

        public static void Kraftpunkte(int kraftpunkte)
        {
            for (int i = 0; i < kraftpunkte; i++)
            {
                Console.Write(" ■");
            }
        }

        public static void PokemonSchriftzug(int durchläufe)
        {
            Console.CursorVisible = false;
            Console.Clear();

            Thread.Sleep(500);
            Console.WriteLine();

            //Zeile für Zeile angezeigt
            Console.WriteLine("                                   ,'\\");
            Thread.Sleep(25);
            Console.WriteLine("     _.----.        ____         ,'  _\\   ___    ___     ____");
            Thread.Sleep(25);
            Console.WriteLine(" _,-'       `.     |    |  /`.   \\,-'    |   \\  /   |   |    \\  |`.");
            Thread.Sleep(25);
            Console.WriteLine(" \\      __    \\    '-.  | /   `.  ___    |    \\/    |   '-.   \\ |  |");
            Thread.Sleep(25);
            Console.WriteLine("  \\.    \\ \\   |  __  |  |/    ,','_  `.  |          | __  |    \\|  |");
            Thread.Sleep(25);
            Console.WriteLine("    \\    \\/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |");
            Thread.Sleep(25);
            Console.WriteLine("     \\     ,-'/  /   \\    ,'   | \\/ / ,`.|         /  /   \\  |     |");
            Thread.Sleep(25);
            Console.WriteLine("      \\    \\ |   \\_/  |   `-.  \\    `'  /|  |    ||   \\_/  | |\\    |");
            Thread.Sleep(25);
            Console.WriteLine("       \\    \\ \\      /       `-.`.___,-' |  |\\  /| \\      /  | |   |");
            Thread.Sleep(25);
            Console.WriteLine("        \\    \\ `.__,'|  |`-._    `|      |__| \\/ |  `.__,'|  | |   |");
            Thread.Sleep(25);
            Console.WriteLine("         \\_.-'       |__|    `-._ |              '-.|     '-.| |   |");
            Thread.Sleep(25);
            Console.WriteLine("                                 `'                            '-._|");
            Thread.Sleep(100);

            //dann komplett zeigend aber mehrmals für einen blinkenden Effekt
            for (int i = 0; i < durchläufe; i++)
            {
                Console.Clear();
                Thread.Sleep(100);

                Console.WriteLine();

                Console.WriteLine("                                   ,'\\");
                Console.WriteLine("     _.----.        ____         ,'  _\\   ___    ___     ____");
                Console.WriteLine(" _,-'       `.     |    |  /`.   \\,-'    |   \\  /   |   |    \\  |`.");
                Console.WriteLine(" \\      __    \\    '-.  | /   `.  ___    |    \\/    |   '-.   \\ |  |");
                Console.WriteLine("  \\.    \\ \\   |  __  |  |/    ,','_  `.  |          | __  |    \\|  |");
                Console.WriteLine("    \\    \\/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |");
                Console.WriteLine("     \\     ,-'/  /   \\    ,'   | \\/ / ,`.|         /  /   \\  |     |");
                Console.WriteLine("      \\    \\ |   \\_/  |   `-.  \\    `'  /|  |    ||   \\_/  | |\\    |");
                Console.WriteLine("       \\    \\ \\      /       `-.`.___,-' |  |\\  /| \\      /  | |   |");
                Console.WriteLine("        \\    \\ `.__,'|  |`-._    `|      |__| \\/ |  `.__,'|  | |   |");
                Console.WriteLine("         \\_.-'       |__|    `-._ |              '-.|     '-.| |   |");
                Console.WriteLine("                                 `'                            '-._|");

                Thread.Sleep(100);

            }
        }

        //kann auch alles in eine Zeile statt Zeile für Zeile (\r\n machen dann die Absätze)
        //dann sieht man's nicht direkt :P (wenn man es nicht rauskopiert! haha)
        //public static void BelohnungASCII()
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("                 .\"-,.__\r\n                 `.     `.  ,\r\n              .--'  .._,'\"-' `.\r\n             .    .'         `'\r\n             `.   /          ,'\r\n               `  '--.   ,-\"'\r\n                `\"`   |  \\\r\n                   -. \\, |\r\n                    `--Y.'      ___.\r\n                         \\     L._, \\\r\n               _.,        `.   <  <\\                _\r\n             ,' '           `, `.   | \\            ( `\r\n          ../, `.            `  |    .\\`.           \\ \\_\r\n         ,' ,..  .           _.,'    ||\\l            )  '\".\r\n        , ,'   \\           ,'.-.`-._,'  |           .  _._`.\r\n      ,' /      \\ \\        `' ' `--/   | \\          / /   ..\\\r\n    .'  /        \\ .         |\\__ - _ ,'` `        / /     `.`.\r\n    |  '          ..         `-...-\"  |  `-'      / /        . `.\r\n    | /           |L__           |    |          / /          `. `.\r\n   , /            .   .          |    |         / /             ` `\r\n  / /          ,. ,`._ `-_       |    |  _   ,-' /               ` \\\r\n / .           \\\"`_/. `-_ \\_,.  ,'    +-' `-'  _,        ..,-.    \\`.\r\n.  '         .-f    ,'   `    '.       \\__.---'     _   .'   '     \\ \\\r\n' /          `.'    l     .' /          \\..      ,_|/   `.  ,'`     L`\r\n|'      _.-\"\"` `.    \\ _,'  `            \\ `.___`.'\"`-.  , |   |    | \\\r\n||    ,'      `. `.   '       _,...._        `  |    `/ '  |   '     .|\r\n||  ,'          `. ;.,.---' ,'       `.   `.. `-'  .-' /_ .'    ;_   ||\r\n|| '              V      / /           `   | `   ,'   ,' '.    !  `. ||\r\n||/            _,-------7 '              . |  `-'    l         /    `||\r\n. |          ,' .-   ,' ||               | .-.        `.      .'     ||\r\n `'        ,'    `\".'    |               |    `.        '. -.'       `'\r\n          /      ,'      |               |,'    \\-.._,.'/'\r\n          .     /        .               .       \\    .''\r\n        .`.    |         `.             /         :_,'.'\r\n          \\ `...\\   _     ,'-.        .'         /_.-'\r\n           `-.__ `,  `'   .  _.>----''.  _  __  /\r\n                .'        /\"'          |  \"'   '_\r\n               /_|.-'\\ ,\".             '.'`__'-( \\\r\n                 / ,\"'\"\\,'               `/  `-.|\" ");
        //    Console.ForegroundColor = ConsoleColor.Gray;
        //}


        //lieber doch Zeile für Zeile erscheinen lassen? käme besser
        //farbig machen? aber dann alles eine Farbe oder wirklich alles genau?
        //public static void BelohnungASCII()
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("                  .\"-,.__");
        //    Thread.Sleep(50);
        //    Console.Write("                  `.     `.  ,");
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine(",");
        //    Console.ForegroundColor = ConsoleColor.DarkRed;
        //    Thread.Sleep(50);
        //    Console.WriteLine("               .--'  .._,'\"-' `.");
        //    Thread.Sleep(50);
        //    Console.WriteLine("              .    .'         `'");
        //    Thread.Sleep(50);
        //    Console.WriteLine("              `.   /          ,'");
        //    Thread.Sleep(50);
        //    Console.WriteLine("                `  '--.   ,-\"'");
        //    Thread.Sleep(50);
        //    Console.WriteLine("                 `\"`   |  \\");
        //    Thread.Sleep(50);
        //    Console.WriteLine("                    -. \\, |");
        //    Thread.Sleep(50);
        //    Console.WriteLine("                     `--Y.'      ___.");
        //    Thread.Sleep(50);
        //    Console.WriteLine("                         \\     L._, \\");
        //    Thread.Sleep(50);
        //    Console.WriteLine("                _.,        `.   <  <\\                _");
        //    Thread.Sleep(50);
        //    Console.WriteLine("              ,' '           `, `.   | \\            ( `");
        //    Thread.Sleep(50);
        //    Console.WriteLine("           ../, `.            `  |    .\\`.           \\ \\_");
        //    Thread.Sleep(50);
        //    Console.WriteLine("          ,' ,..  .           _.,'    ||\\l            )  '\".");
        //    Thread.Sleep(50);
        //    Console.WriteLine("         , ,'   \\           ,'.-.`-._,'  |           .  _._`.");
        //    Thread.Sleep(50);
        //    Console.WriteLine("       ,' /      \\ \\        `' ' `--/   | \\          / /   ..\\");
        //    Thread.Sleep(50);
        //    Console.WriteLine("     .'  /        \\ .         |\\__ - _ ,'` `        / /     `.`.");
        //    Thread.Sleep(50);
        //    Console.WriteLine("     |  '          ..         `-...-\"  |  `-'      / /        . `.");
        //    Thread.Sleep(50);
        //    Console.WriteLine("     | /           |L__           |    |          / /          `. `.");
        //    Thread.Sleep(50);
        //    Console.WriteLine("    , /            .   .          |    |         / /             ` `");
        //    Thread.Sleep(50);
        //    Console.WriteLine("   / /          ,. ,`._ `-_       |    |  _   ,-' /               ` \\");
        //    Thread.Sleep(50);
        //    Console.WriteLine("  / .           \\\"`_/. `-_ \\_,.  ,'    +-' `-'  _,        ..,-.    \\`.");
        //    Thread.Sleep(50);
        //    Console.WriteLine(" .  '         .-f    ,'   `    '.       \\__.---'     _   .'   '     \\ \\");
        //    Thread.Sleep(50);
        //    Console.WriteLine(" ' /          `.'    l     .' /          \\..      ,_|/   `.  ,'`     L`");
        //    Thread.Sleep(50);
        //    Console.WriteLine(" |'      _.-\"\"` `.    \\ _,'  `            \\ `.___`.'\"`-.  , |   |    | \\");
        //    Thread.Sleep(50);
        //    Console.WriteLine(" ||    ,'      `. `.   '       _,...._        `  |    `/ '  |   '     .|");
        //    Thread.Sleep(50);
        //    Console.WriteLine(" ||  ,'          `. ;.,.---' ,'       `.   `.. `-'  .-' /_ .'    ;_   ||");
        //    Thread.Sleep(50);
        //    Console.WriteLine(" || '              V      / /           `   | `   ,'   ,' '.    !  `. ||");
        //    Thread.Sleep(50);
        //    Console.WriteLine(" ||/            _,-------7 '              . |  `-'    l         /    `||");
        //    Thread.Sleep(50);
        //    Console.WriteLine(" . |          ,' .-   ,' ||               | .-.        `.      .'     ||");
        //    Thread.Sleep(50);
        //    Console.WriteLine("  `'        ,'    `\".'    |               |    `.        '. -.'       `'");
        //    Thread.Sleep(50);
        //    Console.WriteLine("           /      ,'      |               |,'    \\-.._,.'/'");
        //    Thread.Sleep(50);
        //    Console.WriteLine("           .     /        .               .       \\    .''");
        //    Thread.Sleep(50);
        //    Console.WriteLine("         .`.    |         `.             /         :_,'.'");
        //    Thread.Sleep(50);
        //    Console.WriteLine("           \\ `...\\   _     ,'-.        .'         /_.-'");
        //    Thread.Sleep(50);
        //    Console.WriteLine("            `-.__ `,  `'   .  _.>----''.  _  __  /");
        //    Thread.Sleep(50);
        //    Console.WriteLine("                 .'        /\"'          |  \"'   '_");
        //    Thread.Sleep(50);
        //    Console.WriteLine("                /_|.-'\\ ,\".             '.'`__'-( \\");
        //    Thread.Sleep(50);
        //    Console.WriteLine("                  / ,\"'\"\\,'               `/  `-.|\" ");
        //    Console.ForegroundColor = ConsoleColor.Gray;
        //}

        //finale Version
        public static void BelohnungASCII()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                  .\"-,.__");
            Thread.Sleep(50);
            Console.Write("                  `.     `.  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(",");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(50);
            Console.Write("               .--'  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(".._,'\"-' `.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(50);
            Console.Write("              .    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(".'         `'");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(50);
            Console.Write("              `.   ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("/          ,'");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(50);
            Console.Write("                `  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("'--.   ,-\"'");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(50);
            Console.Write("                 `\"`   ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|  \\");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(50);
            Console.Write("                    -. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\\, |");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(50);
            Console.Write("                     `--");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Y.'      ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("___.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(50);
            Console.Write("                         \\     ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("L");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(",");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" \\");
            Console.Write("                _.,");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(50);
            Console.Write("        `.   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("<  <");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\\                _");
            Thread.Sleep(50);
            Console.Write("              ,' '           ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("`, ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("`.   | \\            ( `");
            Thread.Sleep(50);
            Console.Write("           ../, `.            ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("`");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("  |    .");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("`.           \\ \\_");
            Thread.Sleep(50);
            Console.Write("          ,' ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(",..  ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(".           ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("_.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(",'    |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|\\");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("l            )  '\".");
            Thread.Sleep(50);
            Console.Write("         ,");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" ,'   \\           ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(",'.-.`-._");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(",'  |           .  ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("_._");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("`.");
            Thread.Sleep(50);
            Console.Write("       ,' ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("/      \\ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\\        ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("`' ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("'");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" `--");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("/   | \\          / ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("/   .");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(".\\");
            Thread.Sleep(50);
            Console.Write("     .'");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  /        \\");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" .         |\\__ - _ ,'` `        / ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("/     `.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("`.");
            Thread.Sleep(50);
            Console.Write("     |  ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("'          .");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(".         `-...-\"  |  `-'      /");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" /        . ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("`.");
            Thread.Sleep(50);
            Console.Write("     | ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("/           |");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("L__           |    |          /");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" /          `.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" `.");
            Thread.Sleep(50);
            Console.Write("    , ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("/            .   ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(".          |    |         / ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("/             ` ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("`");
            Thread.Sleep(50);
            Console.Write("   /");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" /          ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(",. ,");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("`._ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("`-_       |    |  _   ,-' ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("/               ` ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\\");
            Thread.Sleep(50);
            Console.Write("  / ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(".          ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" \\\"`_/");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" `-_");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" \\_,.  ,'    +-' `-'  ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("_,        ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("..,-.    ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("`.");
            Thread.Sleep(50);
            Console.Write(" .  ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("'         ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".-");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("f    ,'   ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("`    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("'.       \\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("__.---'     ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("   .'   '     ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" \\");
            Thread.Sleep(50);
            Console.Write(" '");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" /          ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("`.'   ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" l     .");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("' ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("/          \\..      ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(",");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|/   ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("`.  ,'`     ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("L");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("`");
            Thread.Sleep(50);
            Console.Write(" |");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("'      _.-\"\"`");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" `.    \\ _,'  `            \\ `.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("___");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("`.'\"");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("`");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("-.  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(", |   ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("|    ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\\");
            Thread.Sleep(50);
            Console.Write(" |");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("|    ,'      `. ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("`.   '       ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("_,...._        ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("`  |    ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("`/ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("'  |   ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("'     ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|");
            Thread.Sleep(50);
            Console.Write(" |");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("|  ,'          `. ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(";.,.---' ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(",'       `.   ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("`.. `-'  .-' ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/_ .'    ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(";");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("_   |");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|");
            Thread.Sleep(50);
            Console.Write(" |");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("| '              V      ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("/ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/           `   ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("| `   ,'   ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(",' '");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(".    !  ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("`. |");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|");
            Thread.Sleep(50);
            Console.Write(" |");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("|/            ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("_,-------7 ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("'              . ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("|  `-'    ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("l         /    ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("`|");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|");
            Thread.Sleep(50);
            Console.Write(" . |          ,' .-   ,' |");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|               | ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(".-.        ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("`.      .'     ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("||");
            Thread.Sleep(50);
            Console.Write("  `'        ,'    `\".'   ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" |               |    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("`.        '.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" -.'       ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("`'");
            Thread.Sleep(50);
            Console.Write("           /      ,'      ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|               |");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(",'    \\-.._,.'/");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("'");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(50);
            Console.Write("           .     /        ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(".               .      ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" \\    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(".''");
            Thread.Sleep(50);
            Console.Write("          `.    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("|         ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("`.             /         ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("_,'.'");
            Thread.Sleep(50);
            Console.Write("           \\ `...");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\\   _     ,");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("'-.        .'        ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" /");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("_.-'");
            Thread.Sleep(50);
            Console.Write("            `-.__ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("`,  `'   . ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" _.>----''");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(".  _  __  /");
            Thread.Sleep(50);
            Console.Write("                 .'        /");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\"'          ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("|  \"'   '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("_");
            Thread.Sleep(50);
            Console.Write("                /_|.-'\\ ,\".");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("             '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".'`");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("'-( \\");
            Thread.Sleep(50);
            Console.Write("                  / ,\"");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("'\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\\,'               `/  `-.|\" ");

            Console.ResetColor();
        }

        //oder von links nach rechts laufen lassen? aber dann voll der act, weil muss jede Spalte Schritt für Schritt ergänzen und zwischen jeder neuen Spalte die Konsole löschen da die Konsole nur von oben nach unten schreiben kann.

        //Test von links nach rechts
        //public static void Test()
        //{
        //    Console.CursorVisible = false;
        //    Console.WriteLine("T");
        //    Thread.Sleep(500);
        //    Console.Clear();
        //    Console.WriteLine("Te");
        //    Thread.Sleep(500);
        //    Console.Clear();
        //    Console.WriteLine("Tes");
        //    Thread.Sleep(500);
        //    Console.Clear();
        //    Console.WriteLine("Test");
        //}

    }
}

