using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M16_Experiment_Dependency_Injection
{
    class DiClassThird
    {
        // Variante 1
        //public DiClassThird(int prop, DiClassFirst diClassFirstInstance, DiClassSecond diClassSecondInstance)
        //{
        //    DiThirdProp = prop;
        //    diClassFirst = diClassFirstInstance;
        //    diClassSecond = diClassSecondInstance;
        //}

        // Variante 2, mit erweiterbaren ClassFirst und ClassSecond, optional. Variante 1 funktioniert hier auch
        public DiClassThird(int prop, IDiFirst diFirstInstance, IDiSecond diSecondInstance)
        {
            DiThirdProp = prop;
            diFirst = diFirstInstance;
            diSecond = diSecondInstance;
        }

        // fields
        // Variante 1
        //private DiClassFirst diClassFirst;
        //private DiClassSecond diClassSecond;

        // Variante 2, mit erweiterbaren ClassFirst und ClassSecond
        private IDiFirst diFirst;
        private IDiSecond diSecond;

        // props
        public int DiThirdProp { private get; set; }
        public string DiThirdMethod()
        {
            // return diClassFirst.DiFirstMethod() + " " + diClassSecond.DiSecondMethod() + " " + DiThirdProp.ToString();
            return diFirst.DiFirstMethod() + " " + diSecond.DiSecondMethod() + " " + DiThirdProp.ToString();
        }

    }
}
