using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_Lab_Fuhrpark
{
    class M05Main
    {
        static void Main(string[] args)
        {
            Transportmittel transportmittel = new Transportmittel("Kutsche", 450.23, 200);
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(transportmittel.BeschreibeMich()); 

            Console.ReadKey();
        }
    }
}
