using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK_Monitor.Domain.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public long VkId { get; set; }

        //[]
        public TargetUser Owner { get; set; }
    }
}
