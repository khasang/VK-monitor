using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK_Monitor.Domain.Entities
{
    public class Friend
    {
        public int Id { get; set; }
        public long VkId { get; set; }
        public DateTime Date { get; set; }

        public int OwnerId { get; set; }
        public virtual TargetUser Owner { get; set; }
    }
}
