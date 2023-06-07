using System;
using AutoAssignment.Source.Drivers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoAssignment.Source.Pages;

namespace AutoAssignment.Source.Pages
{
	public class MyCartPage:Driver
	{

        // Finding of page elements with the help of pagefacotry

        [FindsBy(How = How.Id, Using = "item_4_title_link")]
        private IWebElement backpackItemAddedToCart;
		[FindsBy(How = How.LinkText, Using = "Sauce Labs Backpack")]
		private IWebElement sauceLabsBackpackLink;

        [FindsBy(How = How.Id, Using = "item_0_title_link")]
        private IWebElement bikelightItemAddedToCart;

        [FindsBy(How = How.XPath, Using = "//button[@id='checkout']")]
        private IWebElement checkOutButton;

        public MyCartPage()
		{
			PageFactory.InitElements(_driver, this);
		}


		public void VerifyBackPackItemAddedToCart()
		{
			
            Assert.True(backpackItemAddedToCart.Displayed);
			Assert.True(sauceLabsBackpackLink.Displayed);


        }

		public void VerifyBikeLightItemAddedToCart()
		{

			Assert.True(bikelightItemAddedToCart.Displayed);
		}

        public void MoveToCheckOutPage()
        {
            checkOutButton.Click();
            


        }
    }
}

