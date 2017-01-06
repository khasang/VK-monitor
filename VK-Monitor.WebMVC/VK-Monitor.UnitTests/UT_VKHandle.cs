﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VK_Monitor.BusinessLogic;
using VkNet;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain.Entities;
using Moq;
using System.Collections.Generic;
using Serilog;
using VK_Monitor.Domain.Models;

namespace VK_Monitor.UnitTests
{
    [TestClass]
    public class UT_VkHandle
    {
        Mock<IVkService> mockVkService;
        Mock<ILogger> mockLogger;
        Mock<IReport> mockReport;
        IVKhandle vk;
        ulong targetId;

        [TestInitialize()]
        public void Setup()
        {
            mockVkService = new Mock<IVkService>();
            mockLogger = new Mock<ILogger>();
            mockReport = new Mock<IReport>();

            mockReport.Setup(r => r.GetData(mockVkService.Object, It.IsAny<ulong>()))
                      .Returns(() =>
                      {
                          Dictionary<string, object> answer = new Dictionary<string, object>();
                          answer.Add("Report", "any report");
                          return new ReportModel { Answer = answer };
                      });

            vk = new VkHandle(mockVkService.Object);
            targetId = (ulong)12345;
        }

        [TestMethod]
        public void GetReportData_InteractionRepository_RightReport()
        {
            ReportModel report = vk.GetReportData(mockReport.Object, 12345);

            mockReport.Verify(m => m.GetData(mockVkService.Object, 12345));
            Assert.AreEqual(report.Answer["Report"], "any report");
        }

        [TestMethod]
        public void AddTarget_IncrementInTheList_void()
        {
            ulong targetId = (ulong)12345;

            vk.AddTarget(targetId);
            Assert.IsTrue(vk.GetTargets().Contains(targetId));
        }

        [TestMethod]
        public void DeletetTarget_DecrementInTheList_void()
        {
            vk.AddTarget(targetId);

            vk.DeleteTarget(targetId);
            Assert.IsFalse(vk.GetTargets().Contains(targetId));
        }
    }    
}
