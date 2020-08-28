using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M16_Experiment_Dependency_Injection
{
    class NoDiClassFirst
    {
        public NoDiClassFirst(int prop)
        {
            NoDiFirstProp = prop;
        }

        public int NoDiFirstProp { private get; set; }
        public string NoDiFirstMethod()
        {
            return NoDiFirstProp.ToString();
        }

    }
}
