using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboTP.Domain.Base;

namespace RoboTP.Domain.Commands
{
    public class SetRoundingCommand : CommandSettingsBase
    {
        /// <summary>
        /// 半径值，单位毫米或百分比
        /// </summary>
        public double RadiusValue { get; set; }
    }
}