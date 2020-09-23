using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TAdotNET.Elements;

namespace TAdotNET.Tests
{
   [TestClass]
   public class CheckSendingStoryFormWithoutAcceptionTerms : BaseTest
    {
        private string ERROR_MESSAGE = "must be accepted";
        [TestMethod]
        public void Test6()
        {
            GetHomePage().ClickMenuTab("News");
            GetHomePage().ClickOnLaterButton();

            GetNewsPage().ClickTopicTab("Coronavirus");
            GetNewsPage().ClickOnCoronavirusStories();
            GetNewsPage().ClickOnSendQuestions();
            GetNewsPage().InputInTextArea("Coronavirus");

            Dictionary<string, string> formInput = new Dictionary<string, string>();
            formInput.Add("Name", "Anastasiia");
            formInput.Add("Email address", "email@gmail.com");
            formInput.Add("Age", "22");
            formInput.Add("Postcode", "11111");
            formInput.Add("Telephone number", "1111111");
            Form form = new Form(driver);
            form.FillForm(formInput);

            GetNewsPage().ClickOnAgeCheckBox();
            GetNewsPage().ClickOnSubmitButton();

            Assert.AreEqual(ERROR_MESSAGE, GetNewsPage().GetErrorMessageText());
        }
    }
}
