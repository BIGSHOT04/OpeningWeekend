using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeningWeekend
{
    internal class film
    {
        public string OGCim { get; set; }
        public string magyarcim { get; set; }
        public string Bemutato { get; set; }
        public string forgalmazo { get; set; }
        public int Bevétel { get; set; }
        public int látogatok { get; set; }

        public film (string sor)
        {
            string[] t = sor.Split(';');
            OGCim = t[0];
            magyarcim = t[1];   
            Bemutato=t[2];
            forgalmazo = t[3];
            Bevétel = int.Parse(t[4]);
            látogatok = int.Parse(t[5]);
        }




    }
}
