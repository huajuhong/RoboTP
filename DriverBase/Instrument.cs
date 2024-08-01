using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverBase
{
    public class Instrument
    {
        /// <summary>
        /// 驱动名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 设备实例名称
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// 制造商
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 已连接标识
        /// </summary>
        public bool Connected { get; set; }

        public bool Simulate { get; set; }
        public Parameters Parameters { get; set; }
        public List<InstrumentAction> Actions { get; set; }

        public virtual void Connect()
        {
        }

        public virtual void Disconnect()
        {
        }

        public event Action<string> OnTraceLog;

        protected void TraceLog(string content)
        { }

        public Parameters RunAction(InstrumentAction command, Parameters inputs)
        {
            Parameters outputs = Parameters.Empty();
            var instrumentAction = this.Actions.Find(x => x.Name == command.Name) ?? throw new Exception($"未找到命令：{command.Name}");
            if (this.Simulate)
            {
                if (instrumentAction.SimulatedAction != null)
                {
                    outputs = instrumentAction.SimulatedAction(inputs);
                }
                else
                {
                    outputs = instrumentAction.Outputs;
                }
            }
            else
            {
                outputs = instrumentAction.Action(inputs);
            }
            return outputs;
        }
    }
}