using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.BusinessLogic;
using VK_Monitor.BusinessLogic.Interfaces;

namespace VK_Monitor.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var logerService = new LoggerConfiguration()
             .MinimumLevel.Verbose()     // ставим минимальный уровень в Verbose для теста, по умолчанию стоит Information
             .WriteTo.RollingFile(@"C:\Logs\Log-{Date}.txt") // а также пишем лог файл, разбивая его по дате
             .WriteTo.Seq("http://localhost:5341")
                // есть возможность писать Verbose уровень в текстовый файл, а например, Error в Windows Event Logs
             .CreateLogger();

            IVkRepository vkRepository = new VkRepository(logerService);

        }
    }
}
