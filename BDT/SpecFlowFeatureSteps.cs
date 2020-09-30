using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TAdotNET.Business_Logic_Layer;
using TAdotNET.Tests;
using TechTalk.SpecFlow;
using TAdotNET.BDT.Hooks;

namespace TAdotNET
{
    [Binding]
    public class CheckNameOfFirstStory : BLL
    {
        private string NAME_OF_HEADLINE_ARTICLE = "Trump denies minimising Covid risk: I 'up-played' it";

        [Given(@"Opened News tab")]
        public void GivenOpenedNewsTab()
        {
            GoToNews();
        }
        [When(@"Get text from the headline article")]
        public string WhenGetTextFromTheHeadlineArticle()
        {

            return GetHeadlineArticleText();

        }
        [Then(@"The name of the article should be equal to the specific text")]
        public void ThenTheNameOfArticleShouldBeEqualToSpecificText()
        {
            Assert.AreEqual(NAME_OF_HEADLINE_ARTICLE, WhenGetTextFromTheHeadlineArticle());
        }

    }
}
