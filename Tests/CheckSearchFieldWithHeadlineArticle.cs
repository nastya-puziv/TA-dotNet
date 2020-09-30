using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

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

            newHomePage.ClickMenuTab("News");
            newHomePage.ClickOnLaterButton();

            newNewsPage.ClickHeadlineArticle();
            string headlineArticleName = GetNewsPage().GetHeadlineArticleText();
            newNewsPage.ClickOnSearchField();
            newNewsPage.InputInSearchField(headlineArticleName);
            newNewsPage.SearchFieldEnter();

            Assert.AreEqual(headlineArticleName, GetSearchPage().GetSearchedArticleName());

        }
    }
}
