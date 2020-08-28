using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M16_Experiment_Dependency_Injection
{
    class NoDiClassThird
    {
        // Variante 1
        // Werte für First und Second sind fest codiert
        //public NoDiClassThird(int noDiThirdProp)
        //{
        //    NoDiThirdProp = noDiThirdProp;
        //    noDiClassFirst = new NoDiClassFirst(1);
        //    noDiClassSecond = new NoDiClassSecond(2);
        //}

        // Variante 2
        // Umweg 1, aber der Konstruktor ist nicht logisch aufgebaut
        //public NoDiClassThird(int noDiThirdProp, int paramFirst, int paramSecond)
        //{
        //    NoDiThirdProp = noDiThirdProp;
        //    noDiClassFirst = new NoDiClassFirst(paramFirst);
        //    noDiClassSecond = new NoDiClassSecond(paramSecond);
        //}

        // Variante 3
        // Umweg 2, DI aufs Schnelle, aber die Abhängigkeiten sind immernoch gekoppelt
        // Poor Man's DI
        public NoDiClassThird() : this(3, new NoDiClassFirst(1), new NoDiClassSecond(2))
        { }
        public NoDiClassThird(int prop, NoDiClassFirst noDiClassFirstInstance, NoDiClassSecond noDiClassSecondInstance)
        {
            NoDiThirdProp = prop;
            noDiClassFirst = noDiClassFirstInstance;
            noDiClassSecond = noDiClassSecondInstance;
        }
        public NoDiClassFirst noDiClassFirst;
        public NoDiClassSecond noDiClassSecond;
        public int NoDiThirdProp { private get; set; }
        public string NoDiThirdMethod()
        {
            return noDiClassFirst.NoDiFirstMethod() + " " + noDiClassSecond.NoDiSecondMethod() + " " + NoDiThirdProp.ToString();
        }
    }
}
