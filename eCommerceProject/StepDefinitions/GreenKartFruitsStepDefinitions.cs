using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Training.Hooks;
using Training.PageObject;

namespace Training.StepDefinitions
{
    [Binding]
    public class GreenKartFruitsStepDefinitions
    {
        public IWebDriver driver = WebHooks.driver;

        GreenKartFruitsPage greenKartFruitsPage = new GreenKartFruitsPage();

        [Given(@"that I navigate GreenKart url ""([^""]*)""")]
        public void GivenThatINavigateGreenKartUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [Given(@"I add all friuts to cart")]
        public void GivenIAddAllFriutsToCart()
        {
            Thread.Sleep(2000);
            greenKartFruitsPage.AddFriutsToCart();
        }

        [When(@"I click on the basket to view all added items")]
        public void WhenIClickOnTheBasketToViewAllAddedItems()
        {
            greenKartFruitsPage.ClickBasket();
        }

        [When(@"I click on proceed to checkout")]
        public void WhenIClickOnProceedToCheckout()
        {
            greenKartFruitsPage.ClickProceedToCheckout();
        }


        [When(@"I place order for all items")]
        public void WhenIPlaceOrderForAllItems()
        {
            greenKartFruitsPage.PlaceOrder();
        }

        [When(@"I select country ""([^""]*)""")]
        public void WhenISelectCountry(string australia)
        {
            greenKartFruitsPage.EnterCountry(australia);
        }


        [When(@"I click the check box to agree terms and conditions")]
        public void WhenIClickTheCheckBoxToAgreeTermsAndConditions()
        {
            greenKartFruitsPage.ClickCheckBox();
        }

        [When(@"I click proceed button")]
        public void WhenIClickProceedButton()
        {
            greenKartFruitsPage.ClickProceedButton();
        }

        [Then(@"I am able to buy different fruits items successfully\.")]
        public void ThenIAmAbleToBuyDifferentFruitsItemsSuccessfully_()
        {
            greenKartFruitsPage.ConfirmSuccessfulOrder();
        }


    }
}
