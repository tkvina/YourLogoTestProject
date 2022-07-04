using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using YourLogoTest.PageObject;

namespace YourLogoTest.StepDefinition
{
    [Binding]
    public class YourLogoSteps
    {
        YourLogoPage yourLogoPage;
        public YourLogoSteps()
        {
            yourLogoPage = new YourLogoPage();
        }
        
        
        
        
        
        
        [Given(@"I Navigate to Website ""(.*)""")]
        public void GivenINavigateToWebsite(string p0)
        {
            yourLogoPage.NavigateToWebsite();
        }


        [Given(@"I Click on Search")]
        public void GivenIClickOnSearch()
        {
           yourLogoPage.ClickOnSearch();
        }

        [Given(@"I Enter Search for ""(.*)""")]
        public void GivenIEnterSearchFor(string printed)
        {
            yourLogoPage.EnterSearch(printed);
        }





        [Given(@"I Click on Search Button")]
        public void GivenIClickOnSearchButton()
        {
            yourLogoPage.ClickOnSearcchButton();
        }

        [Given(@"I Click on Printed Summer Dress \$(.*)")]
        public void GivenIClickOnPrintedSummerDress(decimal pO)
        {
            yourLogoPage.ClickOnPrintedSummerDress();
        }



        [Given(@"I click on Blue Colour")]
        public void GivenIClickOnBlueColour()
        {
           yourLogoPage.ClickOnBlueColour();
        }




        [Given(@"I Click on Dropdown arrow")]
        public void GivenIClickOnDropdownArrow()
        {
            yourLogoPage.ClickOnDropdownarrow();
        }

        [Given(@"I Select Medium Size")]
        public void GivenISelectMediumSize()
        {
            yourLogoPage.SelectFromDropdownarrow();
        }



        [Given(@"I Click on plus sign to Add Two Quantity to Basket")]
        public void GivenIClickOnPlusSignToAddTwoQuantityToBasket()
        {
           yourLogoPage.ClickOnPlusSign();
        }



        [When(@"I Click on Add to Cart")]
        public void WhenIClickOnAddToCart()
        {
            yourLogoPage.ClickOnAddToCart();
            Thread.Sleep(5000);
        }

        [Then(@"I should be able to add to cart successfully")]
        public void ThenIShouldBeAbleToAddToCartSuccessfully()
        {
            Thread.Sleep(5000);
          Assert.That(yourLogoPage.IsProceedToCheckoutDisplayed);
        }




        [When(@"I Click on plus sign to Add  One more dress to the Basket")]
        public void WhenIClickOnPlusSignToAddOneMoreDressToTheBasket()
        {
           Assert.That(yourLogoPage.IsSummaryDisplayed);
        }

       
        
        [When(@"I Click On Proceed to Checkout")]
        public void WhenIClickOnProceedToCheckout()
        {
            yourLogoPage.ClickOnCheckout();
        }


        [When(@"I Click on plus sign Button to Add  One more dress to the Basket")]
        public void WhenIClickOnPlusSignButtonToAddOneMoreDressToTheBasket()
        {
            yourLogoPage.ClickOnPlusSignButton();
        }


        
        [Then(@"I Validate the total value in the basket")]
        public void ThenIValidateTheTotalValueInTheBasket()
        {
            Assert.That(yourLogoPage.IsSummaryDisplayed);
        }
        
        [Then(@"I Confirmed the Price in the Basket have Been Updated")]
        public void ThenIConfirmedThePriceInTheBasketHaveBeenUpdated()
        {
           Assert.That(yourLogoPage.IsContinueShoppingDisplayed);
        }


        [Then(@"I Click on Proceed to Checkout Button")]
        public void ThenIClickOnProceedToCheckoutButton()
        {
            yourLogoPage.ClickOnCheckoutButton();
        }



    }
}
