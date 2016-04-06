using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.BusinessLogic;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain;
using VK_Monitor.Domain.Interfaces;

namespace VK_Monitor.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //public IDataManager dataManager { get; set; }

            IVkService vkRepository = new VkService();

        }
    }
}
