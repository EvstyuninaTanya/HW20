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
        public Product rosemary = new Product("ProductName", "Rosemary",
                                              "CategoryId", "1", "Beverages",
                                              "SupplierId", "16", "Bigfoot Breweries",
                                              "UnitPrice", "17", "17,0000",
                                              "QuantityPerUnit", "2 boxes",
                                              "UnitsInStock", "23",
                                              "UnitsOnOrder", "40",
                                              "ReorderLevel", "10");
        public Headers headers = new Headers("All Products", "Home page", "Login", "Logout");
        public AvtorizateData avtorivateData = new AvtorizateData("user", "user");
    }
}
