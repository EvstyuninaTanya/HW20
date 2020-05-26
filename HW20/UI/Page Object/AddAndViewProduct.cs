using HW20.Business_object;
using HW20.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW20
{
    class AddAndViewProduct
    {
        private IWebDriver driver;
        public AddAndViewProduct(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement header => driver.FindElement(By.CssSelector("h2"));
        private IWebElement productNameId => driver.FindElement(By.Id("ProductName"));
        private IWebElement categoryId => driver.FindElement(By.Id("CategoryId"));
        private IWebElement supplierId => driver.FindElement(By.Id("SupplierId"));
        private IWebElement unitPriceId => driver.FindElement(By.Id("UnitPrice"));
        private IWebElement quantityPerUnitId => driver.FindElement(By.Id("QuantityPerUnit"));
        private IWebElement unitsInStockId => driver.FindElement(By.Id("UnitsInStock"));
        private IWebElement unitsOnOrderId => driver.FindElement(By.Id("UnitsOnOrder"));
        private IWebElement reorderlevelId => driver.FindElement(By.Id("ReorderLevel"));
        private IWebElement searchButton => driver.FindElement(By.CssSelector(".btn"));
        public void SetPrName(Product prName)
        {
            new Actions(driver).Click(productNameId).SendKeys(prName.productName).Build().Perform();
        }
        public void SetCat(Product cat)
        {
            new Actions(driver).Click(categoryId).Build().Perform();
            new Actions(driver).SendKeys(cat.cat).Build().Perform();
        }
        public void SetSup(Product sup)
        {
            new Actions(driver).Click(supplierId).Build().Perform();
            new Actions(driver).SendKeys(sup.sup).Build().Perform();
        }
        public void SetPrice(Product price)
        {
            new Actions(driver).Click(unitPriceId).SendKeys(price.setUnitPrice).Build().Perform();
        }
        public void SetQuantity(Product quantity)
        {
            new Actions(driver).Click(quantityPerUnitId).SendKeys(quantity.quantityPerUnit).Build().Perform();
        }
        public void SetStock(Product stock)
        {
            new Actions(driver).Click(unitsInStockId).SendKeys(stock.unitsInStock).Build().Perform();
        }
        public void SetOrder(Product order)
        {
            new Actions(driver).Click(unitsOnOrderId).SendKeys(order.unitsOnOrder).Build().Perform();
        }
        public void SetLvl(Product lvl)
        {
            new Actions(driver).Click(reorderlevelId).SendKeys(lvl.reorderLvl).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
        }
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