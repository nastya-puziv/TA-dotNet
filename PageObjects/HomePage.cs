using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using TAdotNET.PageObjects;

namespace TAdotNET
{
    public enum Tabs
    {
        News,
        Sport,
        Reel,
        Workife,
        Travel,
        Future,
        Culture,
        More
    }
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {   
        }
        
        [FindsBy(How = How.XPath, Using = "//nav[@role='navigation']//a[contains(text(), 'News')]")]
        private IWebElement news;
      
        [FindsBy(How = How.XPath, Using = "//div[@class='sign_in-container']//button[@class='sign_in-exit']")]
        private IWebElement laterButton;

        public void ClickOnNewsButton() { news.Click(); }
        public void ClickOnLaterButton(){ laterButton.Click();}

        private IWebElement GetMenuTab (string tab)
        {
            return driver.FindElement(By.XPath($"//div[@id='orb-nav-links']//li[contains(@class, '{tab}')]/a"));
        }

        public void ClickMenuTab(string tab) => GetMenuTab(tab.ToString().ToLower()).Click();






    }
}
