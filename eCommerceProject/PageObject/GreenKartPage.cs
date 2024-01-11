using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Hooks;

namespace Training.PageObject
{
    public class GreenKartPage
    {
        public IWebDriver driver;

        public GreenKartPage()
        {
            driver = WebHooks.driver;
        }

        private By Search = By.XPath("//*[@id=\"root\"]/div/header/div/div[2]/form/input");
        private By EnterCucumber = By.XPath("//*[@id=\"root\"]/div/header/div/div[2]/form/input");
        private By AddCart = By.XPath("//*[@id=\"root\"]/div/div[1]/div/div/div[3]/button");
        private By ClickCart = By.XPath("//*[@id=\"root\"]/div/header/div/div[3]/a[4]/img");
        private By ProceedToCheckOut = By.XPath("//*[@id=\"root\"]/div/header/div/div[3]/div[2]/div[2]/button");
        private By Order = By.XPath("//*[@id=\"root\"]/div/div/div/div/button");

        public void ClickSearchBar()
        {
            driver.FindElement(Search).Click();
        }

        public void EnterVegetable(string cucumber)
        {
            driver.FindElement(EnterCucumber).SendKeys(cucumber);
        }

        public void AddToCart()
        {
            driver.FindElement(AddCart).Click();
        }

        public void ClickOnCart()
        {
            driver.FindElement(ClickCart).Click();
        }

        public void ProceedToCheckout()
        {
            driver.FindElement(ProceedToCheckOut).Click();
        }

        public void PlaceOrder()
        {
            driver.FindElement(Order).Click();
        }
    }
}
