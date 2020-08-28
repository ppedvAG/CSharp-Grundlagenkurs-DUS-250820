using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M16_Experiment_Dependency_Injection
{
    // Var 1
    // class DiClassSecond

    // Var 2
    class DiClassSecond: IDiSecond
    {
        public DiClassSecond(int prop)
        {
            DiSecondProp = prop;
        }

        public int DiSecondProp { get; set; }
        public string DiSecondMethod()
        {
            return DiSecondProp.ToString();
        }
    }
}
