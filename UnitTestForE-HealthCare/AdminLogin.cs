using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestForE_HealthCare
{
    [TestClass]
    public class AdminLogin
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://localhost:44377/");
                var regTitle = driver.PageSource.Contains("Admin Login");
                Assert.IsTrue(regTitle);
                var AdminButton = driver.FindElementById("adminlogin");
                Assert.IsNotNull(AdminButton);
                AdminButton.Click();
                var AdminButton1 = driver.FindElementById("admin");
                Assert.IsNotNull(AdminButton1);
                AdminButton1.Click();


            }
        }
    }
}
