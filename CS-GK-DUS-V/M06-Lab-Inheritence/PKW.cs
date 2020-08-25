using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M05_Lab_Transportmittel;

namespace M06_Lab_Inheritence
{
    public class PKW : Transportmittel
    {
        public int AnzahlTüren { get; set; }
        public int GefahreneKm { get; set; }
        public int MaxLadung { get; set; }
        public PKW(string name, double preis, uint maximalGeschwindigkeit, int anzahlTüren, int gefahreneKm) : base(name, preis, maximalGeschwindigkeit)
        {
            AnzahlTüren = anzahlTüren;
            GefahreneKm = gefahreneKm;
        }
        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"AnzahlTüren: {AnzahlTüren}";
        }
    }
}
