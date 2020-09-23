using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TAdotNET.PageObjects;

namespace TAdotNET.Elements
{
   public class Form : BasePage
    {
        public Form(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement GetFormElement(string field) => driver.FindElement(By.XPath($"//input[@placeholder='{field}']"));
        public void FillForm(Dictionary<string, string> fields)
        {
            foreach (var key in fields.Keys)
            {
                GetFormElement(key).SendKeys(fields[key]);
            }
        }
    }
}
