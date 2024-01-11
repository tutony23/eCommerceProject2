using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Training.Hooks;

namespace Training.PageObject
{
    public class GreenKartFruitsPage


    {
        public IWebDriver driver;

        public GreenKartFruitsPage()

        {
            driver = WebHooks.driver;

        }

        public void AddFriutsToCart()
        {
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[1]/div/div[1]/div[3]/button")).Click();

            driver.FindElement(By.XPath("//div[30]//div[3]//button[1]")).Click();

            driver.FindElement(By.CssSelector("#root > div > div.products-wrapper > div > div:nth-child(27) > div.product-action > button")).Click();

            driver.FindElement(By.CssSelector("#root > div > div.products-wrapper > div > div:nth-child(25) > div.product-action > button")).Click();

            driver.FindElement(By.CssSelector("#root > div > div.products-wrapper > div > div:nth-child(28) > div.product-action > button")).Click();

            driver.FindElement(By.CssSelector("#root > div > div.products-wrapper > div > div:nth-child(29) > div.product-action > button")).Click();

            driver.FindElement(By.CssSelector("#root > div > div.products-wrapper > div > div:nth-child(26) > div.product-action > button")).Click();

            driver.FindElement(By.XPath("//div[30]//div[3]//button[1]")).Click();

            driver.FindElement(By.XPath("//div[30]//div[3]//button[1]")).Click();

            driver.FindElement(By.XPath("//div[30]//div[3]//button[1]")).Click();


        }

        public void ClickBasket()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//img[@alt='Cart']")).Click();
        }

        public void ClickProceedToCheckout()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[normalize-space()='PROCEED TO CHECKOUT']")).Click();
        }

        public void PlaceOrder()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[normalize-space()='Place Order']")).Click();
        }

        public void EnterCountry(string australia)
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div/div/div/select")).SendKeys(australia);
        }


        public void ClickCheckBox()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@type='checkbox']")).Click();
        }

        public void ClickProceedButton()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[normalize-space()='Proceed']")).Click();
        }

        public void ConfirmSuccessfulOrder()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//a[normalize-space()='Home']"));
        }



    }


}
