using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestForE_HealthCare
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://localhost:44377/");
                var regTitle = driver.PageSource.Contains("Login");
                Assert.IsTrue(regTitle);
                var loginButton = driver.FindElementById("login");
                Assert.IsNotNull(loginButton);
                loginButton.Click();
                var loginButton1 = driver.FindElementById("log");
                Assert.IsNotNull(loginButton1);
                loginButton1.Click();
                var regTitle1 = driver.PageSource.Contains("Add To Cart");
                Assert.IsTrue(regTitle1);
            }
        }
    }
}
