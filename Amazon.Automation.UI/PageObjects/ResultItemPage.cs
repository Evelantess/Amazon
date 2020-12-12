using OpenQA.Selenium;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;

namespace Amazon.Automation.UI.PageObjects
{
    class ResultItemPage : StartPage
    {
        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        public IWebElement AddToCartButton { get; set; }

        [FindsBy(How = How.Id, Using = "price_inside_buybox")]
        public IWebElement ProductPrice { get; set; }

        [FindsBy(How = How.Id, Using = "productTitle")]
        public IWebElement ProductTitle { get; set; }
    }
}
