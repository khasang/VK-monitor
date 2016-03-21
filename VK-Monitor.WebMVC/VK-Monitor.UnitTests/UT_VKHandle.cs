using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VK_Monitor.BusinessLogic;
using VkNet;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain.Entities;

namespace VK_Monitor.UnitTests
{
    [TestClass]
    public class UT_VKHandle
    {
        [TestMethod]
        public void TestMethod1()
        {
            IVKhandle vk = new VkHandle(new FakeVkRepository(), new FakeLogger());

            object report = vk.GetReportData(new Report1(), 12345);
        }
    }
}
