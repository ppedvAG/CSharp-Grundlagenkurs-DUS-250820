using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01_Demo_Console
{
    class Program
    {
        int irgendwas = 44; //ein Klassenfeld
        static void Main(string[] args)
        {
            #region WriteLine()
            Console.WriteLine("### WriteLine() ###");
            int alter = 35; //eine Methodenvariable
            string name = "Vadim";
            Console.WriteLine("mein Text für die Konsole");
            Console.WriteLine(alter);
            Console.WriteLine(name);
            #endregion

            #region WriteLine(string, arg0, arg1)
            Console.WriteLine("### WriteLine(string, arg0, arg1) ###");
            Console.WriteLine("Ich heiße {0} und bin {1} Jahre alt.", name, alter);
            #endregion

            #region Write()
            Console.WriteLine("### Write() ###");
            Console.Write("Text für Write()");
            #endregion

            #region OutputEncoding
            Console.WriteLine("### OutputEncoding ###");
            Console.WriteLine("Eurozeichen: €");
            Console.WriteLine("Default OutputEncoding: {0}", Console.InputEncoding.EncodingName); // Westeuropäisch (DOS)
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Eurozeichen: €");
            #endregion

            #region ReadLine()
            Console.WriteLine("### ReadLine() ###");
            Console.WriteLine("Wie teuer darf das Hotelzimmer sein?");
            Console.InputEncoding = Encoding.Unicode;
            string zimmerPreis = Console.ReadLine();
            // zimmerPreis = "70€";
            // ??? warum wird € abgeschnitten mit UTF8
            Console.WriteLine("Sie haben eingegeben: {0}", zimmerPreis);
            #endregion ReadLine()

            #region ReadKey()
            Console.WriteLine("### ReadKey() ###");
            Console.ReadKey();
            #endregion


        }
    }
}
