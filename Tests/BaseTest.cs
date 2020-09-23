using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using TAdotNET.PageObjects;

namespace TAdotNET.Tests
{
   public class BaseTest
    {
        public IWebDriver driver;
        private static readonly string URL = "https://www.bbc.com";

        public IWebDriver GetDriver()
        {
            return driver;
        }
        public BasePage GetBasePage()
        {
            return new BasePage(GetDriver());
        }

        public HomePage GetHomePage()
        {
            return new HomePage(GetDriver());
        }
        public NewsPage GetNewsPage()
        {
            return new NewsPage(GetDriver());
        }
        public SearchPage GetSearchPage()
        {
            return new SearchPage(GetDriver());
        }
        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void WaitVisibilityOfElement(long timeToWait, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy((By)element));
        }
        
        [TestCleanup]
        public void CleanUp()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
        
    }
}
