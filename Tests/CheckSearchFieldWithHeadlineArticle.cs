using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TAdotNET.PageObjects;

namespace TAdotNET.Tests
{
    [TestClass]
   public class CheckSearchFieldWithHeadlineArticle:BaseTest
    {
        [TestMethod]
        public void Test3()
        {
            var newHomePage = new HomePage(driver);
            var newNewsPage = new NewsPage(driver);
            var newSearchPage = new SearchPage(driver);
            newHomePage.ClickMenuTab("News");
            newHomePage.ClickOnLaterButton();

            newNewsPage.ClickHeadlineArticle();
            string headlineArticleName = newNewsPage.GetHeadlineArticleText();
            newNewsPage.ClickOnSearchField();
            newNewsPage.InputInSearchField(headlineArticleName);
            newNewsPage.SearchFieldEnter();

            Assert.AreEqual(headlineArticleName, newSearchPage.GetSearchedArticleName());

        }
    }
}
