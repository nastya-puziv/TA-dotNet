using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using TAdotNET.Elements;
using TAdotNET.Tests;
using TAdotNET.PageObjects;

namespace TAdotNET.Business_Logic_Layer
{
   public class BLL 
    {
     
        public static IWebDriver driver;
        

        public void OpenMenuTab(string menuTab)
        {
            var newHomePage = new HomePage(driver);

            newHomePage.ClickMenuTab(menuTab);
            newHomePage.ClickOnLaterButton();
        }

        public void GoToNews()
        {
            var newHomePage = new HomePage(driver);

            newHomePage.ClickMenuTab("News");
            newHomePage.ClickOnLaterButton();
        }

        public string GetHeadlineArticleText()
        {
            var newNewsPage = new NewsPage(driver);

           return newNewsPage.GetHeadlineText();
        }

        public List<string> InputArticlesName(string name1,string name2,string name3, string name4, string name5)
        {
            List<string> articlesNames = new List<string>();

            articlesNames.Add(name1);
            articlesNames.Add(name2);
            articlesNames.Add(name3);
            articlesNames.Add(name4);
            articlesNames.Add(name5);

            return articlesNames;
        }

        public void GoToSendQuestions()
        {
            var newNewsPage = new NewsPage(driver);

            GoToNews();
            newNewsPage.ClickTopicTab("Coronavirus");
            newNewsPage.ClickOnCoronavirusStories();
            newNewsPage.ClickOnSendQuestions();
        }
        public void SendingCoranavirusForm(string story, string name, string email, string age, string postcode, string number)
        {
            var newHomePage = new HomePage(driver);
            var newNewsPage = new NewsPage(driver);

            newNewsPage.InputInTextArea(story);
            Dictionary<string, string> formInput = new Dictionary<string, string>();
            formInput.Add("Name", name);
            formInput.Add("Email address", email);
            formInput.Add("Age", age);
            formInput.Add("Postcode", postcode);
            formInput.Add("Telephone number", number);
            Form form = new Form(driver);
            form.FillForm(formInput);

            newNewsPage.ClickOnAgeCheckBox();
            newNewsPage.ClickOnTermsCheckBox();
            newNewsPage.ClickOnSubmitButton();
        }
        public void SearchInformation(string searchText, string menuTab)
        {
            var newHomePage = new HomePage(driver);
            var newNewsPage = new NewsPage(driver);

            newHomePage.ClickMenuTab(menuTab);
            newHomePage.ClickOnLaterButton();
            newNewsPage.ClickOnSearchField();
            newNewsPage.InputInSearchField(searchText);
            newNewsPage.SearchFieldEnter();
        }
    }

}
