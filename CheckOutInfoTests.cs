using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using AutoAssignment.Source.Pages;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoAssignment.Source.Drivers;
namespace AutoAssignment.Test
{
	public class CheckOutInfoTests:Driver
	{

		[Test]

		public void FillOutInformationForm()
		{

			CheckOutInfoPage checkOutInfo = new CheckOutInfoPage();
            checkOutInfo.FillOutTheInformation();
            checkOutInfo.ClickOnContinue();
		}

	}
}

