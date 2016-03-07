using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;

namespace VK_Monitor.Domain.Entities
{
    public class Report1 : Report
    {
        public override object GetData(VkApi vk, ulong userId)
        {
            throw new NotImplementedException();
        }
    }
}
