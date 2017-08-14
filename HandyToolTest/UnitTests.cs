using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HandyTool;
using Common;

namespace HandyToolTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void getIPTest()
        {
            String ip = Common.Common.GetLocalIPAddress();
            //Comment this out for CI builds
            //Assert.AreEqual(ip, "192.168.1.71");
            Console.WriteLine(ip);            
        }
    }
}
