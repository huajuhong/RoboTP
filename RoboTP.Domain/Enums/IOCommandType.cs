using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain.Enums
{
    public enum IOCommandType
    {
        /// <summary>
        /// 设置数字输出
        /// </summary>
        SetIO,

        /// <summary>
        /// 设置模拟量输出
        /// </summary>
        SetAO,

        /// <summary>
        /// 等待数字输入
        /// </summary>
        WaitIO
    }
}