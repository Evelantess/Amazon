using Amazon.Automation.UI.Utils;
using TechTalk.SpecFlow;

namespace Amazon.Automation.UI.Tests
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            Driver.GetDriver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Driver.CloseDriver();
        }
    }
}
