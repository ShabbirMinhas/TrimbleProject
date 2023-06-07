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
	public class CheckOutOverview:Driver
	{

		[FindsBy(How = How.XPath, Using = "//span[contains(text(),'Checkout: Overview')]")]
		private IWebElement checkOutPageVerification;
		public CheckOutOverview()
		{
			PageFactory.InitElements(_driver, this);
		}
	}
}

