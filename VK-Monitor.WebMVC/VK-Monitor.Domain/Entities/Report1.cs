﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain.Interfaces;
using VkNet;

namespace VK_Monitor.Domain.Entities
{
    public class Report1 : IReport
    {
        public override object GetData(VkApi vk, ulong userId)
        {
            throw new NotImplementedException();
        }
    }
}
