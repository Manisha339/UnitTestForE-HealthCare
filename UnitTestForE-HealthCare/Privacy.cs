using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestForE_HealthCare
{
    [TestClass]
    public class Privacy
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://localhost:44377/");
                var regTitle = driver.PageSource.Contains("Privacy");
                Assert.IsTrue(regTitle);
                var PrivacyButton = driver.FindElementById("privacy");
                Assert.IsNotNull(PrivacyButton);
                PrivacyButton.Click();



            }
        }
    }
}
