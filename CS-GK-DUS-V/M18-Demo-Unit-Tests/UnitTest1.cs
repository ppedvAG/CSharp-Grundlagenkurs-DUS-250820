using System;
using M05_Lab_Transportmittel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace M18_Demo_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BeschleunigeÜberMaxG()
        {
            // z.B. Methode Beschleunige() darf die AktGeschw. nicht höher setzen als MaxGeschw
            Transportmittel transportmittel = new Transportmittel("Rollschuhe", 50, 100);
            transportmittel.StarteMotor();
            transportmittel.Beschleunige(150);
            Assert.AreEqual(transportmittel.AktuelleGeschwindigkeit, transportmittel.MaximalGeschwindigkeit);
        }
    }
}
