using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK_Monitor.Domain.Entities
{
    public class TargetUser
    {
        public int Id { get; set; }
        public long VkId { get; set; }
        public DateTime Date { get; set; }

        public string OwnerId { get; set; }
        public virtual ApplicationUser Owner { get; set; }

        public virtual ICollection<Subscriber> Subscribers { get; set; }
    }
}
