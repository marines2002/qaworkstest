using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace QaWorksTest
{
    public static class WebDriver
    {
        private const string Key = "webdriver";

        public static IWebDriver Instance
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey(Key))
                {
                    var webdriver = new ChromeDriver();

                    ScenarioContext.Current[Key] = webdriver;
                }

                return ScenarioContext.Current[Key] as IWebDriver;
            }
        }
    }
}
