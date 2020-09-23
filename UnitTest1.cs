using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using System.ComponentModel.DataAnnotations;

namespace TAdotNET
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        public void ClickLaterButton()
        {
            IWebElement laterButton = driver.FindElement(By.XPath("//div[@class='sign_in-container']//button[@class='sign_in-exit']"));
            laterButton.Click();
        }

        public void BaseTestMethod()
        {
            driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bbc.com");  
        }
        [TestMethod]
        public void Test1()
        {
            BaseTestMethod();
            driver.FindElement(By.XPath("//li[@class='orb-nav-newsdotcom']//a[contains(text(),'News')]")).Click();
            ClickLaterButton();

            IWebElement headline = driver.FindElement(By.XPath("/html/body/div[7]/div/div[4]/div[2]/div/div/div/div/div[1]/div/div/div[1]/div/a/h3"));
            string elementText = headline.Text; 
            
            Assert.AreEqual("Trump denies minimising Covid risk: I 'up-played' it", elementText);  
            driver.Close();
        }
        [TestMethod]
        public void Test2()
        {
            BaseTestMethod();
            driver.FindElement(By.XPath("//li[@class='orb-nav-newsdotcom']//a[contains(text(),'News')]")).Click();
            ClickLaterButton();

            var articleList = driver.FindElements(By.XPath("//div[contains(@class, 'gel-wrap gs-u-pt+')]//div[contains(@class, 'secondary-item')]//h3"));
            List<string> articleNames = new List<string> { "UK teachers 'must get priority access to tests", "UN accuses Venezuela of crimes against humanity", "Smoke from US wildfires spreads across country", "Self-driving car operator charged over fatal crash", "Barbados to remove Queen as head of state" };
            int i = 0;
            foreach (IWebElement element in articleList)
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//div[contains(@class, 'gel-wrap gs-u-pt+')]//div[contains(@class, 'secondary-item')]//h3")).Displayed);
                Assert.IsTrue(element.Text.Contains(articleNames[i]));
                i++;
            }
            driver.Close();
        }
        [TestMethod]
        public void Test3()
        {
            BaseTestMethod();
            driver.FindElement(By.XPath("//li[@class='orb-nav-newsdotcom']//a[contains(text(),'News')]")).Click();
            ClickLaterButton();

            driver.FindElement(By.XPath("/html/body/div[7]/div/div[4]/div[2]/div/div/div/div/div[1]/div/div/div[1]/div/a")).Click();

            IWebElement heading = driver.FindElement(By.XPath("//h1[contains(@class,'story-body__h1')]"));
            string firstArticleName = heading.Text;

            IWebElement searchField = driver.FindElement(By.XPath("//input[@id='orb-search-q']"));
            searchField.Click();

            searchField.SendKeys(firstArticleName);
            searchField.SendKeys(Keys.Enter);

            IWebElement searchedArticle = driver.FindElement(By.XPath("//a//span[@aria-hidden='false']"));
            string nameOfSearchedArticle = searchedArticle.Text;

            Assert.AreEqual(nameOfSearchedArticle, firstArticleName);
            driver.Close();
        }
        [TestMethod]
        public void Test4()
        {
            BaseTestMethod();
            driver.FindElement(By.XPath("//nav[@role='navigation']//a[contains(text(), 'News')]")).Click();
            ClickLaterButton();

            driver.FindElement(By.XPath("//nav[@class='nw-c-nav__wide']//a[@href='/news/coronavirus']")).Click();
            driver.FindElement(By.XPath("//nav[contains(@class,'nw-c-nav__wide-secondary')]//a[@href='/news/have_your_say']")).Click();
            driver.FindElement(By.XPath("//a[@href='/news/52143212']")).Click();

            IWebElement inputField = driver.FindElement(By.XPath("//textarea[@placeholder]"));
            inputField.SendKeys("Covid");

            IWebElement nameField = driver.FindElement(By.XPath("//input[@placeholder='Name']"));
            nameField.SendKeys("Anastasiia");

            IWebElement emailField = driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
            emailField.SendKeys("email@gmail.com");

            IWebElement ageField = driver.FindElement(By.XPath("//input[@placeholder='Age']"));
            ageField.SendKeys("22");

            IWebElement postcodeField = driver.FindElement(By.XPath("//input[@placeholder='Postcode']"));
            postcodeField.SendKeys("11111");

            IWebElement submitButton = driver.FindElement(By.XPath("//button[contains(text(), 'Submit')]"));
            submitButton.Click();

            IWebElement errorMessage = driver.FindElement(By.XPath("//div[contains(text(), 'Telephone number')]"));
            string errorMessageText = errorMessage.Text;

            Assert.AreEqual(errorMessageText, "Telephone number can't be blank");
            driver.Close();
        }

        [TestMethod]
        public void Test5()
        {
            BaseTestMethod();
            driver.FindElement(By.XPath("//nav[@role='navigation']//a[contains(text(), 'News')]")).Click();
            ClickLaterButton();

            driver.FindElement(By.XPath("//nav[@class='nw-c-nav__wide']//a[@href='/news/coronavirus']")).Click();
            driver.FindElement(By.XPath("//nav[contains(@class,'nw-c-nav__wide-secondary')]//a[@href='/news/have_your_say']")).Click();
            driver.FindElement(By.XPath("//a[@href='/news/52143212']")).Click();
      
            IWebElement inputField = driver.FindElement(By.XPath("//textarea[@placeholder]"));
            inputField.SendKeys("Covid");

            IWebElement emailField = driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
            emailField.SendKeys("email@gmail.com");

            IWebElement ageField = driver.FindElement(By.XPath("//input[@placeholder='Age']"));
            ageField.SendKeys("22");

            IWebElement postcodeField = driver.FindElement(By.XPath("//input[@placeholder='Postcode']"));
            postcodeField.SendKeys("11111");

            IWebElement numberField = driver.FindElement(By.XPath("//input[@placeholder='Telephone number']"));
            numberField.SendKeys("11111");

            IWebElement submitButton = driver.FindElement(By.XPath("//button[contains(text(), 'Submit')]"));
            submitButton.Click();

            IWebElement errorMessage = driver.FindElement(By.XPath("//div[contains(text(), 'Name')]"));
            string errorMessageText = errorMessage.Text;

            Assert.AreEqual(errorMessageText, "Name can't be blank");
            driver.Close();
        }

        [TestMethod]
        public void Test6()
        {
            BaseTestMethod();
            driver.FindElement(By.XPath("//nav[@role='navigation']//a[contains(text(), 'News')]")).Click();
            ClickLaterButton();

            driver.FindElement(By.XPath("//nav[@class='nw-c-nav__wide']//a[@href='/news/coronavirus']")).Click();
            driver.FindElement(By.XPath("//nav[contains(@class,'nw-c-nav__wide-secondary')]//a[@href='/news/have_your_say']")).Click();
            driver.FindElement(By.XPath("//a[@href='/news/52143212']")).Click();
 
            IWebElement inputField = driver.FindElement(By.XPath("//textarea[@placeholder]"));
            inputField.SendKeys("Covid");

            IWebElement nameField = driver.FindElement(By.XPath("//input[@placeholder='Name']"));
            nameField.SendKeys("Anastasiia");

            IWebElement emailField = driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
            emailField.SendKeys("email@gmail.com");

            IWebElement ageField = driver.FindElement(By.XPath("//input[@placeholder='Age']"));
            ageField.SendKeys("22");

            IWebElement postcodeField = driver.FindElement(By.XPath("//input[@placeholder='Postcode']"));
            postcodeField.SendKeys("11111");

            IWebElement numberField = driver.FindElement(By.XPath("//input[@placeholder='Telephone number']"));
            numberField.SendKeys("11111");

            driver.FindElement(By.XPath("//button[contains(text(), 'Submit')]")).Click();

            IWebElement errorMessage = driver.FindElement(By.XPath("//div[contains(text(), 'must be accepted')]"));
            string errorMessageText = errorMessage.Text;

            Assert.AreEqual(errorMessageText, "must be accepted");
            driver.Close();
        }
    }
}
