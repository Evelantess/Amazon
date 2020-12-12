using System.ComponentModel;
using Amazon.Automation.UI.PageObjectsContext;
using Amazon.Automation.UI.Utils;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.TestFramework;

namespace Amazon.Automation.UI.Tests.Steps
{
    [Binding]
    public class CartCheckSteps
    {
        private readonly StartPageContext _startPageContext;
        private readonly ResultItemContext _resultItemContext;
        private readonly ScenarioContext _scenarioContext;
        private readonly CartPageContext _cartPageContext;

        private const string Price = "Price";
        private const string Title = "Title";

        public CartCheckSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _startPageContext = new StartPageContext();
            _resultItemContext = new ResultItemContext();
            _cartPageContext = new CartPageContext();
        }

        [Given(@"the (.*) site is opened")]
        public void GivenTheHttpsWww_Amazon_ComSiteIsOpened(string site)
        {
            Driver.GetDriver.Navigate().GoToUrl(site);
        }
        
        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchText)
        {
            _startPageContext.Search(searchText);
        }
        
        [When(@"I add the first found item to cart")]
        public void WhenAddTheFirstFoundItemToCart()
        {
           _startPageContext.NavigateToFirstSearchedItem();
           _scenarioContext.Add(Price, _resultItemContext.GetProductPrice());
           _scenarioContext.Add(Title, _resultItemContext.GetProductTitle());
           _resultItemContext.AddItemToCart();
        }

        [When(@"I navigate to cart")]
        public void WhenINavigateToCart()
        {
            _startPageContext.NavigateToCart();
        }

        [Then(@"Item is present in cart with correct name")]
        public void ThenItemIsPresentInCartWithCorrectName()
        {
            var expProductTitle = _scenarioContext.Get<string>(Title);
            var actProductTitle = _cartPageContext.GetProductTitle();
            Assert.AreEqual(expProductTitle, actProductTitle, "IncorrectItemIsInCart!");
        }
        
        [Then(@"The price of the item i cart is correct")]
        public void ThenThePriceOfTheItemICartIsCorrect()
        {
            var expProductPrice = _scenarioContext.Get<string>(Price);
            var actProductPrice = _cartPageContext.GetProductPrice();
            Assert.AreEqual(expProductPrice, actProductPrice, "IncorrectItemIsInCart!");
        }
    }
}
