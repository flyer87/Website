using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    [TestClass]
    public class TestGoogle
    {
        IWebDriver driver = new ChromeDriver();

        [TestInitialize]
        public void Intialize()
        {
            var urlToGo = "https:www.google.com";
            driver.Navigate().GoToUrl(urlToGo);
        }

        [TestMethod]
        public void TestSearch()
        {
            IWebElement el = driver.FindElement(By.Name("q"));
            el.SendKeys("netcompany dk");
            el.SendKeys(Keys.Enter);

            Thread.Sleep(1000);
            Console.WriteLine("Test done");
        }

        [TestCleanup]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
        }
    }
}

