using System.Collections.Generic;
using Amazon.Automation.UI.Utils;
using OpenQA.Selenium;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;

namespace Amazon.Automation.UI.PageObjects
{
    class StartPage : BaseObject
    {
        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.Id, Using = "nav-search-submit-text")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "nav-cart")]
        public IWebElement CartIcon { get; set; }

        [FindsBy(How = How.ClassName, Using = "s-result-item")]
        public IList<IWebElement> ResultItems { get; set; }
    }
}
