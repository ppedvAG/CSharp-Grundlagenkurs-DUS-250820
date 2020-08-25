using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M05_Lab_Transportmittel;

namespace M06_Lab_Inheritence
{
    public class Schiff : Transportmittel
    {
        public enum SchiffsTreibstoff
        {
            Diesel,
            Dampf,
            Wind,
            Muskelkraft
        }
        public SchiffsTreibstoff Treibstoff { get; set; }

        public int MaxLadung { get; set; }

        public Schiff(string name, double preis, uint maximalGeschwindigkeit, SchiffsTreibstoff treibstoff) : base(name, preis, maximalGeschwindigkeit)
        {
            Treibstoff = treibstoff;            
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $@"
Treibstoff: {Treibstoff},
MaxLadung: {MaxLadung}";
        }
    }
}
