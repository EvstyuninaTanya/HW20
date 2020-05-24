using HW20.Business_object;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW20.service.ui
{
    class NorthWindService
    {
        public static GotoMyProduct GotoAllProducts(AvtorizateData avtorize, Headers headers, IWebDriver driver)
        {
            Login log = new Login(driver);
            AllProducts products = log.SetLogin(avtorize);
            AllProducts products2 = log.SetPassword(avtorize);
            return products.ClickOnNorthWind(headers);
        }
        public static AllProducts GotoHomePage(AvtorizateData avtorize, IWebDriver driver)
        {
            Login log = new Login(driver);
            AllProducts products = log.SetLogin(avtorize);
            return log.SetPassword(avtorize);
        }
    }
}
