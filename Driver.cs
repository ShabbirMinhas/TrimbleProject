using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutoAssignment.Source.Drivers
{
	public class Driver
	{
        

        [ThreadStatic]// ThreadStatic will share the same driver with other tests
        public static IWebDriver _driver;
        

        [SetUp]

        public void InitScript()
        {

            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            
        }

         private WebDriverWait? wait;
        public WebDriverWait Wait
        {
            get
            {
                if (wait == default)
                {
                    wait =
                        new WebDriverWait(_driver, TimeSpan.FromSeconds(60)) { PollingInterval = TimeSpan.FromSeconds(10) };
                    wait.IgnoreExceptionTypes(
                        typeof(NoSuchElementException),
                        typeof(StaleElementReferenceException),
                        typeof(ElementNotInteractableException),
                        typeof(ElementClickInterceptedException)
                        );
                }
                return wait;
            }
        }
        [OneTimeTearDown]

        public void CleanUp()
        {

            _driver.Quit();
        }
    }
}