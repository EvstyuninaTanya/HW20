using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW20
{
    class GotoPage
    {
        private IWebDriver driver;
        public GotoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnNorthWind2(string nw)
        {
            new Actions(driver).Click(driver.FindElement(By.XPath($"(//a[contains(text(), \"{nw}\")])"))).Build().Perform();
        }
    }
}
