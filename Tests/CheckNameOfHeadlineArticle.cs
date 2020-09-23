using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;


namespace TAdotNET.Tests
{
    [TestClass]
   public class CheckNameOfHeadlineArticle : BaseTest
    {
        [TestMethod]
        public void Test1()
        {
            GetHomePage().ClickMenuTab("News");
            GetHomePage().ClickOnLaterButton();
            Assert.AreEqual("Trump denies minimising Covid risk: I 'up-played' it", GetNewsPage().GetHeadlineText());
        }
        
    }
}
