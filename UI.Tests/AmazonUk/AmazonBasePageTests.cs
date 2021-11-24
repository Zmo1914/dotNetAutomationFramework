﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Framework.DriverSetup;
using UI.Pages.AmazonPages.Main;
using UI.Pages.AmazonPages.ProductDetails;
using UI.Pages.AmazonPages.ShoppingBasket;
using UI.Pages.AmazonSections.Header;

namespace UI.Tests.AmazonUk
{
    public class AmazonBasePageTests
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        protected MainPage mainPage;
        protected ProductDetailsPage productDetailsPage;
        protected ShoppingBasketPage shoppingBasketPage;

        [SetUp]
        public void TestSetup()
        {
            driver = BasePage.Start(Browser.Chrome);

            mainPage = new MainPage(driver);
            productDetailsPage = new ProductDetailsPage(driver);
            shoppingBasketPage = new ShoppingBasketPage(driver);

            mainPage.LoginAmazonUk("https://www.amazon.co.uk/");
            mainPage.AcceptAllCookies();
            mainPage.AcceptShipping();
        }

        [TearDown]
        public void TestTeardown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}