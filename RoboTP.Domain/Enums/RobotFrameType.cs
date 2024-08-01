using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain.Enums
{
    /// <summary>
    /// 坐标系
    /// </summary>
    public enum RobotFrameType
    {
        None,

        /// <summary>
        /// 参考坐标系，相对于机器人基座
        /// </summary>
        Base,

        /// <summary>
        /// 参考坐标系，相对于机器人基座
        /// </summary>
        Refrence,

        /// <summary>
        /// 工具坐标系，相对于机器人法兰
        /// </summary>
        Tool
    }
}