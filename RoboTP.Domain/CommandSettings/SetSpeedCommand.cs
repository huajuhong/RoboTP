using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboTP.Domain.Base;

namespace RoboTP.Domain.Commands
{
    public class SetSpeedCommand : CommandSettingsBase
    {
        /// <summary>
        /// 速度值，范围：0-100
        /// </summary>
        public byte Value { get; set; }
    }
}