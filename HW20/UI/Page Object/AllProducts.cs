using HW20.Business_object;
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


        public GotoMyProduct ClickOnNorthWind(Headers nw)
        {
            new Actions(driver).Click(driver.FindElement(By.XPath($"(//a[contains(text(), \"{nw.allproducts}\")])[2]"))).Build().Perform();
            return new GotoMyProduct(driver);
        }
    }
}
