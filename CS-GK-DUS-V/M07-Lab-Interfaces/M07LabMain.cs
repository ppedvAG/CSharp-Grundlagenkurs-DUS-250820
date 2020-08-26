using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07_Lab_Interfaces
{
    class M07LabMain
    {
        static void Main(string[] args)
        {
        }

        static Transportmittel[] BeladeWennsGeht(Transportmittel t1, Transportmittel t2)
        {
            if (t1 is IKannAndereTransportieren && !(t2 is IKannAndereTransportieren))
            {
                ((IKannAndereTransportieren)t1).Belade(new Transportmittel[] { t2 });
            }
            return ((IKannAndereTransportieren)t1).AktTransMittelLadung;
        }
    }
}
