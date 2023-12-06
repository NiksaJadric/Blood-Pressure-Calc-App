// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Remote;
//using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace SeleniumTests
{

    [TestFixture]
    public class SeleniumBPCNiksastagingTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void seleniumBPCNiksastaging()
        {
            driver.Navigate().GoToUrl("https://bpc-niksa-staging.azurewebsites.net/");
            driver.Manage().Window.Size = new System.Drawing.Size(1227, 853);
            {
                var element = driver.FindElement(By.CssSelector("html"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector("html"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector("html"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.CssSelector("html")).Click();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("110");
            {
                var element = driver.FindElement(By.CssSelector("html"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector("html"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector("html"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.CssSelector("html")).Click();
            driver.FindElement(By.Id("BP_Diastolic")).SendKeys("65");
            driver.FindElement(By.CssSelector(".btn")).Click();
            {
                var element = driver.FindElement(By.CssSelector("body"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector("body"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector("body"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("150");
            {
                var element = driver.FindElement(By.CssSelector("html"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector("html"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector("html"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.CssSelector("html")).Click();
            driver.FindElement(By.Id("BP_Diastolic")).SendKeys("80");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.Close();
        }
    }

}
