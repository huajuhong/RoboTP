using RoboTP.Domain.Base;
using RoboTP.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain.Locations
{
    public class CartesianLocation : LocationBase<AxesCartesian>
    {
        public override double this[AxesCartesian axis] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        /// <summary>
        /// roll(deg)
        /// </summary>
        public double RX { get; set; }

        /// <summary>
        /// pith(deg)
        /// </summary>
        public double RY { get; set; }

        /// <summary>
        /// yaw(deg)
        /// </summary>
        public double RZ { get; set; }

        /// <summary>
        /// 姿态
        /// </summary>
        public double Figure { get; set; }
    }
}