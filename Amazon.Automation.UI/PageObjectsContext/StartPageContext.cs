using Amazon.Automation.UI.PageObjects;
using Amazon.Automation.UI.Utils;
using System.Linq;

namespace Amazon.Automation.UI.PageObjectsContext
{
    public class StartPageContext
    {
        private readonly StartPage _page;

        public StartPageContext()
        {
            _page = new StartPage();
        }

        public void Search(string searchText)
        {
            _page.SearchField.SendKeys(searchText);
            _page.SearchButton.Click();
            Waiters.WaitForPageLoadComplete(10);
        }

        public void NavigateToFirstSearchedItem()
        {
            _page.ResultItems.First().Click();
            Waiters.WaitForPageLoadComplete(10);
        }

        public void NavigateToCart()
        {
            _page.CartIcon.Click();
            Waiters.WaitForPageLoadComplete(10);
        }
    }
}
