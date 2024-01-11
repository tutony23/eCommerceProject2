using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Training.Hooks;
using Training.PageObject;

namespace Training.StepDefinitions
{
    [Binding]
    public class GreenKartStepDefinitions
    {
        public IWebDriver driver = WebHooks.driver;
        GreenKartPage greenKartPage = new GreenKartPage();


        [Given(@"I navigate the GreenKart Url ""([^""]*)""")]
        public void GivenINavigateTheGreenKartUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }


        [When(@"I click on search bar")]
        public void WhenIClickOnSearchBar()
        {
            greenKartPage.ClickSearchBar();
        }

        [When(@"I enter vegetable ""([^""]*)""")]
        public void WhenIEnterVegetable(string cucumber)
        {
            greenKartPage.EnterVegetable(cucumber);
        }


        [When(@"I add to cart")]
        public void WhenIAddToCart()
        {
            greenKartPage.AddToCart();
        }

        [When(@"I click on cart")]
        public void WhenIClickOnCart()
        {
            greenKartPage.ClickOnCart();
        }

        [When(@"I proceed to checkout")]
        public void WhenIProceedToCheckout()
        {
            greenKartPage.ProceedToCheckout();
        }

        [Then(@"I am able to place order")]
        public void ThenIAmAbleToPlaceOrder()
        {
            greenKartPage.PlaceOrder();
        }
    }
}
