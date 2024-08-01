using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverBase
{
    public abstract class GripperDriver
    {
        public string Name { get; set; }

        /// <summary>
        /// 夹持最小位置，单位：毫米
        /// </summary>
        public double YMin { get; set; }

        /// <summary>
        /// 夹持最大位置，单位：毫米
        /// </summary>
        public double YMax { get; set; }

        /// <summary>
        /// 可夹持最小长度，单位：毫米
        /// </summary>
        public double XMin => GetX(YMin);

        /// <summary>
        /// 可夹持最大长度，单位：毫米
        /// </summary>
        public double XMax => GetX(YMax);

        public double X1 { get; set; }

        public double X2 { get; set; }

        public double Y1 { get; set; }

        public double Y2 { get; set; }

        /// <summary>
        /// 截距
        /// </summary>
        public double Intercept
        {
            get
            {
                double k = (Y2 - Y1) / (X2 - X1);
                return k;
            }
        }

        /// <summary>
        /// 斜率
        /// </summary>
        public double Slope
        {
            get
            {
                double b = Y1 - Intercept * X1;
                return b;
            }
        }

        /// <summary>
        /// 夹持打开补偿
        /// </summary>
        public double OpenOffset { get; set; }

        /// <summary>
        /// 夹持关闭补偿
        /// </summary>
        public double CloseOffset { get; set; }

        public double GetX(double y)
        {
            double x = (y - Slope) / Intercept;
            return x;
        }

        public double GetY(double x)
        {
            double y = Intercept * x + Slope;

            bool ok = YMin <= y && y <= YMax;
            if (!ok)
            {
                string messagex = $"当前夹持长度（X）：{x}，可夹持目标物体长度范围：[{XMin} - {XMax}毫米]。";
                string messagey = $"当前夹持位置（Y）：{y}，可夹持范围：[{YMin} - {YMax} ]。";
                string message = messagex + Environment.NewLine + messagey;
                throw new Exception(message);
                //if (YMin > y)
                //{
                //    return YMin;
                //}
                //else
                //{
                //    return YMax;
                //}
            }
            else
            {
                return y;
            }
        }

        public double GetYOfClose(double x)
        {
            double y = GetY(x - CloseOffset);
            return y;
        }

        public double GetYOfOpen(double x)
        {
            double y = GetY(x + OpenOffset);

            if (y > YMax)
            {
                y = YMax;
            }
            if (y < YMin)
            {
                y = YMin;
            }
            return y;
        }

        public abstract void Connect();

        public abstract void Disconnect();

        public abstract double CurrentPosition();

        public abstract bool MoveToOrigin();

        /// <summary>
        /// 移动到指定位置
        /// </summary>
        /// <param name="position">位置值</param>
        /// <param name="speed">速度，范围：0-100</param>
        /// <returns></returns>
        public abstract bool MoveTo(double position, int speed);

        /// <summary>
        /// 打开到指定位置
        /// </summary>
        /// <param name="position">位置值</param>
        /// <param name="speed">速度，范围：0-100</param>
        /// <returns></returns>
        public abstract bool Open(double position, int speed);

        /// <summary>
        /// 关闭到指定位置
        /// </summary>
        /// <param name="position">位置值</param>
        /// <param name="speed">速度，范围：0-100</param>
        /// <param name="gripForce">夹持力等级</param>
        /// <returns></returns>
        public abstract bool Close(double position, int speed, GripForce gripForce);
    }
}