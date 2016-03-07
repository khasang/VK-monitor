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
        public abstract object GetData(VkApi vk, ulong userId);
    }
}
