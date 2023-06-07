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
    //Parall execution annotation at class level
   [Parallelizable(ParallelScope.All)]

    public class LoginTests:Driver
    {
        
        
        [Test]
        public void Login()
        {
            LoginPage loginPage = new LoginPage();
            
            loginPage.Login("standard_user", "secret_sauce");
            
            
            Assert.True(_driver.Title.Contains("Swag Labs"));
            IAlert passwordAlert ;
            int counter = 0;
            while(counter<5)
            try
            {
                passwordAlert = _driver.SwitchTo().Alert();
                passwordAlert.Accept();
                    break;
            }
            catch(NoAlertPresentException)
            {
                Thread.Sleep(1000);
                    counter++;
            }

        }

        
        [Test]
        public void InvalidLogin()
		{
			LoginPage loginPage = new LoginPage();
           _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            loginPage.InvalidLogin("standard_user", "secret_sauce.");
            
            Assert.True(_driver.Title.Contains("Swag Labs"));
           
		}
	}
}

