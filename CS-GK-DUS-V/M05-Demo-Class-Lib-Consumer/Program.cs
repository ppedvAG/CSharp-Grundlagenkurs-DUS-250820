using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M05_Demo_Class_Lib;

namespace M05_Demo_Class_Lib_Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            LaserMachine lm = new LaserMachine("4 Jet Technologies", 500);
            Console.WriteLine($"lm.Produzent: {lm.Produzent}");
            Console.WriteLine($"lm.Leistung: {lm.Leistung}");

            // lm.Produzent = "Bosch"; // cannot, read only
            lm.Leistung = 600;

            Console.WriteLine($"lm.Produzent: {lm.Produzent}");
            Console.WriteLine($"lm.Leistung: {lm.Leistung}");

            Console.WriteLine("### Partial Class ###");
            ClassRoom cr = new ClassRoom();
            cr.SitzPlätze = 16;
            cr.HatKlimaanlage = true;
            Console.WriteLine($"cr.SitzPlätze: {cr.SitzPlätze}");
            Console.WriteLine($"cr.HatKlimaanlage: {cr.HatKlimaanlage}");
            cr.Ausbauen(4);
            Console.WriteLine($"cr.SitzPlätze: {cr.SitzPlätze}");
            Console.WriteLine($"cr.HatKlimaanlage: {cr.HatKlimaanlage}");


            Console.ReadKey(); 
        }
    }
}
