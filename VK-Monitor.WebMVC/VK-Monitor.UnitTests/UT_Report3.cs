using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VK_Monitor.BusinessLogic;
using Moq;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain.Models;

namespace VK_Monitor.UnitTests
{
    [TestClass]
    public class UT_Report3
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<IVkService> mockRepository = new Mock<IVkService>();

            var report3 = new Report3();
            var report = report3.GetData(mockRepository.Object, It.IsAny<ulong>());

            Assert.IsInstanceOfType(report, typeof(ReportModel));
        }
    }
}
