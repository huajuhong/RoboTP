using DriverBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain
{
    public class ProgramRobot
    {
        public string Name { get; set; }
        public string UsedGripperName { get; set; }
        public RobotInstrument Instrument { get; set; }
        public List<RobotFrame> Frames { get; set; }
        public List<RobotGripper> Grippers { get; set; }
        public List<GripperLabware> GripperLabwares { get; set; }
        public List<RobotMotion> Motions { get; set; }
        public List<RobotSequence> Sequences { get; set; }
    }
}