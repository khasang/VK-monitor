using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.BusinessLogic.Interfaces;

namespace VK_Monitor.BusinessLogic
{
    public static class Logger
    {
        static ILogger logerService;

        static Logger()
        {
            logerService = new LoggerConfiguration()
                .MinimumLevel.Verbose()     // ставим минимальный уровень в Verbose для теста, по умолчанию стоит Information
                .WriteTo.RollingFile(@"C:\Logs\Log-{Date}.txt") // а также пишем лог файл, разбивая его по дате
                .WriteTo.Seq("http://localhost:5341")
                   // есть возможность писать Verbose уровень в текстовый файл, а например, Error в Windows Event Logs
                .CreateLogger();

            TurnOn = true;
        }
        
        public static bool TurnOn { get; set; }

        void Debug(string message, params object[] property)
        {
            if(TurnOn == true )
            {
                logerService.Debug(message, property);
            }            
        }

        void Error(string message, params object[] property)
        {
            if (TurnOn == true)
            {
                logerService.Error(message, property);
            }            
        }

        void Warning(string message, params object[] property)
        {
            if (TurnOn == true)
            {
                logerService.Warning(message, property);
            }            
        }

        void Information(string message, params object[] property)
        {
            if (TurnOn == true)
            {
                logerService.Information(message, property);
            }            
        }
        
    }
}
