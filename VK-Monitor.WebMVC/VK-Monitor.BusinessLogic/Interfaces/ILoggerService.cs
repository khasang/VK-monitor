using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK_Monitor.BusinessLogic.Interfaces
{
    public interface ILoggerService
    {
        void Debug(string message, params object[] property);
        void Error(string message, params object[] property);
        void Warning(string message, params object[] property);
        void Information(string message, params object[] property);
    }
}
