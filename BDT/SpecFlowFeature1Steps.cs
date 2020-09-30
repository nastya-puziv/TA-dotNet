using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TAdotNET.Business_Logic_Layer;
using TechTalk.SpecFlow;

namespace TAdotNET.BDT
{
    [Binding]
    public class SpecFlowFeature1Steps :BLL
    {
        [Given(@"BBC News")]
        public void GivenOpenedNewsTab()
        {
            GoToNews();
        }
        [When(@"Get text from the secondary articles")]
        public List<string> WhenGetTextFromTheSecondaryArticles()
        {

           return InputArticlesName("UK teachers 'must get priority access to tests",
                "UN accuses Venezuela of crimes against humanity",
                "Smoke from US wildfires spreads across country",
                "Self-driving car operator charged over fatal crash",
                "Barbados to remove Queen as head of state");

        }
        [Then(@"The names of the articles should be equal to the specific text")]
        public void ThenTheNamesOfArticlesShouldBeEqualToSpecificText()
        {
            var newNewsPage = new NewsPage(driver);
            int i = 0;
            foreach (IWebElement element in newNewsPage.GetArticleList())
            {
                Assert.IsTrue(element.Displayed);
                Assert.IsTrue(element.Text.Contains(WhenGetTextFromTheSecondaryArticles()[i]));
                i++;
            }
        }
    }
}
