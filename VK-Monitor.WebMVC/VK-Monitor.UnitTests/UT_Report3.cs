using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VK_Monitor.BusinessLogic;
using Moq;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain.Models;
using VK_Monitor.Domain.Interfaces;
using System.Collections.Generic;
using VK_Monitor.Domain.Entities;

namespace VK_Monitor.UnitTests
{
    [TestClass]
    public class UT_Report3
    {
        [TestMethod]
        public void AnswerReport()
        {
            Mock<ISubscriberRepository> mockSubscriberRepository = new Mock<ISubscriberRepository>();
            mockSubscriberRepository.Setup(r => r.GetAll())
                                    .Returns(() =>
                                    {
                                        List<Subscriber> subscriber = new List<Subscriber>();

                                        subscriber.Add(new Subscriber { VkId = 12345, OwnerId = 11111, Date = DateTime.Today });
                                        subscriber.Add(new Subscriber { VkId = 23456, OwnerId = 11111, Date = DateTime.Today });
                                        subscriber.Add(new Subscriber { VkId = 34567, OwnerId = 22222, Date = DateTime.Today });
                                        subscriber.Add(new Subscriber { VkId = 45678, OwnerId = 11111, Date = new DateTime(2000, 1, 1) });
                                        subscriber.Add(new Subscriber { VkId = 56789, OwnerId = 22222, Date = new DateTime(2000, 1, 1) });

                                        return subscriber;
                                    });

            Mock<IDataManager>  mockDataManager = new Mock<IDataManager>();
            mockDataManager.Setup(r => r.Subscribers).Returns(() => mockSubscriberRepository.Object);

            var report3 = new Report3();
            var report = report3.GetData(mockDataManager.Object, 11111);
            var list = report.Answer["subscribers"] as List<Subscriber>;

            Assert.AreEqual(list.Count, 2);
            Assert.AreEqual(list[0].VkId, 12345);
            Assert.AreEqual(list[1].VkId, 23456);
        }
    }
}
