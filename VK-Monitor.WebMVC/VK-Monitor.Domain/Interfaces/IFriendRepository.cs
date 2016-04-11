using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain.Entities;

namespace VK_Monitor.Domain.Interfaces
{
    public interface IFriendRepository : IRepository<Friend>
    {
        IEnumerable<Friend> GetByOwnerId(long vkId);
    }
}
