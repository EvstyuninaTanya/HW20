using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW20
{
    class AllProducts
    {
        private IWebDriver driver;
        public AllProducts(IWebDriver driver)
        {
            this.driver = driver;
        }


        public GotoPage ClickOnNorthWind(string nw)
        {
            new Actions(driver).Click(driver.FindElement(By.XPath($"(//a[contains(text(), \"{nw}\")])[2]"))).Build().Perform();
            return new GotoPage(driver);
        }
    }
}
