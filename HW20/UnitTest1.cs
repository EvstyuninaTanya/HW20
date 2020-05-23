using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace HW20
{
    public class Tests
    {
        private IWebDriver driver;
        private Login log;
        private AllProducts products;
        private GotoPage gotoPage;
        private ValueFields valueFields;
        private AddField addField;
        private const string SetLogin = "user";
        private const string SetPassword = "user";
        private const string allproducts = "All Products";
        private const string productName = "Rosemary";
        private const string HeaderHP = "Home page";
        private const string HeaderLogin = "Login";
        private const string logout = "Logout";
        private const string category = "1";
        private const string cat = "Beverages";
        private const string supplier = "16";
        private const string sup = "Bigfoot Breweries";
        private const string unitPrice = "17";
        private const string unitPrice2 = "17,0000";
        private const string quantityPerUnit = "2 boxes";
        private const string unitsInStock = "23";
        private const string unitsOnOrder = "40";
        private const string reorderLvl = "10";

        [SetUp]
        public void TestFixtureSetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void LoginTest()
        {
            log = new Login(driver);
            log.SetLogin(SetLogin);
            log.SetPassword(SetPassword);
            valueFields = new ValueFields(driver);
            NUnit.Framework.Assert.AreEqual(HeaderHP, valueFields.GetHeader());
        }
        [Test]
        public void AddProductTest()
        {
            log = new Login(driver);
            products = log.SetLogin(SetLogin);
            products = log.SetPassword(SetPassword);
            products.ClickOnNorthWind(allproducts);
            driver.FindElement(By.CssSelector(".btn")).Click();
            addField = new AddField(driver);
            addField.SetPrName(productName);
            addField.SetCat(cat);
            addField.SetSup(sup);
            addField.SetPrice(unitPrice);
            addField.SetQuantity(quantityPerUnit);
            addField.SetStock(unitsInStock);
            addField.SetOrder(unitsOnOrder);
            addField.SetLvl(reorderLvl);
            valueFields = new ValueFields(driver);
            NUnit.Framework.Assert.AreEqual(allproducts, valueFields.GetHeader());
        }

        [Test]
        public void FieldValueTest()
        {
            log = new Login(driver);
            products = log.SetLogin(SetLogin);
            products = log.SetPassword(SetPassword);
            gotoPage = products.ClickOnNorthWind(allproducts);
            gotoPage.ClickOnNorthWind2(productName);
            valueFields = new ValueFields(driver);
            NUnit.Framework.Assert.AreEqual(productName, valueFields.GetPrNameId());
            NUnit.Framework.Assert.AreEqual(category, valueFields.GetCatId());
            NUnit.Framework.Assert.AreEqual(supplier, valueFields.GetSupID());
            NUnit.Framework.Assert.AreEqual(unitPrice2, valueFields.GetPriceId());
            NUnit.Framework.Assert.AreEqual(quantityPerUnit,valueFields.GetQuantityId());
            NUnit.Framework.Assert.AreEqual(unitsInStock, valueFields.GetStockId());
            NUnit.Framework.Assert.AreEqual(unitsOnOrder, valueFields.GetOrderId());
            NUnit.Framework.Assert.AreEqual(reorderLvl, valueFields.GetLvlId());
        }

        [Test]
        public void LogoutTest()
        {
            log = new Login(driver);
            products = log.SetLogin(SetLogin);
            products = log.SetPassword(SetPassword);
            gotoPage = products.ClickOnNorthWind(allproducts);
            gotoPage.ClickOnNorthWind2(logout);
            valueFields = new ValueFields(driver);
            NUnit.Framework.Assert.AreEqual(HeaderLogin, valueFields.GetHeader());
        }

        [TearDown]
        public void TestFixtureTearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}