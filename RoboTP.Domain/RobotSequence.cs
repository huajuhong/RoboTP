using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain
{
    public class RobotSequence
    {
        public string Name { get; set; }
        public List<SequenceCommand> CommandSettings { get; set; }
    }
}