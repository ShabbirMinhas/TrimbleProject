using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;//To use the pagefactory concept 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoAssignment.Source.Pages;
using AutoAssignment.Source.Drivers;
using System.ComponentModel;



namespace AutoAssignment.Source.Pages
{
    /* This class contains all the elements and methods
       related to LoginPage  */

    public class LoginPage:Driver
	{
        //pagefactory attribute to store the webelements 
        [FindsBy(How = How.Id, Using = "user-name")]
        private IWebElement _userName;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement _password;

        [FindsBy(How = How.Id, Using = "login-button")]
        private IWebElement _loginbtn;

       

       



        public LoginPage()
		{
			
			PageFactory.InitElements(_driver, this);
		}

		

		public void InvalidLogin(string userName , string password)
		{
			_userName.SendKeys(userName);
			_password.SendKeys(password);
			_loginbtn.Click();

		}

        public void Login(string userName, string password)
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            _userName.SendKeys(userName);
            _password.SendKeys(password);
            _loginbtn.Click();

        }
    }
}

