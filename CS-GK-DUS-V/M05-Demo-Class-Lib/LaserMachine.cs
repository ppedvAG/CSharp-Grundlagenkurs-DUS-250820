using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_Demo_Class_Lib
{
    public class LaserMachine
    {
        public int Leistung { get; set; }
        public string Produzent { get; }

        // mehrere Konstruktoren sind erlaubt
        public LaserMachine(string produzent)
        {
            Produzent = produzent;
        }
        public LaserMachine(string produzent, int leistung)
        {
            Produzent = produzent;
            Leistung = leistung;
        }
    }
}
