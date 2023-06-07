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
	public class MyCartTests:Driver
	{


		[Test]

		public void BackPackItemAddedToCartVerified()
		{
            LoginPage loginPage = new LoginPage();
            loginPage.Login("standard_user", "secret_sauce");
            HomePage homePage = new HomePage();
            homePage.AddItemSuaceLabBackPack();
            homePage.AddItemSuaceLabBikeLight();
            homePage.ShowMyCart();
            MyCartPage myCartPage = new MyCartPage();
			myCartPage.VerifyBackPackItemAddedToCart();

		}

		[Test]

        public void BikeLightItemAddedToCartVerified()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Login("standard_user", "secret_sauce");
            HomePage homePage = new HomePage();
            homePage.AddItemSuaceLabBackPack();
            homePage.AddItemSuaceLabBikeLight();
            homePage.ShowMyCart();
            MyCartPage myCartPage = new MyCartPage();
            myCartPage.VerifyBackPackItemAddedToCart();

        }
    }
}

