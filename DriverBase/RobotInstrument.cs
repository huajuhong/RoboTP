using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverBase
{
    public class RobotInstrument : Instrument
    {
        public RobotType RobotType { get; set; }
        public GripperDriver GripperDriver { get; protected set; }
        public RobotDriver RobotDriver { get; protected set; }
    }
}