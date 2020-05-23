using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW20
{
    class Login
    {
        private IWebDriver driver;
        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement searchLogName => driver.FindElement(By.Id("Name"));
        private IWebElement searchPassword => driver.FindElement(By.Id("Password"));
        private IWebElement searchButton => driver.FindElement(By.CssSelector(".btn"));

        public AllProducts SetLogin(string login)
        {
            new Actions(driver).Click(searchLogName).SendKeys(login).Build().Perform();
            return new AllProducts(driver);
        }
        public AllProducts SetPassword(string password)
        {
            new Actions(driver).Click(searchPassword).SendKeys(password).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
            return new AllProducts(driver);
        }
    }
}
