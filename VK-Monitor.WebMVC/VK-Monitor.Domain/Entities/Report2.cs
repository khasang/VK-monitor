using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;

namespace VK_Monitor.Domain.Entities
{
    public class Report2 : Report
    {
        public Report2(VkApi vk) : base (vk)
        {

        }

        public override object GetData()
        {
            throw new NotImplementedException();
        }
    }
}
