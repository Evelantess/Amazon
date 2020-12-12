using Amazon.Automation.UI.PageObjects;
using Amazon.Automation.UI.Utils;

namespace Amazon.Automation.UI.PageObjectsContext
{
    public class ResultItemContext
    {
        private readonly ResultItemPage _page;

        public ResultItemContext()
        {
            _page = new ResultItemPage();
        }

        public string GetProductTitle()
        {
            return _page.ProductTitle.Text.Trim();
        }

        public string GetProductPrice()
        {
            return _page.ProductPrice.Text.Trim();
        }

        public void AddItemToCart()
        {
            _page.AddToCartButton.Click();
            Waiters.WaitForPageLoadComplete(10);
        }
    }
}
