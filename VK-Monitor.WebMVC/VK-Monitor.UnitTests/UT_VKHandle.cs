using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VK_Monitor.BusinessLogic;
using VkNet;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain.Entities;
using VK_Monitor.Domain.Interfaces;
using Moq;
using System.Collections.Generic;
using Serilog;

namespace VK_Monitor.UnitTests
{
    [TestClass]
    public class UT_VKHandle
    {
        [TestMethod]
        public void TestMethod1()
        {
            ulong userId = 12345;

            ulong applicationId = 11111;
            string adminId = "22222";
            string adminPassword = "qqqqqq";

            var mockRepository = new Mock<IVkRepository>();

            mockRepository.Setup(u => u.Users(userId)).Returns(new Dictionary<string, IList<string>>());
            mockRepository.Verify(a => a.Authorize(applicationId, adminId, adminPassword));

            var mockLogger = new Mock<ILogger>();

            var mockReport = new Mock<IReport>();
            mockReport.Setup(g => g.GetData(mockRepository.Object, userId)).Returns("report");

            IVKhandle vk = new VkHandle(mockRepository.Object, mockLogger.Object);

            object report = vk.GetReportData(mockReport.Object, userId);

            Assert.AreEqual(report as string, "report");
        }

        [TestMethod]
        public void GetReportData_InteractionRepository_RightReport()
        {
            ulong userId = 12345;
            var mockLogger = new Mock<ILogger>();
            var mockRepository = new Mock<IVkRepository>();
            var mockReport = new Mock<IReport>();

            mockReport.Setup(g => g.GetData(mockRepository.Object, userId)).Returns("report");

            IVKhandle vk = new VkHandle(mockRepository.Object, mockLogger.Object);

            object report = vk.GetReportData(mockReport.Object, userId);

            Assert.AreEqual(report, "report");
        }

        [TestMethod]
        public void Test()
        {

        }
    }    
}
