using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_Demo_Class_Lib
{
    public partial class ClassRoom
    {
        public bool HatKlimaanlage { get; set; }

        public int Ausbauen(int neuePlätze)
        {
            SitzPlätze += neuePlätze;
            return SitzPlätze;
        }
    }
}
