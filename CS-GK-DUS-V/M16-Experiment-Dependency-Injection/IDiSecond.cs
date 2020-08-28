using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M16_Experiment_Dependency_Injection
{
    public interface IDiSecond
    {
         int DiSecondProp { get; set; }
         string DiSecondMethod();
    }
}
