using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain.Interfaces;
using VkNet;
using VkNet.Enums.Filters;
using Serilog;
using Serilog.Configuration;

namespace VK_Monitor.BusinessLogic
{
    public class VkRepository : IVkRepository
    {
        VkApi vk = new VkApi();
        ILogger loggerService;

        public VkRepository(ILogger logerService)
        {
            this.loggerService = logerService;
        }

        public void Authorize(ulong applicationId, string adminId, string adminPassword)
        {
            ApiAuthParams authorize = new ApiAuthParams()
            {
                ApplicationId = applicationId,
                Login = adminId,
                Password = adminPassword,
                Settings = Settings.All
            };

            try
            {
                vk.Authorize(authorize);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            var logger = new LoggerConfiguration()
             .MinimumLevel.Verbose()     // ставим минимальный уровень в Verbose для теста, по умолчанию стоит Information
             .WriteTo.RollingFile(@"C:\Logs\Log-{Date}.txt") // а также пишем лог файл, разбивая его по дате
             .WriteTo.Seq("http://localhost:5341")
                // есть возможность писать Verbose уровень в текстовый файл, а например, Error в Windows Event Logs
             .CreateLogger();
        }


        public Dictionary<string, IList<string>> Users(ulong userId)
        {
            throw new NotImplementedException();
        }
    }
}
