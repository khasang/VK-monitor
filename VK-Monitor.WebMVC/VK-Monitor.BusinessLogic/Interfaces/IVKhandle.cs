using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;

namespace VK_Monitor.BusinessLogic.Interfaces
{
    public interface IVKhandle
    {
        VkApi GetVKHandler();
    }
}
