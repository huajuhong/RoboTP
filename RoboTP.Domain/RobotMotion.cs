using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain
{
    public class RobotMotion
    {
        public string Name { get; set; }
        public double Speed { get; set; }
        public double Acceleration { get; set; }
        public double Deceleration { get; set; }

        /// <summary>
        /// 转弯半径
        /// </summary>
        public double InRange { get; set; }

        /// <summary>
        /// 加速度，达到完全加速的秒数（建议1秒）
        /// </summary>
        public double AccelerationRamp { get; set; }

        /// <summary>
        /// 减速度，达到完全减速的秒数（建议1秒）
        /// </summary>
        public double DecelerationRamp { get; set; }

        /// <summary>
        /// 混合运动
        /// </summary>
        public bool BlendMotion { get; set; }

        /// <summary>
        /// 直线
        /// </summary>
        public bool Straight { get; set; }
    }
}