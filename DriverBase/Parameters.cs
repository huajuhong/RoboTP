using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverBase
{
    public class Parameters
    {
        public List<Variable> Variables { get; private set; }

        public Parameters()
        {
            this.Variables = [];
        }

        public static Parameters Empty()
        {
            return new Parameters();
        }

        public void AddVariable(Variable variable)
        {
            Variable? v = Variables.Find(v => v.Name == variable.Name);
            if (v != null)
            {
                return;
            }
            Variables.Add(variable);
        }

        public Variable? GetVariable(string name)
        {
            Variable? v = Variables.Find(v => v.Name == name);
            return v;
        }

        public void SetVariable(string name, string value)
        {
            Variable? v = Variables.Find(v => v.Name == name);
            if (v != null)
            {
                v.Value = value;
            }
        }
    }
}