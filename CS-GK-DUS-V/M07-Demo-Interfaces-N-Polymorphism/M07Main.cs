using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07_Demo_Interfaces_N_Polymorphism
{
    class M07Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n OVERRIDES VS OVERLOADS");
            Console.WriteLine("\n### Himmelskörper hk1 = new Himmelskörper() ###");
            Himmelskörper hk1 = new Himmelskörper();
            hk1.Gewicht = 50;
            hk1.EntfernungZurErde = 500;
            Console.WriteLine(hk1.ToString());            
            hk1.Bewege(5);

            Console.WriteLine("\n### Sonne sonne = new Sonne() ###");
            Sonne sonne = new Sonne();
            sonne.Gewicht = 60;
            sonne.EntfernungZurErde = 600;
            sonne.Temperatur = 6000;
            Console.WriteLine(sonne.ToString());
            sonne.Bewege(2);
            Console.WriteLine($"sonne.GetType(): {sonne.GetType()}"); // Laufzeittyp, sprich: der verwendete Konstruktor
            Console.WriteLine($"sonne is Sonne: {sonne is Sonne}"); // Laufzeittyp
            Console.WriteLine($"sonne is Himmelskörper: {sonne is Himmelskörper}"); // Laufzeittyp
            Console.WriteLine($"typeof(Himmelskörper).IsInstanceOfType(sonne): {typeof(Himmelskörper).IsInstanceOfType(sonne)}");
            Console.WriteLine($"typeof(Sonne).IsInstanceOfType(sonne): {typeof(Sonne).IsInstanceOfType(sonne)}");
            Console.WriteLine($"sonne.GetType() == typeof(Sonne): {sonne.GetType() == typeof(Sonne)}");
            Console.WriteLine($"sonne.GetType() == typeof(Himmelskörper): {sonne.GetType() == typeof(Himmelskörper)}");


            Console.WriteLine("\n### Himmelskörper hk2 = new Sonne() ###");
            Himmelskörper hk2 = new Sonne();
            hk2.Gewicht = 70;
            hk2.EntfernungZurErde = 700;
            // hk2.Temperatur // no definition for Temperatur
            Console.WriteLine(hk2.ToString());
            hk2.Bewege(5);
            Console.WriteLine($"hk2.GetType(): {hk2.GetType()}");
            Console.WriteLine($"hk2 is Sonne: {hk2 is Sonne}");
            Console.WriteLine($"hk2 is Himmelskörper: {hk2 is Himmelskörper}");
            Console.WriteLine($"typeof(Himmelskörper).IsInstanceOfType(hk2): {typeof(Himmelskörper).IsInstanceOfType(hk2)}");
            Console.WriteLine($"typeof(Sonne).IsInstanceOfType(hk2): {typeof(Sonne).IsInstanceOfType(hk2)}");
            Console.WriteLine($"hk2.GetType() == typeof(Sonne): {hk2.GetType() == typeof(Sonne)}");
            Console.WriteLine($"hk2.GetType() == typeof(Himmelskörper): {hk2.GetType() == typeof(Himmelskörper)}");
            // ??? wie kann ich sehen, dass hk2 die Eigenschaft Temperatur nicht hat bzw dadrauf nicht zugreifen kann
            //switch 
            //if (when hk2.Temperatur )


            Console.WriteLine($"\nobject.Equals(sonne, hk2): {object.Equals(sonne, hk2)}");

            Console.WriteLine("\n\n IMPLICITE VS EXPLICITE");
            sonne.Explodiere();
            // sonne.ÄndereZusammensetzung(new string[] {"Eisen", "Kupfer"}); // darf nicht genutzt werden

            IFlüssig sonne2 = new Sonne();
            // sonne2.Gewicht = 30; // darf nicht genutzt werden
            // ((Sonne)sonne2).Gewicht = 30; // wenn man doch sonne2 als Sonne benutzen möchte
            // sonne2.EntfernungZurErde = 300; // darf nicht genutzt werden
            // sonne2.Temperatur = 3000; // darf nicht genutzt werden
            sonne2.Zusammensetzung = new string[] { "elem1", "elem2" };
            sonne2.Explodiere();
            sonne2.ÄndereZusammensetzung(new string[] { "elem3", "elem4" });

            Console.WriteLine("sonne2.Zusammensetzung:");
            foreach(string el in sonne2.Zusammensetzung)            
                Console.WriteLine(el);
            
            Console.ReadKey();

        }
    }
}
