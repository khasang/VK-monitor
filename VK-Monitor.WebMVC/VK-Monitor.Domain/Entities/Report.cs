using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;

namespace VK_Monitor.Domain.Entities
{
    public abstract class Report
    {
        VkApi vk;

        public Report(VkApi vk)
        {
            this.vk = vk;
        }

        public abstract object GetData();
    }
}
