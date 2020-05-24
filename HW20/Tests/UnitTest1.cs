using HW20.Business_object;
using HW20.service.ui;
using HW20.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace HW20
{
    public class UnitTest: BaseTest
    {
        private Login log;
        private AllProducts products;
        private Logout logout;
        private GotoMyProduct gotoMyProduct;
        private ValueFields valueFields;
        private AddField addField;

        [Test]
        public void LoginTest()
        {
            products = NorthWindService.GotoHomePage(avtorivateData, driver);
            valueFields = new ValueFields(driver);
            NUnit.Framework.Assert.AreEqual(headers.HeaderHP, valueFields.GetHeader());
        }
        [Test]
        public void AddProductTest()
        {
            gotoMyProduct = NorthWindService.GotoAllProducts(avtorivateData, headers, driver);
            driver.FindElement(By.CssSelector(".btn")).Click();
            addField = new AddField(driver);
            addField.SetPrName(rosemary);
            addField.SetCat(rosemary);
            addField.SetSup(rosemary);
            addField.SetPrice(rosemary);
            addField.SetQuantity(rosemary);
            addField.SetStock(rosemary);
            addField.SetOrder(rosemary);
            addField.SetLvl(rosemary);
            valueFields = new ValueFields(driver);
            NUnit.Framework.Assert.AreEqual(headers.allproducts, valueFields.GetHeader());
        }

        [Test]
        public void FieldValueTest()
        {
            gotoMyProduct = NorthWindService.GotoAllProducts(avtorivateData, headers, driver);
            gotoMyProduct.ClickOnNorthWind3(rosemary);
            valueFields = new ValueFields(driver);
            NUnit.Framework.Assert.AreEqual(rosemary.productName, valueFields.GetPrNameId());
            NUnit.Framework.Assert.AreEqual(rosemary.category, valueFields.GetCatId());
            NUnit.Framework.Assert.AreEqual(rosemary.supplier, valueFields.GetSupID());
            NUnit.Framework.Assert.AreEqual(rosemary.searchUnitPrice, valueFields.GetPriceId());
            NUnit.Framework.Assert.AreEqual(rosemary.quantityPerUnit, valueFields.GetQuantityId());
            NUnit.Framework.Assert.AreEqual(rosemary.unitsInStock, valueFields.GetStockId());
            NUnit.Framework.Assert.AreEqual(rosemary.unitsOnOrder, valueFields.GetOrderId());
            NUnit.Framework.Assert.AreEqual(rosemary.reorderLvl, valueFields.GetLvlId());
        }

        [Test]
        public void LogoutTest()
        {
            products = NorthWindService.GotoHomePage(avtorivateData, driver);
            logout = new Logout(driver);
            logout.ClickOnNorthWind2(headers);
            valueFields = new ValueFields(driver);
            NUnit.Framework.Assert.AreEqual(headers.HeaderLogin, valueFields.GetHeader());
        }
    }
}