using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboTP.Domain.Base;
using RoboTP.Domain.Enums;

namespace RoboTP.Domain.Commands
{
    /// <summary>
    /// 设置数字输出：Set IO
    /// 设置模拟量输出：Set AO
    /// 等待数字输入：Wait IO
    /// </summary>
    public class IOCommand : CommandSettingsBase
    {
        public IOCommandType Type { get; set; }

        /// <summary>
        /// IO名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// IO值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 等待超时毫秒数
        /// </summary>
        public int TimeoutMilliseconds { get; set; }
    }
}