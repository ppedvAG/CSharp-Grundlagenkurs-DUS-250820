using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07_Demo_Interfaces_N_Polymorphism
{
    public class Himmelskörper
    {
        public int Gewicht { get; set; }
        public int EntfernungZurErde { get; set; }
        public virtual string ToString()
        {
            Console.WriteLine("Himmelskörper.ToString() ausgeführt");
            return $"Gewicht: {Gewicht}";
        }
        public int Bewege(int km)
        {
            EntfernungZurErde += km;
            Console.WriteLine("Himmelskörper.Bewege() ausgeführt");
            return EntfernungZurErde;
        }
    }
}
