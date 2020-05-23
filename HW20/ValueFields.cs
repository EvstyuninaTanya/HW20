using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace HW20
{
    class ValueFields: Const
    {
        private IWebDriver driver;
        private const string head = "h2";
        public ValueFields(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement header => driver.FindElement(By.CssSelector(head));
        private IWebElement prNameId => driver.FindElement(By.Id(prodactNameId));
        private IWebElement catId => driver.FindElement(By.Id(categoryId));
        private IWebElement supId => driver.FindElement(By.Id(supplierId));
        private IWebElement priceId => driver.FindElement(By.Id(unitPriceId));
        private IWebElement quantityId => driver.FindElement(By.Id(quantityPerUnitId));
        private IWebElement stockId => driver.FindElement(By.Id(unitsInStockId));
        private IWebElement orderId => driver.FindElement(By.Id(unitsOnOrderId));
        private IWebElement lvlId => driver.FindElement(By.Id(reorderLvlId));

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
