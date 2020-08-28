using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M16_Experiment_Dependency_Injection
{
    public interface IDiFirst
    {
        int DiFirstProp { get; set; }
        string DiFirstMethod();
    }
}
