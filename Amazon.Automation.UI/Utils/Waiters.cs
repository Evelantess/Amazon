using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Amazon.Automation.UI.Utils
{
    public class Waiters
    {
        public static void ImplicitWait(int timeToWait)
        {
            Driver.GetDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeToWait);
        }

        public static void WaitForPageLoadComplete(int timeToWait)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

    }
}
