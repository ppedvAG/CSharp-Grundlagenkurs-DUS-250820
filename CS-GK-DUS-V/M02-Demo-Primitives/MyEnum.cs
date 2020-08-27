using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_Demo_Primitives
{
    class MyEnum
    {
        enum Pizzagröße { klein = 1, mittel, groß, family }

        public static void ShowYourself()
        {        
        #region Intro
        Console.WriteLine("\n ### Intro ###");
            Pizzagröße pizzagröße1 = Pizzagröße.mittel;
        Pizzagröße pizzagröße2 = (Pizzagröße)3;
        Console.WriteLine($@"
- Ich hab mir eine {pizzagröße1}-Pizza bestellt.
- Und ich hab mir eine {pizzagröße2}-Pizza genommen.");
            #endregion
        }
    }
}
