using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VK_Monitor.BusinessLogic;
using VkNet;
using VK_Monitor.BusinessLogic.Interfaces;

namespace VK_Monitor.UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IVKhandle vk = new VKhandle(34234, "adminId", "Password");

            Assert.IsInstanceOfType(vk.GetVKHandler(), typeof(VkApi));
        }
    }
}
