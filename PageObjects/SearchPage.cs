using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace TAdotNET.PageObjects
{
   public class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {
            
        }

        [FindsBy(How = How.XPath, Using = "//a//span[@aria-hidden='false']")]
        public IWebElement searchedArticle;

        public string GetSearchedArticleName()
        {
            return searchedArticle.Text;
        }

    }
}
