using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Amazon.Automation.UI.PageObjects
{
    class CartPage : StartPage
    {
        [FindsBy(How = How.ClassName, Using = "sc-product-title")]
        public IWebElement ProductTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[data-name = 'Active Items'] .sc-price")]
        public IWebElement ProductPrice { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[data-name = 'Active Items'] input[value='Delete']")]
        public IWebElement DeleteButton { get; set; }
    }
}
