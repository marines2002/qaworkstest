using TechTalk.SpecFlow;

namespace QaWorksTest
{
    [Binding]
    public sealed class BeforeAfterTestRun
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public static void BeforeScenario()
        {
        }

        [AfterScenario]
        public static void AfterScenario()
        {
           WebDriver.Instance.Quit();
        }
    }
}
