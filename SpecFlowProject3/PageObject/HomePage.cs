using OpenQA.Selenium;
using SpecFlowProject3.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.PageObject
{
    internal class HomePage
    {
        IWebDriver driver;  
        public HomePage()
        {
            driver = WebHook.driver;
        }

        private string url = "https://tfl.gov.uk/";

        public void NavigateToUrl()
        {
            driver.Navigate().GoToUrl(url);
        }

        IWebElement Cookies => driver.FindElement(By.XPath("//*[@id=\"cb-left\"]/h2"));
        IWebElement AcceptCookies => driver.FindElement(By.XPath("//*[@id=\"CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll\"]/strong"));


        public void ClearCookies()

        {
            if (Cookies.Displayed)

            {
                AcceptCookies.Click();
            }



        }

        public bool LandingPage()

        {
            return driver.Url == "https://tfl.gov.uk/";
        }  


    }
}
