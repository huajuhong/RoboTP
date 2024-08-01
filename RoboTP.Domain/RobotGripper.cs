using DriverBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain
{
    public class RobotGripper
    {
        public string Name { get; set; }
        public GripperDriver Driver { get; set; }
    }
}