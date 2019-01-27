using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Amanson.StepDefinations
{
    [Binding]
    public sealed class ProductDetailSteps
    {
        IWebDriver driver;
        [Given(@"I navigate to Amazon homepage")]
        public void GivenINavigateToAmazonHomepage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.co.uk/"); 
        }

        [Given(@"I have search for wrist watch")]
        public void GivenIHaveSearchForWristWatch()
        {
                    }

        [Given(@"I click one of the search result displayed")]
        public void GivenIClickOneOfTheSearchResultDisplayed()
        {
            
        }

        [Then(@"The product price is displayed")]
        public void ThenTheProductPriceIsDisplayed()
        {
            
        }

    }


}