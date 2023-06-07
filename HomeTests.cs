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
	//[Parallelizable(ParallelScope.All)]
	public class HomeTests:Driver
	{
        
		

        [Test]
		public void AddBackPackToMyCart()
		{
            HomePage homePage = new HomePage();
			LoginPage loginPage = new LoginPage();
            loginPage.Login("standard_user", "secret_sauce");
            homePage.AddItemSuaceLabBackPack();
		}

		[Test]

		public void AddBikeLightToMyCart()
		{
            HomePage homePage = new HomePage();
           // LoginPage loginPage = new LoginPage();
            //loginPage.Login("standard_user", "secret_sauce");
            homePage.AddItemSuaceLabBikeLight();
		}

		[Test]
		public void MoveToMyCart()
		{
            HomePage homePage = new HomePage();
			homePage.ShowMyCart();

        }
	}
}

