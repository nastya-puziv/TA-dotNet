using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace UnitTestProject2
{
    class NewsPage
    {


        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'BBC News')]")]
        public IWebElement headline;
        public void HeadlineText()
        {
            string headlineText = headline.Text;
        }

        [FindsBy(How = How.XPath, Using = "//nav[@role='navigation']//ul[contains(@class, 'wide')]/li")]
        public List<IWebElement> themesList;

        [FindsBy(How = How.XPath, Using = "//div[@class='gs-c-promo-body gel-1/2@xs gel-1/1@m gs-u-mt@m']//a/h3[1]")]
        public IWebElement firstArticle;
        public string FirstArticleName()
        {
            return firstArticle.Text;
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='orb-search-q']")]
        public IWebElement searchField;
        public void ClickObSearchField()
        {
            searchField.Click();
        }
        public void EnterFirstArticleName()
        {
            searchField.SendKeys(firstArticle.Text);
        }
        public void SearchFieldEnter()
        {
            searchField.SendKeys(Keys.Enter);
        }

        [FindsBy(How = How.XPath, Using = "//a//span[@aria-hidden='false']")]
        public IWebElement searchedArticle;
        public string SearchedArticleName()
        {
            return searchedArticle.Text;
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/header/div[2]/div[1]/div[1]/nav/ul/li[3]/a")]
        public IWebElement coronavirusTab;

        public void ClickOnCoronavirusTab()
        {
            coronavirusTab.Click();
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/header/div[2]/div[2]/div[1]/nav/ul/li[2]/a")]
        public IWebElement coronavirusStoryTab;
        public void ClickOnCoronaStory()
        {
            coronavirusStoryTab.Click();
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div/a")]
        public IWebElement howToShare;
        public void ClickOnHowToShare()
        {
            howToShare.Click();
        }

        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder]")]
        public IWebElement storyField;
        public void InputStory()
        {
            storyField.SendKeys("Story about Covid");
        }
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Name']")]
        public IWebElement nameField;
        public void InputName()
        {
            nameField.SendKeys("User name");
        }
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        public IWebElement emailField;
        public void InputEmail()
        {
            emailField.SendKeys("email@mail.com");
        }
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Contact number ']")]
        public IWebElement numberField;
        public void InputNumber()
        {
            numberField.SendKeys("2281488");
        }
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Location ']")]
        public IWebElement locationField;
        public void InputLocation()
        {
            locationField.SendKeys("Kyiv");
        }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Submit')]")]
        public IWebElement submitButton;
        public void ClickSubmitButton()
        {
            submitButton.Click();
        }
        

    }
}
