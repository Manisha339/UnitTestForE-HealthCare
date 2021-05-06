using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestForE_HealthCare
{
    [TestClass]
    public class Home
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://localhost:44377/");
                var regTitle = driver.PageSource.Contains("Home");
                Assert.IsTrue(regTitle);
                var HomeButton = driver.FindElementById("home");
                Assert.IsNotNull(HomeButton);
                HomeButton.Click();
                var HomeButton1 = driver.FindElementById("home");
                Assert.IsNotNull(HomeButton1);
                HomeButton1.Click();
                var regTitle1 = driver.PageSource.Contains("Add To Cart");
                Assert.IsTrue(regTitle1);
            }
        }
    }
}
