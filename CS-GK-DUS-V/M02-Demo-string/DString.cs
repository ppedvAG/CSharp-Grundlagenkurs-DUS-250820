using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_Demo_string
{
    class DString
    {
        static void ZeigeInterpoliertesString()
        {
            Console.WriteLine("ZeigeInterpoliertesString");
            string interpolStr = $"DateTime.Now: {DateTime.Now}";
            Console.WriteLine(interpolStr);
        }

        static void ZeigeEscapes()
        {
            Console.WriteLine("ZeigeEscapes");
            string stringMitEscapes = "\n text nach n, \t text nach t";
            Console.WriteLine(stringMitEscapes);
        }

        static void ZeigeVerbatimString()
        {
            Console.WriteLine("ZeigeVerbatimString");
            string verbatimStr = @"
text nach Zeilenumbruch
    text nach Tab";
            Console.WriteLine(verbatimStr);
        }

        static void ZeigeInterpoliertesVerbatimString()
        {
            Console.WriteLine("ZeigeInterpoliertesVerbatimString");
            string myIntVerbStr = $@"
text nach Zeilenumbruch
    text nach Tab
DateTime.Now: {DateTime.Now}";
            Console.WriteLine(myIntVerbStr);
        }

        static void Main(string[] args)
        {
            ZeigeInterpoliertesString();
            ZeigeEscapes();
            ZeigeVerbatimString();
            ZeigeInterpoliertesVerbatimString();
            Console.ReadKey();
        }

    }
}
