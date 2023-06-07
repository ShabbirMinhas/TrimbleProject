
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
	public class CheckOutInfoPage:Driver
	{

		[FindsBy(How = How.XPath, Using = "//span[contains(text(),'Checkout: Your Information')]")]
		private IWebElement myCheckoutInformation;


        [FindsBy(How = How.Id, Using = "first-name")]
        private IWebElement firstName;

        [FindsBy(How = How.CssSelector, Using = "#last-name")]
        private IWebElement lastName;

        [FindsBy(How = How.CssSelector, Using = "#postal-code")]
        private IWebElement postalCode;

        [FindsBy(How = How.CssSelector, Using = "//input[@id='continue']")]
        private IWebElement continueButton;
        


        public CheckOutInfoPage()
		{
			PageFactory.InitElements(_driver, this);
		}

		public void FillOutTheInformation()
		{
			firstName.SendKeys("Shabbir");
			lastName.SendKeys("Minhas");
			postalCode.SendKeys("54000");



        }
		public void ClickOnContinue()
		{

			continueButton.Click();

        }
	}
}

