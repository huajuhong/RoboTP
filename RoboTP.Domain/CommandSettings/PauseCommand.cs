using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboTP.Domain.Base;

namespace RoboTP.Domain.Commands
{
    public class PauseCommand : CommandSettingsBase
    {
        /// <summary>
        /// 暂停的毫秒数
        /// </summary>
        public int Milliseconds { get; set; }
    }
}