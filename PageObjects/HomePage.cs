using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using TAdotNET.PageObjects;

namespace TAdotNET
{
    class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }
        
        [FindsBy(How = How.XPath, Using = "//nav[@role='navigation']//a[contains(text(), 'News')]")]
        private IWebElement news;
        public void ClickOnNewsButton()
        {
            news.Click();
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='sign_in-container']//button[@class='sign_in-exit']")]
        private IWebElement laterButton;
        public void ClickOnLaterButton()
        {
            laterButton.Click();
        }

        





       

        

    }
}
