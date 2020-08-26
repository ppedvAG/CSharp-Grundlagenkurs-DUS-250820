using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07_Demo_Interfaces_N_Polymorphism
{
    interface IFlüssig
    {
        string[] Zusammensetzung { get; set; }
        int ZeitZurExplosion { get; set; }
        string[] ÄndereZusammensetzung(string[] elemente);
        void Explodiere();
    }
}
