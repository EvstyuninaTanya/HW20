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
    class UnitTest: BaseTest
    {
        private AllProducts products;
        private Logout logout;
        private GotoMyProduct gotoMyProduct;
        private AddAndViewProduct addAndViewProduct;
        public Product rosemary = new Product("Rosemary", "1", "Beverages", "16", "Bigfoot Breweries","17", "17,0000", "2 boxes", "23", "40","10");
        public Headers headers = new Headers("All Products", "Home page", "Login", "Logout");
        public AvtorizateData avtorivateData = new AvtorizateData("user", "user");

        [Test]
        public void LoginTest()
        {
            products = NorthWindService.GotoHomePage(avtorivateData, driver);
            addAndViewProduct = new AddAndViewProduct(driver);
            NUnit.Framework.Assert.AreEqual(headers.HeaderHP, addAndViewProduct.GetHeader());
        }
        [Test]
        public void AddProductTest()
        {
            gotoMyProduct = NorthWindService.GotoAllProducts(avtorivateData, headers, driver);
            products = new AllProducts(driver);
            products.ClickOnCreate();
            addAndViewProduct = new AddAndViewProduct(driver);
            addAndViewProduct.SetPrName(rosemary);
            addAndViewProduct.SetCat(rosemary);
            addAndViewProduct.SetSup(rosemary);
            addAndViewProduct.SetPrice(rosemary);
            addAndViewProduct.SetQuantity(rosemary);
            addAndViewProduct.SetStock(rosemary);
            addAndViewProduct.SetOrder(rosemary);
            addAndViewProduct.SetLvl(rosemary);
            addAndViewProduct = new AddAndViewProduct(driver);
            NUnit.Framework.Assert.AreEqual(headers.allproducts, addAndViewProduct.GetHeader());
        }

        [Test]
        public void FieldValueTest()
        {
            gotoMyProduct = NorthWindService.GotoAllProducts(avtorivateData, headers, driver);
            gotoMyProduct.ClickOnNorthWind3(rosemary);
            addAndViewProduct = new AddAndViewProduct(driver);
            NUnit.Framework.Assert.AreEqual(rosemary.productName, addAndViewProduct.GetPrNameId());
            NUnit.Framework.Assert.AreEqual(rosemary.category, addAndViewProduct.GetCatId());
            NUnit.Framework.Assert.AreEqual(rosemary.supplier, addAndViewProduct.GetSupID());
            NUnit.Framework.Assert.AreEqual(rosemary.searchUnitPrice, addAndViewProduct.GetPriceId());
            NUnit.Framework.Assert.AreEqual(rosemary.quantityPerUnit, addAndViewProduct.GetQuantityId());
            NUnit.Framework.Assert.AreEqual(rosemary.unitsInStock, addAndViewProduct.GetStockId());
            NUnit.Framework.Assert.AreEqual(rosemary.unitsOnOrder, addAndViewProduct.GetOrderId());
            NUnit.Framework.Assert.AreEqual(rosemary.reorderLvl, addAndViewProduct.GetLvlId());
        }

        [Test]
        public void LogoutTest()
        {
            products = NorthWindService.GotoHomePage(avtorivateData, driver);
            logout = new Logout(driver);
            logout.ClickOnNorthWind2(headers);
            addAndViewProduct = new AddAndViewProduct(driver);
            NUnit.Framework.Assert.AreEqual(headers.HeaderLogin, addAndViewProduct.GetHeader());
        }
    }
}