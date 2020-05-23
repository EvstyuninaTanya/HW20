using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW20
{
    class AddField: Const
    {
        private IWebDriver driver;
        public AddField(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement prNameId => driver.FindElement(By.Id(prodactNameId));
        private IWebElement catId => driver.FindElement(By.Id(categoryId));
        private IWebElement supId => driver.FindElement(By.Id(supplierId));
        private IWebElement priceId => driver.FindElement(By.Id(unitPriceId));
        private IWebElement quantityId => driver.FindElement(By.Id(quantityPerUnitId));
        private IWebElement stockId => driver.FindElement(By.Id(unitsInStockId));
        private IWebElement orderId => driver.FindElement(By.Id(unitsOnOrderId));
        private IWebElement lvlId => driver.FindElement(By.Id(reorderLvlId));
        private IWebElement searchButton => driver.FindElement(By.CssSelector(".btn"));
        public void SetPrName(string prName)
        {
            new Actions(driver).Click(prNameId).SendKeys(prName).Build().Perform();
        }
        public void SetCat(string cat)
        {
            new Actions(driver).Click(catId).Build().Perform();
            //new Actions(driver).Click(driver.FindElement(By.XPath($"(//option[contains(text(), \"{cat}\")])"))).Build().Perform();
            driver.FindElement(By.XPath($"(//option[contains(text(), \"{cat}\")])")).Click();
        }
        public void SetSup(string sup)
        {
            new Actions(driver).Click(supId).Build().Perform();
            //new Actions(driver).Click(driver.FindElement(By.XPath($"(//option[contains(text(), \"{sup}\")])"))).Build().Perform();
            driver.FindElement(By.XPath($"(//option[contains(text(), \"{sup}\")])")).Click();
        }
        public void SetPrice(string price)
        {
            new Actions(driver).Click(priceId).SendKeys(price).Build().Perform();
        }
        public void SetQuantity(string quantity)
        {
            new Actions(driver).Click(quantityId).SendKeys(quantity).Build().Perform();
        }
        public void SetStock(string stock)
        {
            new Actions(driver).Click(stockId).SendKeys(stock).Build().Perform();
        }
        public void SetOrder(string order)
        {
            new Actions(driver).Click(orderId).SendKeys(order).Build().Perform();
        }
        public void SetLvl(string lvl)
        {
            new Actions(driver).Click(lvlId).SendKeys(lvl).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
        }
    }
}