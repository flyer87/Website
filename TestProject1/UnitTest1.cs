using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();

        [TestInitialize]
        public void Intialize()
        {
            driver.Navigate().GoToUrl("https://localhost:51020");

        }

        [TestMethod]
        public void ExecuteTest2()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Contact")).Click();
            Thread.Sleep(2000);
            return;
        }

        [TestCleanup]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
        }
    }
}
