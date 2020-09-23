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
            GetHomePage().ClickMenuTab("News");
            GetHomePage().ClickOnLaterButton();

            GetNewsPage().ClickHeadlineArticle();
            string headlineArticleName = GetNewsPage().GetHeadlineArticleText();
            GetNewsPage().ClickOnSearchField();
            GetNewsPage().InputInSearchField(headlineArticleName);
            GetNewsPage().SearchFieldEnter();

            Assert.AreEqual(headlineArticleName, GetSearchPage().GetSearchedArticleName());

        }
    }
}
