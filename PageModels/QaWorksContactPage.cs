using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace QaWorksTest.PageModels
{
    class QaWorksContactPage : QaWorksBasePage
    {
        public QaWorksContactPage() : base()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver.Instance, TimeSpan.FromSeconds(20));

            wait.Until(ExpectedConditions.TitleIs("Contact Us - QAWorks"));
        }

        public IWebElement TextBoxName => WebDriver.Instance.FindElement((By.Id("ctl00_MainContent_NameBox")));

        public IWebElement TextBoxEmail => WebDriver.Instance.FindElement((By.Id("ctl00_MainContent_EmailBox")));

        public IWebElement TextBoxMessage => WebDriver.Instance.FindElement((By.Id("ctl00_MainContent_MessageBox")));

        public IWebElement ButtonSend => WebDriver.Instance.FindElement((By.Id("ctl00_MainContent_SendButton")));

        public void SendMessage(string name, string email, string message)
        {
            TextBoxName.SendKeys(name);
            TextBoxEmail.SendKeys(email);
            TextBoxMessage.SendKeys(message);
            ButtonSend.Click();
        }
    }
}
