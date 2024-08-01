using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverBase
{
    public enum RobotType
    {
        /// <summary>
        /// 多关节
        /// </summary>
        Articulated = 1,

        /// <summary>
        /// 平面多关节机器人
        /// </summary>
        SCARA = 2,

        /// <summary>
        /// 并联机器人
        /// </summary>
        Parallel = 3,

        /// <summary>
        /// 直角坐标机器人
        /// </summary>
        Cartesian = 4,

        /// <summary>
        /// 圆柱坐标机器人
        /// </summary>
        Cylindrical = 5,

        /// <summary>
        /// 协作机器人
        /// </summary>
        Cooperative = 6,

        /// <summary>
        /// 移动机器人
        /// </summary>
        Mobile = 7,
    }
}