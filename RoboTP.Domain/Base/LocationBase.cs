using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTP.Domain.Base
{
    public abstract class LocationBase<TAxesEnum> where TAxesEnum : Enum
    {
        public abstract double this[TAxesEnum axis] { get; set; }
    }
}