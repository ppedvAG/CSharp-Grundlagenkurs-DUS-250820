using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M16_Experiment_Dependency_Injection
{
    // Variante 1
    // class DiClassFirst

    // Variante 2
    // die Klasse ist erweiterbar, dabei muss die ClassThird nicht angepasst werden
    class DiClassFirst : IDiFirst
    {
        public DiClassFirst(int prop)
        {
            DiFirstProp = prop;
        }

        public int DiFirstProp { get; set; }

        public string ErweiterungZumInterface { get; set; }
        public string DiFirstMethod()
        {
            return $"DiFirstProp: {DiFirstProp} \nErweiterungZumInterface: {ErweiterungZumInterface}";
        }
    }
}
