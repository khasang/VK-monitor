using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain.Interfaces;
using System.Collections;
using VK_Monitor.Domain.Entities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using VkNet.Model;
using VK_Monitor.CrawlerConsole;

namespace VK_Monitor.UnitTests
{
    [TestClass]
    public class UT_Work
    {
        Mock<IVkService> mockVkService;
        Mock<IDataManager> mockDataManager;
        Mock<ISubscriberRepository> mockSubscriberRepository;
        Mock<TargetUser> mockTargetUser;

        //[TestInitialize()]
        //public void Setup()
        //{
        //    mockVkService = new Mock<IVkService>();
        //    mockVkService.Setup(r => r.GetFollowers())
        //                 .Returns(() =>
        //                          {
        //                              IList<User> subscriber = new List<User>();
        //                              subscriber.Add(new User { Id = 12345 });
        //                              subscriber.Add(new User { Id = 23456 });
        //                              subscriber.Add(new User { Id = 34567 });
        //                              subscriber.Add(new User { Id = 45678 });
        //                              subscriber.Add(new User { Id = 56789 });
        //                              subscriber.Add(new User { Id = 67890 });

        //                              return new ReadOnlyCollection<User>(subscriber);
        //                          });

        //    mockSubscriberRepository = new Mock<ISubscriberRepository>();
        //    mockSubscriberRepository.Setup(r => r.GetAll())
        //                            .Returns(() =>
        //                            {
        //                                List<Subscriber> subscriber = new List<Subscriber>();

        //                                subscriber.Add(new Subscriber { VkId = 12345 });
        //                                subscriber.Add(new Subscriber { VkId = 23456 });
        //                                subscriber.Add(new Subscriber { VkId = 34567 });
        //                                subscriber.Add(new Subscriber { VkId = 45678 });
        //                                subscriber.Add(new Subscriber { VkId = 56789 });

        //                                return subscriber;
        //                            });

        //    mockDataManager = new Mock<IDataManager>();
        //    mockDataManager.Setup(r => r.Subscribers).Returns(() => mockSubscriberRepository.Object);

        //    mockTargetUser = new Mock<TargetUser>();
        //    mockTargetUser.Setup(t => t.Subscribers).Returns(() =>
        //    {
        //        List<Subscriber> subscriber = new List<Subscriber>();

        //        subscriber.Add(new Subscriber { VkId = 12345 });
        //        subscriber.Add(new Subscriber { VkId = 23456 });
        //        subscriber.Add(new Subscriber { VkId = 34567 });
        //        subscriber.Add(new Subscriber { VkId = 45678 });
        //        subscriber.Add(new Subscriber { VkId = 56789 });

        //        return subscriber;
        //    });
        //}

        
    }
}
