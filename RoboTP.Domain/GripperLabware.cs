using DriverBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain
{
    public class GripperLabware
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double GripOpenOffset { get; set; }
        public double GripCloseOffset { get; set; }
        public double GripHeightOffset { get; set; }
        public GripForce GripForce { get; set; }
    }
}