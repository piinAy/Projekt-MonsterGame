using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Spiel
{
    public class Karte
    {
        //Fluss, Gras und anderes zu umständlich darzustellen
        //auf Städte verzichtet, nur Routen
        //public static void KarteBlanco()
        //{
        //    Console.WriteLine("┌─────────────────────────────┬─────┐");
        //    Console.WriteLine("│             10              │     │");
        //    Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
        //    Console.WriteLine("│     │         │     │       │  9  │");
        //    Console.WriteLine("│     │         │     │       │     │");
        //    Console.WriteLine("│     │         │     │       │     │");
        //    Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
        //    Console.WriteLine("│     │         │  2  │       │            8           │");
        //    Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
        //    Console.WriteLine("│     │         │     │                          │     │");
        //    Console.WriteLine("│     │         │     │                          │     │");
        //    Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
        //    Console.WriteLine("│     │    1    │  0  │     3     │     │        │  7  │");
        //    Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
        //    Console.WriteLine("│     │                           │  4  │        │     │");
        //    Console.WriteLine("│     │                           │     │        │     │");
        //    Console.WriteLine("│     │                           │     │        │     │");
        //    Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
        //    Console.WriteLine("│     │                  │     5     │        6        │");
        //    Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
        //    Console.WriteLine("│     │                  │     │");
        //    Console.WriteLine("│     │                  │     │");
        //    Console.WriteLine("│     │                  │  13 │");
        //    Console.WriteLine("├─────┴──────────────────┤     │");
        //    Console.WriteLine("│           12           │     │");
        //    Console.WriteLine("└────────────────────────┴─────┘");
        //}

        //5-6 Monster pro Route (Route 0 ausgeschlossen)
        //Route 0: keine Monster
        //Route 1: Glumanda, Pikachu, Nebulak, Taubsi, Bluzuk
        //Route 2: Bisasam, Enton, Evoli, Rattfratz, Seeper, Sleima
        //Route 3: Schiggy, Mauzi, Ponita, Habitak, Sandan
        //Route 4: Onix, Tangela, Quapsel, Fukano, Sterndu, Dodu
        //Route 5: Porygon, Nidoran (männlich), Pantimos, Kabuto, Flegmon
        //Route 6: Rihorn, Nidoran (weiblich), Kicklee, Tentacha, Goldini
        //Route 7: Magmar, Paras, Schlurp, Porenta, Magnetilo, Krabby
        //Route 8: Dratini, Raupy, Nockchan, Vulpix, Knofensa
        //Route 9: Sichlor, Pummeluff, Lapras, Menki, Digda, Tragosso
        //Route 10: Tauros, Rossana. Piepi, Amonitas, Myrapla
        //Route 11: Pinsir, Chaneira, Muschas, Machollo, Rettan, Jurob
        //Route 12: Kangama, Traumato, Owei, Relaxo, Kleinstein
        //Route 13: Elektek, Hornliu, Aerodactyl, Zubat, Smogon, Voltobal



        //Karten mit jeweils rot markiertem aktuellen Standort
        public static void Route0()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
            Console.WriteLine("│              10             │     │");
            Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
            Console.WriteLine("│     │         │     │       │  9  │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
            Console.WriteLine("│     │         │  2  │       │            8           │");
            Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");

            Console.Write("│     │    1    │  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("0");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("  │     3     │     │        │  7  │");

            Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
            Console.WriteLine("│     │                           │  4  │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
            Console.WriteLine("│     │                  │     5     │        6        │");
            Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │  13 │");
            Console.WriteLine("├─────┴──────────────────┤     │");
            Console.WriteLine("│           12           │     │");
            Console.WriteLine("└────────────────────────┴─────┘");
        }
        public static void Route1()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
            Console.WriteLine("│              10             │     │");
            Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
            Console.WriteLine("│     │         │     │       │  9  │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
            Console.WriteLine("│     │         │  2  │       │            8           │");
            Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
            Console.Write("│     │    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("    │  0  │     3     │     │        │  7  │");
            Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
            Console.WriteLine("│     │                           │  4  │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
            Console.WriteLine("│     │                  │     5     │        6        │");
            Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │  13 │");
            Console.WriteLine("├─────┴──────────────────┤     │");
            Console.WriteLine("│           12           │     │");
            Console.WriteLine("└────────────────────────┴─────┘");
        }

        public static void Route2()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
            Console.WriteLine("│              10             │     │");
            Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
            Console.WriteLine("│     │         │     │       │  9  │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
            Console.Write("│     │         │  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("  │       │            8           │");
            Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
            Console.WriteLine("│     │    1    │  0  │     3     │     │        │  7  │");
            Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
            Console.WriteLine("│     │                           │  4  │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
            Console.WriteLine("│     │                  │     5     │        6        │");
            Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │  13 │");
            Console.WriteLine("├─────┴──────────────────┤     │");
            Console.WriteLine("│           12           │     │");
            Console.WriteLine("└────────────────────────┴─────┘");
        }

        public static void Route3()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
            Console.WriteLine("│              10             │     │");
            Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
            Console.WriteLine("│     │         │     │       │  9  │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
            Console.WriteLine("│     │         │  2  │       │            8           │");
            Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
            Console.Write("│     │    1    │  0  │     ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("3");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("     │     │        │  7  │");
            Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
            Console.WriteLine("│     │                           │  4  │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
            Console.WriteLine("│     │                  │     5     │        6        │");
            Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │  13 │");
            Console.WriteLine("├─────┴──────────────────┤     │");
            Console.WriteLine("│           12           │     │");
            Console.WriteLine("└────────────────────────┴─────┘");
        }

        public static void Route4()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
            Console.WriteLine("│              10             │     │");
            Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
            Console.WriteLine("│     │         │     │       │  9  │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
            Console.WriteLine("│     │         │  2  │       │            8           │");
            Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
            Console.WriteLine("│     │    1    │  0  │     3     │     │        │  7  │");
            Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
            Console.Write("│     │                           │  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("4");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("  │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
            Console.WriteLine("│     │                  │     5     │        6        │");
            Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │  13 │");
            Console.WriteLine("├─────┴──────────────────┤     │");
            Console.WriteLine("│           12           │     │");
            Console.WriteLine("└────────────────────────┴─────┘");
        }

        public static void Route5()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
            Console.WriteLine("│              10             │     │");
            Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
            Console.WriteLine("│     │         │     │       │  9  │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
            Console.WriteLine("│     │         │  2  │       │            8           │");
            Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
            Console.WriteLine("│     │    1    │  0  │     3     │     │        │  7  │");
            Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
            Console.WriteLine("│     │                           │  4  │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
            Console.Write("│     │                  │     ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("5");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("     │        6        │");
            Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │  13 │");
            Console.WriteLine("├─────┴──────────────────┤     │");
            Console.WriteLine("│           12           │     │");
            Console.WriteLine("└────────────────────────┴─────┘");
        }

        public static void Route6()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
            Console.WriteLine("│              10             │     │");
            Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
            Console.WriteLine("│     │         │     │       │  9  │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
            Console.WriteLine("│     │         │  2  │       │            8           │");
            Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
            Console.WriteLine("│     │    1    │  0  │     3     │     │        │  7  │");
            Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
            Console.WriteLine("│     │                           │  4  │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
            Console.Write("│     │                  │     5     │        ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("6");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("        │");
            Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │  13 │");
            Console.WriteLine("├─────┴──────────────────┤     │");
            Console.WriteLine("│           12           │     │");
            Console.WriteLine("└────────────────────────┴─────┘");
        }

        public static void Route7()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
            Console.WriteLine("│              10             │     │");
            Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
            Console.WriteLine("│     │         │     │       │  9  │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
            Console.WriteLine("│     │         │  2  │       │            8           │");
            Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
            Console.Write("│     │    1    │  0  │     3     │     │        │  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("7");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("  │");
            Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
            Console.WriteLine("│     │                           │  4  │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
            Console.WriteLine("│     │                  │     5     │        6        │");
            Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │  13 │");
            Console.WriteLine("├─────┴──────────────────┤     │");
            Console.WriteLine("│           12           │     │");
            Console.WriteLine("└────────────────────────┴─────┘");
        }

        public static void Route8()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
            Console.WriteLine("│              10             │     │");
            Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
            Console.WriteLine("│     │         │     │       │  9  │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
            Console.Write("│     │         │  2  │       │            ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("8");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("           │");
            Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
            Console.WriteLine("│     │    1    │  0  │     3     │     │        │  7  │");
            Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
            Console.WriteLine("│     │                           │  4  │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
            Console.WriteLine("│     │                  │     5     │        6        │");
            Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │  13 │");
            Console.WriteLine("├─────┴──────────────────┤     │");
            Console.WriteLine("│           12           │     │");
            Console.WriteLine("└────────────────────────┴─────┘");
        }

        public static void Route9()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
            Console.WriteLine("│              10             │     │");
            Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
            Console.Write("│     │         │     │       │  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("9");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("  │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
            Console.WriteLine("│     │         │  2  │       │            8           │");
            Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
            Console.WriteLine("│     │    1    │  0  │     3     │     │        │  7  │");
            Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
            Console.WriteLine("│     │                           │  4  │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
            Console.WriteLine("│     │                  │     5     │        6        │");
            Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │  13 │");
            Console.WriteLine("├─────┴──────────────────┤     │");
            Console.WriteLine("│           12           │     │");
            Console.WriteLine("└────────────────────────┴─────┘");
        }

        public static void Route10()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
            Console.Write("│              ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("10");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("             │     │");
            Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
            Console.WriteLine("│     │         │     │       │  9  │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
            Console.WriteLine("│     │         │  2  │       │            8           │");
            Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
            Console.WriteLine("│     │    1    │  0  │     3     │     │        │  7  │");
            Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
            Console.WriteLine("│     │                           │  4  │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
            Console.WriteLine("│     │                  │     5     │        6        │");
            Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │  13 │");
            Console.WriteLine("├─────┴──────────────────┤     │");
            Console.WriteLine("│           12           │     │");
            Console.WriteLine("└────────────────────────┴─────┘");
        }

        public static void Route11()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
            Console.WriteLine("│              10             │     │");
            Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
            Console.WriteLine("│     │         │     │       │  9  │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
            Console.WriteLine("│     │         │  2  │       │            8           │");
            Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
            Console.WriteLine("│     │    1    │  0  │     3     │     │        │  7  │");
            Console.Write("│  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("11");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" ├─────────┴─────┴───────────┤     │        │     │");
            Console.WriteLine("│     │                           │  4  │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
            Console.WriteLine("│     │                  │     5     │        6        │");
            Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │  13 │");
            Console.WriteLine("├─────┴──────────────────┤     │");
            Console.WriteLine("│           12           │     │");
            Console.WriteLine("└────────────────────────┴─────┘");
        }

        public static void Route12()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
            Console.WriteLine("│              10             │     │");
            Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
            Console.WriteLine("│     │         │     │       │  9  │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       │     │");
            Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
            Console.WriteLine("│     │         │  2  │       │            8           │");
            Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     │         │     │                          │     │");
            Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
            Console.WriteLine("│     │    1    │  0  │     3     │     │        │  7  │");
            Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
            Console.WriteLine("│     │                           │  4  │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                           │     │        │     │");
            Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
            Console.WriteLine("│     │                  │     5     │        6        │");
            Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │     │");
            Console.WriteLine("│     │                  │  13 │");
            Console.WriteLine("├─────┴──────────────────┤     │");
            Console.Write("│           ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("12");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("           │     │");
            Console.WriteLine("└────────────────────────┴─────┘");
        }

        public static void Route13()
        {
            Console.WriteLine("┌─────────────────────────────┬─────┐");
        Console.WriteLine("│              10             │     │");
        Console.WriteLine("├─────┬─────────┬─────┬───────┤     │");
        Console.WriteLine("│     │         │     │       │  9  │");
        Console.WriteLine("│     │         │     │       │     │");
        Console.WriteLine("│     │         │     │       │     │");
        Console.WriteLine("│     │         │     │       ├─────┴──────────────────┐");
        Console.WriteLine("│     │         │  2  │       │            8           │");
        Console.WriteLine("│     │         │     │       └──────────────────┬─────┤");
        Console.WriteLine("│     │         │     │                          │     │");
        Console.WriteLine("│     │         │     │                          │     │");
        Console.WriteLine("│     ├─────────┼─────┼───────────┬─────┐        │     │");
        Console.WriteLine("│     │    1    │  0  │     3     │     │        │  7  │");
        Console.WriteLine("│  11 ├─────────┴─────┴───────────┤     │        │     │");
        Console.WriteLine("│     │                           │  4  │        │     │");
        Console.WriteLine("│     │                           │     │        │     │");
        Console.WriteLine("│     │                           │     │        │     │");
        Console.WriteLine("│     │                  ┌────────┴──┬──┴────────┴─────┤");
        Console.WriteLine("│     │                  │     5     │        6        │");
        Console.WriteLine("│     │                  ├─────┬─────┴─────────────────┘");
        Console.WriteLine("│     │                  │     │");
        Console.WriteLine("│     │                  │     │");
        Console.Write("│     │                  │  ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("13");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" │");
        Console.WriteLine("├─────┴──────────────────┤     │");
        Console.WriteLine("│           12           │     │");
        Console.WriteLine("└────────────────────────┴─────┘");
        }
    }
}