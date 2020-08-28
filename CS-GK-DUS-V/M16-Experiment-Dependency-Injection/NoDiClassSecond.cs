using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M16_Experiment_Dependency_Injection
{
    class NoDiClassSecond
    {
        public NoDiClassSecond(int prop)
        {
            NoDiSecondProp = prop;
        }

        public int NoDiSecondProp { private get; set; }
        public string NoDiSecondMethod()
        {
            return NoDiSecondProp.ToString();
        }
    }
}
