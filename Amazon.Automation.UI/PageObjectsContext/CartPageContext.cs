using Amazon.Automation.UI.PageObjects;

namespace Amazon.Automation.UI.PageObjectsContext
{
    public class CartPageContext
    {
        private readonly CartPage _page;

        public CartPageContext()
        {
            _page = new CartPage();
        }

        public string GetProductTitle()
        {
            return _page.ProductTitle.Text.Trim();
        }

        public string GetProductPrice()
        {
            return _page.ProductPrice.Text.Trim();
        }
    }
}
