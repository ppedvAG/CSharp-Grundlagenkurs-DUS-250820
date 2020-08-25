using M05_Lab_Transportmittel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M06_Lab_Inheritence
{
    public class Flugzeug : Transportmittel
    {
        public int MaxFlugHöhe { get; set; }
        public int GeflogeneKm { get; set; }

        public int MaxLadung { get; set; }
        public Flugzeug(string name, double preis, uint maximalGeschwindigkeit, int maximalFlugHöhe, int geflogeneKm) : base(name, preis, maximalGeschwindigkeit)
        {
            MaxFlugHöhe = maximalFlugHöhe;
            GeflogeneKm = geflogeneKm;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"MaxFlugHöhe: {MaxFlugHöhe}";
        }
    }
}
