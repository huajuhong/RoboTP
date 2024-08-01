using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain.Enums
{
    public enum RobotCommandType
    {
        拿起指令,
        放下指令,
        打开夹持器指令,
        闭合夹持器指令,
        关节运动指令,
        直线运动指令,
        圆弧运动指令,
        设定速度指令,
        显示信息指令,
        暂停指令,
        调用程序指令,
        信号指令,
        设置轨迹精度,
        设置工件坐标系指令,
        设置工具坐标系指令,
    }
}