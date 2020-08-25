using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M04_Demo_Methods
{
    class Methods
    {
        public static bool IstErstesArgumentGrößer(int a, int b)
        {
            if (a > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int WendeVierMathOpsAn(int a, int b, out int differenz, out int produkt, out int quotient)
        {
            // alle out-Parameter müssen mit Werten befüllt werden!!
            differenz = a - b;
            produkt = a * b;
            try
            {
                quotient = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Durch 0 teilen darf man nicht, 0 wird durch 1 ersetzt");
                //throw;
                quotient = a;
            }

            return a + b;
        }

        public static void GibModuloUndMax(double a, double b, ref double modulo, ref double max)
        {
            modulo = a % b;
            // max = Math.Max(a, b); // ref-Parameter dürfen auch ohne Wert bleiben
            max = Math.Max(a, b);
        }
    }
    class Dmethods
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Mehrere returns mit if");
            Console.WriteLine(Methods.IstErstesArgumentGrößer(4, 5));

            Console.WriteLine("\n out-Parameter");
            int differenz = 3; // unnötige Zuweisung wegen out
            Methods.WendeVierMathOpsAn(4, 0, out differenz, out int produkt, out int quotient);
            Console.WriteLine($@"
Differenz: {differenz}
Produkt: {produkt}
Quotient: {quotient}
");

            Console.WriteLine("\n ref-Parameter");
            double mod = 3.2, max = 3.2; // ein Wert muss! zugewiesen werden
            Methods.GibModuloUndMax(8.6, 2.1, ref mod, ref max);
            Console.WriteLine($@"
Modulo: {mod}
Max: {max}
");
            Console.ReadKey();
        }
    }
}
