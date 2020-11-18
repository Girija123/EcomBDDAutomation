using EcomBDDAutomation.PageObjects;
using EcomBDDAutomation.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EcomBDDAutomation.StepBindings
{
    [Binding]
    public sealed class MenuVerificationSteps : CommonFunctions
    {
        HomePage homePage = null;

        [Given(@"I'm on HomePage ""(.*)""")]
        public void GivenIMOnHomePage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"I click on Menu Option")]
        public void WhenIClickOnMenuOption()
        {
            homePage = new HomePage(driver);
            homePage.MouseOverMenu();
        }

        [Then(@"I should see list of appropriate subMenu Options")]
        public void ThenIShouldSeeListOfAppropriateSubMenuOptions()
        {
        }
    }
}
