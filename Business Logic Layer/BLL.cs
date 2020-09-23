using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using TAdotNET.Elements;
using TAdotNET.Tests;

namespace TAdotNET.Business_Logic_Layer
{
   public class BLL : BaseTest
    {
        public void OpenMenuTab(string menuTab)
        {
            new HomePage(driver).ClickMenuTab(menuTab);
            new HomePage(driver).ClickOnLaterButton();
        }

        public void SearchInformation(string searchText, string menuTab)
        {
            new HomePage(driver).ClickMenuTab(menuTab);
            new HomePage(driver).ClickOnLaterButton();
            new NewsPage(driver).ClickOnSearchField();
            new NewsPage(driver).InputInSearchField(searchText);
            new NewsPage(driver).SearchFieldEnter();
        }

        public void SendCoronavirusStory(string story, string name, string email, string age, string postcode, string number)
        {
            GetHomePage().ClickMenuTab("News");
            GetHomePage().ClickOnLaterButton();

            GetNewsPage().ClickTopicTab("Coronavirus");
            GetNewsPage().ClickOnCoronavirusStories();
            GetNewsPage().ClickOnSendQuestions();
            GetNewsPage().InputInTextArea(story);

            Dictionary<string, string> formInput = new Dictionary<string, string>();
            formInput.Add("Name", name);
            formInput.Add("Email address", email);
            formInput.Add("Age", age);
            formInput.Add("Postcode", postcode);
            formInput.Add("Telephone number", number);
            Form form = new Form(driver);
            form.FillForm(formInput);

            GetNewsPage().ClickOnAgeCheckBox();
            GetNewsPage().ClickOnSubmitButton();
            GetNewsPage().ClickOnTermsCheckBox();
        }
    }

}
