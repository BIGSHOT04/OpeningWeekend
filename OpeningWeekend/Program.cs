using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace OpeningWeekend
{
    class Program
    {
        static void Main(string[] args)
        {

            List<film> films = new List<film>();
            foreach (var sor in File.ReadLines("nyitohetvege.txt").Skip(1))

            {
                films.Add(new film(sor));
            }
            Console.WriteLine($"Filemk az állományban:{films.Count}db");





            Console.ReadKey();
        }
    }
}
