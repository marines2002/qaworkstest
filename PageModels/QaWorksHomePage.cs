using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace QaWorksTest.PageModels
{
    public class QaWorksHomePage : QaWorksBasePage
    {
        public QaWorksHomePage()
        {
            WebDriver.Instance.Navigate().GoToUrl(BaseUrl);

            var wait = new WebDriverWait(WebDriver.Instance, TimeSpan.FromSeconds(20));

            wait.Until(ExpectedConditions.TitleIs("Home Page - QAWorks"));
        }

        public IWebElement MainMenuContactItem
        {
            get
            {
                return WebDriver.Instance.FindElement((By.PartialLinkText("Contact")));
            }
        }
    }
}
