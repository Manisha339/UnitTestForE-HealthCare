using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestForE_HealthCare
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class Register
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://localhost:44377/");
                var regTitle = driver.PageSource.Contains("Register");
                Assert.IsTrue(regTitle);
                var RegisterButton = driver.FindElementById("register");
                Assert.IsNotNull(RegisterButton);
                RegisterButton.Click();
                var RegisterButton1 = driver.FindElementById("reg");
                Assert.IsNotNull(RegisterButton1);
                RegisterButton1.Click();
                var regTitle1 = driver.PageSource.Contains("Add To Cart");
                Assert.IsTrue(regTitle1);
            }
        }
    }
}
