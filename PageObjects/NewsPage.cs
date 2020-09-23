using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using TAdotNET.PageObjects;

namespace TAdotNET
{
   public class NewsPage:BasePage
    {
        public NewsPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div[4]/div[2]/div/div/div/div/div[1]/div/div/div[1]/div/a/h3")]
        public IWebElement headline;
        
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'gel-wrap gs-u-pt+')]//div[contains(@class, 'secondary-item')]//h3")]
        public IList<IWebElement> articleList;

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div[4]/div[2]/div/div/div/div/div[1]/div/div/div[1]/div/a")]
        public IWebElement headlineArticle;

        [FindsBy(How = How.XPath, Using = "//h1[contains(@class,'story-body__h1')]")]
        public IWebElement headlineArticleText;

        [FindsBy(How = How.XPath, Using = "//input[@id='orb-search-q']")]
        public IWebElement searchField;

        [FindsBy(How = How.XPath, Using = "//nav[@class='nw-c-nav__wide']//a[@href='/news/coronavirus']")]
        public IWebElement coronavirusTab;

        [FindsBy(How = How.XPath, Using = "//nav[contains(@class,'nw-c-nav__wide-secondary')]//a[@href='/news/have_your_say']")]
        public IWebElement coronavirusStories;

        [FindsBy(How = How.XPath, Using = "//a[@href='/news/52143212']")]
        public IWebElement sendQuestions;

        [FindsBy(How = How.XPath, Using = "//textarea[contains(@placeholder,'question')]")]
        public IWebElement textArea;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Name']")]
        public IWebElement nameField;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        public IWebElement emailField;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Telephone number']")]
        public IWebElement numberField;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Age']")]
        public IWebElement ageField;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Postcode']")]
        public IWebElement postcodeField;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(), 'I am over 16')]")]
        public IWebElement ageCheckBox;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(), 'I accept')]")]
        public IWebElement termsCheckBox;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Submit')]")]
        public IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'input-error')]")]
        public IWebElement errorMessage;

        public string GetHeadlineText()
        {
            return headline.Text;
        }
        public IList<IWebElement> GetArticleList()
        {
            return articleList;
        }
        public void ClickHeadlineArticle()
        {
            headlineArticle.Click();
        }
        public string GetHeadlineArticleText()
        {
            return headlineArticleText.Text;
        }
        public void ClickOnSearchField()
        {
            searchField.Click();
        }

        public void InputInSearchField(string text)
        {
            searchField.SendKeys(text);
        }
        public void SearchFieldEnter()
        {
            searchField.SendKeys(Keys.Enter);
        }

        public void ClickOnCoronavirusTab()
        {
            coronavirusTab.Click();
        }
        public void ClickOnCoronavirusStories()
        {
            coronavirusStories.Click();
        }

        public void ClickOnSendQuestions()
        {
            sendQuestions.Click();
        }

        public void InputInTextArea(string text)
        {
            textArea.SendKeys(text);
        }

        public void InputName(string name)
        {
            nameField.SendKeys(name);
        }
        public void InputEmail(string email)
        {
            emailField.SendKeys(email);
        }
        public void InputNumber(string number)
        {
            numberField.SendKeys(number);
        }
        public void InputAge(string age)
        {
            ageField.SendKeys(age);
        }
        public void InputPostcode(string postcode)
        {
            postcodeField.SendKeys(postcode);
        }
        public void ClickOnAgeCheckBox()
        {
            ageCheckBox.Click();
        }
        public void ClickOnTermsCheckBox()
        {
            termsCheckBox.Click();
        }

        public void ClickOnSubmitButton()
        {
            submitButton.Click();
        }
        public string GetErrorMessageText()
        {
            return errorMessage.Text;
        }

        private IWebElement GetTopicOfNewsTab(string topic)
        {
            return driver.FindElement(By.XPath($"//div[contains(@class, 'news-wide-navigation')]//a[contains(@href, '{topic}')]"));
        }

        public void ClickTopicTab(string topic) => GetTopicOfNewsTab(topic.ToString().ToLower()).Click();








    }
}
