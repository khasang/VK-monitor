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
        Mock<IVkRepository> mockRepository;
        Mock<ILogger> mockLogger;
        Mock<IReport> mockReport;

        [TestInitialize()]
        public void Setup()
        {
            mockRepository = new Mock<IVkRepository>();
            mockLogger = new Mock<ILogger>();
            mockReport = new Mock<IReport>();
            mockReport.Setup(r => r.GetData(mockRepository.Object, It.IsAny<ulong>())).Returns("report");
        }

        [TestMethod]
        public void GetReportData_InteractionRepository_RightReport()
        {
           IVKhandle vk = new VkHandle(mockRepository.Object, mockLogger.Object);
            object report = vk.GetReportData(mockReport.Object, 12345);

            mockReport.Verify(m => m.GetData(mockRepository.Object, 12345));
            Assert.AreEqual(report, "report");
        }

        [TestMethod]
        public void Test()
        {
            
        }
    }    
}
