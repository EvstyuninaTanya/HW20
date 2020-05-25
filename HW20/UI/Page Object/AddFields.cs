using HW20.Business_object;
using HW20.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW20
{
    class AddField
    {
        private IWebDriver driver;
        public Product rosemary = new Product("ProductName", "CategoryId", "SupplierId", "UnitPrice", "QuantityPerUnit", "UnitsInStock", "UnitsOnOrder","ReorderLevel");
        public AddField(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement prNameId => driver.FindElement(By.Id(rosemary.productNameId));
        private IWebElement catId => driver.FindElement(By.Id(rosemary.categoryId));
        private IWebElement supId => driver.FindElement(By.Id(rosemary.supplierId));
        private IWebElement priceId => driver.FindElement(By.Id(rosemary.unitPriceId));
        private IWebElement quantityId => driver.FindElement(By.Id(rosemary.quantityPerUnitId));
        private IWebElement stockId => driver.FindElement(By.Id(rosemary.unitsInStockId));
        private IWebElement orderId => driver.FindElement(By.Id(rosemary.unitsOnOrderId));
        private IWebElement lvlId => driver.FindElement(By.Id(rosemary.reorderLvlId));
        private IWebElement searchButton => driver.FindElement(By.CssSelector(".btn"));
        public void SetPrName(Product prName)
        {
            new Actions(driver).Click(prNameId).SendKeys(prName.productName).Build().Perform();
        }
        public void SetCat(Product cat)
        {
            new Actions(driver).Click(catId).Build().Perform();
            new Actions(driver).SendKeys(cat.cat).Build().Perform();
        }
        public void SetSup(Product sup)
        {
            new Actions(driver).Click(supId).Build().Perform();
            new Actions(driver).SendKeys(sup.sup).Build().Perform();
        }
        public void SetPrice(Product price)
        {
            new Actions(driver).Click(priceId).SendKeys(price.setUnitPrice).Build().Perform();
        }
        public void SetQuantity(Product quantity)
        {
            new Actions(driver).Click(quantityId).SendKeys(quantity.quantityPerUnit).Build().Perform();
        }
        public void SetStock(Product stock)
        {
            new Actions(driver).Click(stockId).SendKeys(stock.unitsInStock).Build().Perform();
        }
        public void SetOrder(Product order)
        {
            new Actions(driver).Click(orderId).SendKeys(order.unitsOnOrder).Build().Perform();
        }
        public void SetLvl(Product lvl)
        {
            new Actions(driver).Click(lvlId).SendKeys(lvl.reorderLvl).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
        }
    }
}