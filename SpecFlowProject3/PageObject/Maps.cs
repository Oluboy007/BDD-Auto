using OpenQA.Selenium;
using SpecFlowProject3.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.PageObject
{
    public class Maps
    {
        IWebDriver driver;
        public Maps()
        {
            driver = WebHook.driver;
        }
        private string url = ""
        public void NavigateToUrl()
        {
            driver.Navigate().GoToUrl();
        }
    }
}
