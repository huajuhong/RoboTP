using RoboTP.Domain.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain
{
    public class RobotLocation
    {
        public string Name { get; set; }
        public CartesianLocation CartesianLocation { get; set; }
        public JointLocation JointLocation { get; set; }
    }
}