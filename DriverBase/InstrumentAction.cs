using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverBase
{
    public class InstrumentAction
    {
        public InstrumentAction()
        {
            this.Inputs = Parameters.Empty();
            this.Outputs = Parameters.Empty();
        }

        public string Name { get; set; }
        public Parameters Inputs { get; set; }
        public Parameters Outputs { get; set; }
        public Func<Parameters, Parameters> Action { get; set; }
        public Func<Parameters, Parameters> SimulatedAction { get; set; }
    }
}