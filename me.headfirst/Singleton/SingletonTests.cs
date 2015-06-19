using System;
using System.Threading;
using NUnit.Framework;

namespace me.headfirst.Singleton
{
    public class SingletonTests
    {
        [Test]
        public void SingletonGetInstanceTest()
        {
            var instance = Singleton.GetInstance();
            Thread.Sleep(5000);
            var instance2 = Singleton.GetInstance();
            Assert.AreEqual(instance.CreatedDateTime, instance2.CreatedDateTime);
        }
    }
}
