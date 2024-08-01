using RoboTP.Domain.Enums;
using RoboTP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain
{
    /// <summary>
    /// 机械臂参考坐标系
    /// </summary>
    public class RobotFrame
    {
        public string Name { get; set; }
        public RobotFrameType Type { get; set; }
        public List<RobotLocation> Locations { get; set; }
    }
}