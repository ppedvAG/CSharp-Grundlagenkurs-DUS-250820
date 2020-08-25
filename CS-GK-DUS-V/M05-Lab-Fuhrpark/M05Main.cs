using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M05_Lab_Transportmittel;
using M06_Lab_Inheritence;

namespace M05_Lab_Fuhrpark
{
    class M05Main
    {
        static void Main(string[] args)
        {
            Transportmittel transportmittel = new Transportmittel("Kutsche", 450.23, 200);
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(transportmittel.BeschreibeMich());

            PKW pkw = new PKW("Audi", 45.45, 189, 3, 45);
            Console.WriteLine(pkw.BeschreibeMich());

            Schiff schiff = new Schiff("Titanic", 2000000.00, 150, Schiff.SchiffsTreibstoff.Diesel);
            Console.WriteLine(schiff.BeschreibeMich());

            Flugzeug flugzeug = new Flugzeug("Boeing", 356433222.22, 500, 7, 20000);
            Console.WriteLine(flugzeug.BeschreibeMich());

            Console.ReadKey();
        }
    }
}
