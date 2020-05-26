using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HW20.Business_object;
using HW20.Tests;

namespace HW20
{
    class ValueFields
    {
        private IWebDriver driver;
        private const string head = "h2";


        public ValueFields(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement header => driver.FindElement(By.CssSelector(head));
        private IWebElement productNameId => driver.FindElement(By.Id("ProductName"));
        private IWebElement categoryId => driver.FindElement(By.Id("CategoryId"));
        private IWebElement supplierId => driver.FindElement(By.Id("SupplierId"));
        private IWebElement unitPriceId => driver.FindElement(By.Id("UnitPrice"));
        private IWebElement quantityPerUnitId => driver.FindElement(By.Id("QuantityPerUnit"));
        private IWebElement unitsInStockId => driver.FindElement(By.Id("UnitsInStock"));
        private IWebElement unitsOnOrderId => driver.FindElement(By.Id("UnitsOnOrder"));
        private IWebElement reorderlevelId => driver.FindElement(By.Id("ReorderLevel"));

        public string GetHeader()
        {
            return header.Text;
        }
        public string GetPrNameId()
        {
            return productNameId.GetAttribute("value");
        }
        public string GetCatId()
        {
            return categoryId.GetAttribute("value");
        }
        public string GetSupID()
        {
            return supplierId.GetAttribute("value");
        }
        public string GetPriceId()
        {
            return unitPriceId.GetAttribute("value");
        }
        public string GetQuantityId()
        {
            return quantityPerUnitId.GetAttribute("value");
        }
        public string GetStockId()
        {
            return unitsInStockId.GetAttribute("value");
        }
        public string GetOrderId()
        {
            return unitsOnOrderId.GetAttribute("value");
        }
        public string GetLvlId()
        {
            return reorderlevelId.GetAttribute("value");
        }
    }
}
