using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03ArrayNControls
{
    class MyForeach
    {
        static void Tell3FactsAboutYourself()
        {
            Console.WriteLine("Anfang in den Folien");
            Console.WriteLine("\n #1");
            Console.WriteLine("\n #2");
            Console.WriteLine("\n #3");
            Console.WriteLine(@"
Hat der foreach-Iterator nur eine einzelne Anweisung, 
sind die geschweiften Klammern optional:
    foreach (var item in ienumerable)
        Console.WriteLine(item.ToString());
");
        }
    }
}
