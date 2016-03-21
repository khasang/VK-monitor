using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain.Interfaces;
using VkNet;

namespace VK_Monitor.Domain.Entities
{
    public class Report2 : IReport
    {
        public object GetData(IVkRepository vkRepository, ulong userId)
        {
            throw new NotImplementedException();
        }
    }
}
