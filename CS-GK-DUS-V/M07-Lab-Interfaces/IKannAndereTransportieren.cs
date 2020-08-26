using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07_Lab_Interfaces
{
    interface IKannAndereTransportieren
    {
        Transportmittel[] AktTransMittelLadung { get; set; }
        int MaxTransMittelLadung { get; set; }
        Transportmittel[] Belade(Transportmittel[] transport);
        Transportmittel[] Entlade();
    }
}
