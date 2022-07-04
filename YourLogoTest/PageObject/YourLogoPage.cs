using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using YourLogoTest.Utilities;

namespace YourLogoTest.PageObject
{
    class YourLogoPage
    {
        public YourLogoPage()
        {
            driver = YourLogoHooks1.driver;
        }

        IWebDriver driver;

        IWebElement Search => driver.FindElement(By.XPath("(//input[@type='text'])[1]"));
        IWebElement SearchButton => driver.FindElement(By.CssSelector("#searchbox > button "));
        IWebElement PrintedSummerDress => driver.FindElement(By.XPath("(//a[@title='Printed Summer Dress'])[2]"));
        IWebElement BlueColour => driver.FindElement(By.XPath("//a[@name='Blue']"));
        IWebElement Dropdownarrow => driver.FindElement(By.CssSelector("#group_1"));
        IWebElement PlusSign => driver.FindElement(By.CssSelector("#quantity_wanted_p > a.btn.btn-default.button-plus.product_quantity_up > span > i"));
        IWebElement AddToCart => driver.FindElement(By.CssSelector("#add_to_cart > button > span"));
        IWebElement ProceedToCheckout => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/header[1]/div[3]/div[1]/div[1]/div[4]/div[1]/div[1]/h2[1]"));
        IWebElement Checkout => driver.FindElement(By.XPath("//a[@title='Proceed to checkout']"));
        IWebElement Summary => driver.FindElement(By.XPath("//li[@class='step_current  first']"));
        IWebElement PlusSignButton => driver.FindElement(By.XPath("//i[@class='icon-plus']"));
        IWebElement ContinueShopping => driver.FindElement(By.XPath("//a[@title='Continue shopping']"));
        IWebElement CheckoutButton => driver.FindElement(By.XPath("(//a[@title='Proceed to checkout'])[2]"));



        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void ClickOnSearch()
        {
            Search.Click();
            
        }
        public void EnterSearch(string printed)
        {
            Search.SendKeys(printed);
        }public void ClickOnSearcchButton()
        {
            Thread.Sleep(5000);
            SearchButton.Click();
        }
        public void ClickOnPrintedSummerDress()
        {
            PrintedSummerDress.Click();
        }
        public void ClickOnBlueColour()
        {
            BlueColour.Click();
        }
        public void ClickOnDropdownarrow()
        {
            Thread.Sleep(5000);
            Dropdownarrow.Click();
        }
        public void SelectFromDropdownarrow()
        {
            SelectElement Select = new SelectElement(Dropdownarrow);
            Select.SelectByValue("2");
        }
        public void ClickOnPlusSign()
        {
            PlusSign.Click();
        }
        public void ClickOnAddToCart()
        {
            AddToCart.Click();
        }
        public bool IsProceedToCheckoutDisplayed()
        {
            return ProceedToCheckout.Displayed;
        }
        public void ClickOnCheckout()
        {
            Thread.Sleep(5000);
            Checkout.Click();
        }

        public bool IsSummaryDisplayed()
        {
            return Summary.Displayed;
        }

        public void ClickOnPlusSignButton()
        {
            PlusSignButton.Click();
        }

        public bool IsContinueShoppingDisplayed()
        {
            return ContinueShopping.Displayed;
        }

        public void ClickOnCheckoutButton()
        {
            CheckoutButton.Click();
        }




    }
}
