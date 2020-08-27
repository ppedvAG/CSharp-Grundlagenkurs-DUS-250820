using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_Demo_Primitives
{
    class M2DemoMain
    {
        static void Main(string[] args)
        {
            MyBool.ZeigeGleichheit();
            MyBool.ZeigeUngleichheit();
            MyBool.ZeigeUnd();
            MyBool.ZeigeOder();
            MyBool.ZeigeAusschlOder();

            MyDouble.ZeigeDouble();

            MyEnum.ShowYourself();

            MyInt.ZeigeLiterals();
            MyInt.ZeigeMöglicheWerte();
            MyInt.ZeigeParsing();
            MyInt.ZeigeCasting();
            MyInt.ZeigeVergleich();

            MyString.ZeigeInterpoliertesString();
            MyString.ZeigeEscapes();
            MyString.ZeigeVerbatimString();
            MyString.ZeigeInterpoliertesVerbatimString();

            Console.ReadKey();
        }
    }
}
