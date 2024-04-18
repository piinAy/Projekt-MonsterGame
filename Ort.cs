using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel
{
    public class Ort
    {
        public string Name { get; set; }
        public int Nummer { get; set; } //mal einen int hinzugefügt, für weniger Schreibarbeit ggf

        public Ort(string name, int nummer)
        {
            Name = name;
            Nummer = nummer;
        }

        //Liste welche Route zu welchen Routen führen kann
        public static Dictionary<int, List<int>> Verbindungen { get; } = new Dictionary<int, List<int>>
        {
            { 0, new List<int> { 1, 2, 3 } },
            { 1, new List<int> { 0, 11 } },
            { 2, new List<int> { 0, 10 } },
            { 3, new List<int> { 0, 4 } },
            { 4, new List<int> { 3, 5, 6 } },
            { 5, new List<int> { 4, 6, 13 } },
            { 6, new List<int> { 4, 5, 7 } },
            { 7, new List<int> { 6, 8 } },
            { 8, new List<int> { 7, 9 } },
            { 9, new List<int> { 8, 10 } },
            { 10, new List<int> { 2, 9, 11 } },
            { 11, new List<int> { 1, 10, 12 } },
            { 12, new List<int> { 11, 13 } },
            { 13, new List<int> { 12, 5 } }
        };
    }
}

//wie viele Bewegungen zur Zielroute von Route 0 aus (mindestens)
//1 -> Route 1
//1 -> Route 2
//1 -> Route 3
//2 -> Route 4
//3 -> Route 5
//3 -> Route 6
//4 -> Route 7
//4 -> Route 8
//3 -> Route 9
//2 -> Route 10
//2 -> Route 11
//3 -> Route 12
//4 -> Route 13

//am weitesten entfernt: Route 7, 8 und 13 = hier seltenere Pokemon hin