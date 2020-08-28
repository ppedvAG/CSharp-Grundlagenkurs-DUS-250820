using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M16_Experiment_Dependency_Injection
{
    class M16Main
    {
        static void Main(string[] args)
        {
            // Variante 1
            // NoDiClassThird noDiClassThird = new NoDiClassThird(3);

            // Variante 3
            NoDiClassThird noDiClassThird = new NoDiClassThird();

            // Variante 4, mit DI
            // Werte für alle drei Klassen kommen von der gleichen Ebene runter
            DiClassThird diClassThird = new DiClassThird(3, new DiClassFirst(1), new DiClassSecond(2));

            Console.WriteLine(noDiClassThird.NoDiThirdMethod());
            Console.WriteLine(noDiClassThird.noDiClassFirst.NoDiFirstMethod());
            Console.WriteLine(noDiClassThird.noDiClassSecond.NoDiSecondMethod());

            Console.WriteLine(diClassThird.DiThirdMethod());
                       // Console.WriteLine(diClassThird.diClassFirst.NoDiFirstMethod());
            // Console.WriteLine(diClassThird.diClassSecond.NoDiSecondMethod());

            Console.ReadKey();
        }
    }
}
