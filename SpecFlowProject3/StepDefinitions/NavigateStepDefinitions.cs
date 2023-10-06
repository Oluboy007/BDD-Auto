using SpecFlowProject3.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject3.StepDefinitions
{
    [Binding]
    public class NavigateStepDefinitions
    {
        HomePage homePage = new HomePage(); 

        [Given(@"\[I am on the tfl website]")]
        public void GivenIAmOnTheTflWebsite()
        {
            homePage.NavigateToUrl();
            homePage.ClearCookies();    
        }

        [Then(@"\[I am able to see the landing page]")]
        public void ThenIAmAbleToSeeTheLandingPage()
        {
            homePage.LandingPage().Should().BeTrue();   
        }
    }
}
