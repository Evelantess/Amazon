using System;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Amazon.Automation.UI.Utils
{
    public class BaseObject
    {
        private readonly WebDriverWait _wait;

        public BaseObject()
        {
            _wait = new WebDriverWait(Driver.GetDriver, TimeSpan.FromSeconds(5));
            PageFactory.InitElements(Driver.GetDriver, this);
        }

    }
}
