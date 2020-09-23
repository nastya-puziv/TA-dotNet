using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TAdotNET.PageObjects
{
   public class BasePage
    {
       public IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void Implicitwait(long timeToWait)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeToWait);
        }
        public void WaitVisibilityOfElement(long timeToWait, IWebElement element) 
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy((By)element));
        }
        public void Refresh()
        {
            driver.Navigate().Refresh();
        }


    }
}
