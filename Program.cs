using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteuerBerechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Daten
            
            double Preis = 0.0;
            double Steuersatz = 0.0;
            string test = string.Empty;
            double erg = Preis + Steuersatz;

            //

            Console.WriteLine("\t Preis eingeben: ");
            Console.WriteLine("");
            Console.Write("Preis: ");
            Preis = double.Parse(Console.ReadLine());
        
            Console.WriteLine("");

            Console.WriteLine("\t Steuersatz eingeben: ");
            Console.WriteLine("");
            Console.Write("Steuersatz: ");
            Steuersatz = double.Parse(Console.ReadLine());

            Console.WriteLine($"Ergebnis: {Steuersatz} + { Preis} {erg} ");


            


        }
    }
}
