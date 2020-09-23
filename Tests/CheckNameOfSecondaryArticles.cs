using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TAdotNET.Tests
{
   public class CheckNameOfSecondaryArticles:BaseTest
    {
        [TestMethod]
        public void Test2()
        {
            GetHomePage().ClickMenuTab("News");
            GetHomePage().ClickOnLaterButton();

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
