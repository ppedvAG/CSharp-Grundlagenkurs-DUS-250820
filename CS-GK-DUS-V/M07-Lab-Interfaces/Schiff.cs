using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07_Lab_Interfaces
{
    public class Schiff : Transportmittel, IKannAndereTransportieren
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
        public Transportmittel[] AktTransMittelLadung { get; set; }
        public int MaxTransMittelLadung { get; set; }
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

        public Transportmittel[] Belade(Transportmittel[] transport)
        {
            Transportmittel[] neueAktTransMittelLadung = AktTransMittelLadung.Concat(transport).ToArray();
            AktTransMittelLadung = neueAktTransMittelLadung;
            return AktTransMittelLadung;
        }

        public Transportmittel[] Entlade()
        {
            AktTransMittelLadung = null;
            return AktTransMittelLadung;
        }
    }
}
