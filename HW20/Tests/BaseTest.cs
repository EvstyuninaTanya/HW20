using HW20.Business_object;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW20.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        [SetUp]
        public void TestFixtureSetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [TearDown]
        public void TestFixtureTearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
