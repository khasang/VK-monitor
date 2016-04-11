using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK_Monitor.Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public Group OwnerGroup { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public TargetUser  OwnerUser { get; set; }
        public int Like { get; set;}
    }
}
