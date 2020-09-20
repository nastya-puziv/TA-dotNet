using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;


namespace UnitTestProject2.Tests
{
    class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bbc.com");

            //HomePage button = new HomePage();
            //button.ClickOnNewsButton();


            //Assert.AreEqual("BBC News", headlineText);  // Checks that string “text” is equal to variable elementText, and throws exception if not. Use for checks that must succeed for the test to pass (i.e. the checks that are the purpose of the test).

            driver.Close();
        }
        
    }
}
