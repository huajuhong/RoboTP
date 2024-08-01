using RoboTP.Domain.Base;
using RoboTP.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain
{
    public class SequenceCommand
    {
        public string Name { get; set; }
        public RobotCommandType Type { get; set; }
        public CommandSettingsBase Settings { get; set; }
    }
}