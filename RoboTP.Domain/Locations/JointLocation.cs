using RoboTP.Domain.Base;
using RoboTP.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain.Locations
{
    public class JointLocation : LocationBase<AxesJoint>
    {
        public override double this[AxesJoint axis] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Joint1 { get; set; }
        public double Joint2 { get; set; }
        public double Joint3 { get; set; }
        public double Joint4 { get; set; }
        public double Joint5 { get; set; }
        public double Joint6 { get; set; }
    }
}