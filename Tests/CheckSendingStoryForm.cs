using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TAdotNET.Elements;
using OpenQA.Selenium;
using System.Net.Http.Headers;

namespace TAdotNET.Tests
{
    [TestClass]
    public class CheckSendingStoryForm : BaseTest
    {
        
        private string ERROR_MESSAGE_TERMS = "must be accepted";
        private string ERROR_MESSAGE_NUMBER = "Telephone number can't be blank";
        private string ERROR_MESSAGE_NAME = "Name can't be blank";

        [TestMethod]
        public void CheckSendingStoryFormWithoutName()
        {
            var newHomePage = new HomePage(driver);
            var newNewsPage = new NewsPage(driver);

            newHomePage.ClickMenuTab("News");
            newHomePage.ClickOnLaterButton();

            newNewsPage.ClickTopicTab("Coronavirus");
            newNewsPage.ClickOnCoronavirusStories();
            newNewsPage.ClickOnSendQuestions();

            newNewsPage.InputInTextArea("Coronavirus");
            Dictionary<string, string> formInput = new Dictionary<string, string>();
            formInput.Add("Email address", "email@gmail.com");
            formInput.Add("Age", "22");
            formInput.Add("Postcode", "11111");
            formInput.Add("Telephone number", "1111111");
            Form form = new Form(driver);
            form.FillForm(formInput);

            newNewsPage.ClickOnAgeCheckBox();
            newNewsPage.ClickOnTermsCheckBox();
            newNewsPage.ClickOnSubmitButton();

            Assert.AreEqual(ERROR_MESSAGE_NAME, newNewsPage.GetErrorMessageText());
        }


        [TestMethod]
        public void CheckSendingStoryFormWithoutNumber()
        {
            var newHomePage = new HomePage(driver);
            var newNewsPage = new NewsPage(driver);

            newHomePage.ClickMenuTab("News");
            newHomePage.ClickOnLaterButton();

            newNewsPage.ClickTopicTab("Coronavirus");
            newNewsPage.ClickOnCoronavirusStories();
            newNewsPage.ClickOnSendQuestions();

            newNewsPage.InputInTextArea("Coronavirus");
            Dictionary<string, string> formInput = new Dictionary<string, string>();
            formInput.Add("Name", "Anasasiia");
            formInput.Add("Email address", "email@gmail.com");
            formInput.Add("Age", "22");
            formInput.Add("Postcode", "11111");
            Form form = new Form(driver);
            form.FillForm(formInput);

            newNewsPage.ClickOnAgeCheckBox();
            newNewsPage.ClickOnTermsCheckBox();
            newNewsPage.ClickOnSubmitButton();

            Assert.AreEqual(ERROR_MESSAGE_NUMBER, newNewsPage.GetErrorMessageText());
        }

        [TestMethod]
        public void CheckSendingStoryFormWithoutAcceptingTerms()
        {
            var newHomePage = new HomePage(driver);
            var newNewsPage = new NewsPage(driver);

            newHomePage.ClickMenuTab("News");
            newHomePage.ClickOnLaterButton();

            newNewsPage.ClickTopicTab("Coronavirus");
            newNewsPage.ClickOnCoronavirusStories();
            newNewsPage.ClickOnSendQuestions();
            newNewsPage.InputInTextArea("Coronavirus");

            Dictionary<string, string> formInput = new Dictionary<string, string>();
            formInput.Add("Name", "Anastasiia");
            formInput.Add("Email address", "email@gmail.com");
            formInput.Add("Age", "22");
            formInput.Add("Postcode", "11111");
            formInput.Add("Telephone number", "1111111");
            Form form = new Form(driver);
            form.FillForm(formInput);

            newNewsPage.ClickOnAgeCheckBox();
            newNewsPage.ClickOnSubmitButton();

            Assert.AreEqual(ERROR_MESSAGE_TERMS, newNewsPage.GetErrorMessageText());
        }

    }
}
