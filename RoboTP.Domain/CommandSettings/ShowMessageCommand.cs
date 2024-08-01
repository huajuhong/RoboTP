using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboTP.Domain.Base;

namespace RoboTP.Domain.Commands
{
    public class ShowMessageCommand : CommandSettingsBase
    {
        public string Content { get; set; }
    }
}