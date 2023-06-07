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
	public class HomePage : Driver
	{
        /* This class contains all the elements and methods
      related to HomePage  */

        [CacheLookup] // if element won't change it will search from cash

        public string backPackItemPrice;
        public string bikelightItemPrice;

        // Finding of page elements with the help of pagefacotry

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-backpack")]
        private IWebElement addToCartProdutBackpack;

        [FindsBy(How = How.Id, Using = "remove-sauce-labs-backpack")]
        private IWebElement removeFromCartProdutBackpack;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Sauce Labs Backpack')]//parent::a//parent::div[contains(@class, 'inventory_item_label')]//parent::div//following-sibling::div[contains(@class, 'pricebar')]//div[contains(@class,'inventory_item_price')]")]
        private IWebElement backPackProductPrice;

       

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-bike-light")]
        private IWebElement addToCartProdutbikelight;

        [FindsBy(How = How.Id, Using = "remove-sauce-labs-bike-light")]
        private IWebElement removeFromCartProdutbikelight;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Sauce Labs Bike Light')]//parent::a//parent::div[contains(@class, 'inventory_item_label')]//parent::div//following-sibling::div[contains(@class, 'pricebar')]//div[contains(@class,'inventory_item_price')]")]
        private IWebElement bikelightProductPrice;

        [FindsBy(How = How.Id, Using = "shopping_cart_container")]
        private IWebElement myCart;

        


        // FindBy attribute to find the weblement 



        public HomePage()
		{
            //This will initalize all the elements in this class
            PageFactory.InitElements(_driver, this);
		}


        public void AddItemSuaceLabBackPack()
        {
            addToCartProdutBackpack.Click();
            Assert.True(removeFromCartProdutBackpack.Displayed);
            backPackItemPrice =backPackProductPrice.Text;

        }

        public void AddItemSuaceLabBikeLight()
        {
            addToCartProdutbikelight.Click();
            Assert.True(removeFromCartProdutbikelight.Displayed);
             bikelightItemPrice = bikelightProductPrice.Text;
            
            
        }
        
        public void ShowMyCart()
        {
            myCart.Click();
            


        }
    }


	
}

