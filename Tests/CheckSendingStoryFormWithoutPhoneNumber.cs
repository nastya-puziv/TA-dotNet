using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TAdotNET.Elements;
using OpenQA.Selenium;

namespace TAdotNET.Tests
{
    [TestClass]
    public class CheckSendingStoryFormWithoutPhoneNumber : BaseTest
    {
        private string ERROR_MESSAGE = "Telephone number can't be blank";


        [TestMethod]
        public void Test4()
        {
            GetHomePage().ClickMenuTab("News");
            GetHomePage().ClickOnLaterButton();

            GetNewsPage().ClickTopicTab("Coronavirus");
            GetNewsPage().ClickOnCoronavirusStories();
            GetNewsPage().ClickOnSendQuestions();
            GetNewsPage().InputInTextArea("Coronavirus");

            Dictionary<string, string> formInput = new Dictionary<string, string>();
            formInput.Add("Name", "Anasasiia");
            formInput.Add("Email address", "email@gmail.com");
            formInput.Add("Age", "22");
            formInput.Add("Postcode", "11111");
            Form form = new Form(driver);
            form.FillForm(formInput);

            GetNewsPage().ClickOnAgeCheckBox();
            GetNewsPage().ClickOnTermsCheckBox();
            GetNewsPage().ClickOnSubmitButton();

            Assert.AreEqual(ERROR_MESSAGE, GetNewsPage().GetErrorMessageText());
        }
    }
}
