using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;


namespace TAdotNET.Tests
{
    [TestClass]
   public class CheckNameOfArticles : BaseTest
    {
        [TestMethod]
        public void CheckNameOfHeadlineArticles()
        {
            var newHomePage = new HomePage(driver);


            newHomePage.ClickMenuTab("News");
            newHomePage.ClickOnLaterButton();
            Assert.AreEqual("Trump denies minimising Covid risk: I 'up-played' it", GetNewsPage().GetHeadlineText());
        }

        [TestMethod]
        public void CheckNameOfSecondaryArticles()
        {
            var newHomePage = new HomePage(driver); 

            newHomePage.ClickMenuTab("News");
            newHomePage.ClickOnLaterButton();

            List<string> articlesNames = new List<string>();
            articlesNames.Add("UK teachers 'must get priority access to tests");
            articlesNames.Add("UN accuses Venezuela of crimes against humanity");
            articlesNames.Add("Smoke from US wildfires spreads across country");
            articlesNames.Add("Self-driving car operator charged over fatal crash");
            articlesNames.Add("Barbados to remove Queen as head of state");

            int i = 0;
            foreach (IWebElement element in GetNewsPage().GetArticleList())
            {
                Assert.IsTrue(element.Displayed);
                Assert.IsTrue(element.Text.Contains(articlesNames[i]));
                i++;
            }
        }
    }

}
