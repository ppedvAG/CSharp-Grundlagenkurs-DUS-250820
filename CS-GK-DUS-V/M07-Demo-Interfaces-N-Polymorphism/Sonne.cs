using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07_Demo_Interfaces_N_Polymorphism
{
    class Sonne : Himmelskörper, IFlüssig
    {
        public int Temperatur { get; set; }
        public string[] Zusammensetzung { get; set; }
        public int ZeitZurExplosion { get; set; }

        public override string ToString()
        {
            //foreach(var prop in )
                Console.WriteLine("Sonne.ToString() ausgeführt");
            if (this.Temperatur == 0)
                return base.ToString();
            else
                return base.ToString() + $@"
Temperatur: {Temperatur}";
        }
        new public int Bewege(int km)
        {
            EntfernungZurErde += km;
            Console.WriteLine("Sonne.Bewege() ausgeführt");
            return EntfernungZurErde;
        }

        public void Explodiere()
        {
            Console.WriteLine("Ich hab keine Lust mehr!");
        }

        string[] IFlüssig.ÄndereZusammensetzung(string[] elemente)
        {
            //string[] neueZusammensetzung = new string[Zusammensetzung.Length + elemente.Length];
            //Array.Copy(Zusammensetzung, neueZusammensetzung, Zusammensetzung.Length);
            //Array.Copy(elemente, 0, neueZusammensetzung, Zusammensetzung.Length, elemente.Length);
            //Zusammensetzung = neueZusammensetzung;
            string[] neueZusammensetzung = Zusammensetzung.Concat(elemente).ToArray();
            Zusammensetzung = neueZusammensetzung;
            return Zusammensetzung;
        }
    }
}
