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
        public Product rosemary = new Product("ProductName", "CategoryId", "SupplierId", "UnitPrice", "QuantityPerUnit", "UnitsInStock", "UnitsOnOrder", "ReorderLevel");
        private const string head = "h2";


        public ValueFields(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement header => driver.FindElement(By.CssSelector(head));
        private IWebElement prNameId => driver.FindElement(By.Id(rosemary.productNameId));
        private IWebElement catId => driver.FindElement(By.Id(rosemary.categoryId));
        private IWebElement supId => driver.FindElement(By.Id(rosemary.supplierId));
        private IWebElement priceId => driver.FindElement(By.Id(rosemary.unitPriceId));
        private IWebElement quantityId => driver.FindElement(By.Id(rosemary.quantityPerUnitId));
        private IWebElement stockId => driver.FindElement(By.Id(rosemary.unitsInStockId));
        private IWebElement orderId => driver.FindElement(By.Id(rosemary.unitsOnOrderId));
        private IWebElement lvlId => driver.FindElement(By.Id(rosemary.reorderLvlId));

        public string GetHeader()
        {
            return header.Text;
        }
        public string GetPrNameId()
        {
            return prNameId.GetAttribute("value");
        }
        public string GetCatId()
        {
            return catId.GetAttribute("value");
        }
        public string GetSupID()
        {
            return supId.GetAttribute("value");
        }
        public string GetPriceId()
        {
            return priceId.GetAttribute("value");
        }
        public string GetQuantityId()
        {
            return quantityId.GetAttribute("value");
        }
        public string GetStockId()
        {
            return stockId.GetAttribute("value");
        }
        public string GetOrderId()
        {
            return orderId.GetAttribute("value");
        }
        public string GetLvlId()
        {
            return lvlId.GetAttribute("value");
        }
    }
}
