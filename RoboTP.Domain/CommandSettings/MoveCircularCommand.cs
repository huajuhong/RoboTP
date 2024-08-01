using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboTP.Domain.Base;

namespace RoboTP.Domain.Commands
{
    public class MoveCircularCommand : CommandSettingsBase
    {
        public string RobotLocationName1 { get; set; }
        public string RobotLocationName2 { get; set; }
    }
}