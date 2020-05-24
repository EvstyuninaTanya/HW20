using HW20.Business_object;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW20
{
    class GotoMyProduct
    {
        private IWebDriver driver;
        public GotoMyProduct(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickOnNorthWind3(Product nw)
        {
            new Actions(driver).Click(driver.FindElement(By.XPath($"(//a[contains(text(), \"{nw.productName}\")])"))).Build().Perform();
        }
    }
}
