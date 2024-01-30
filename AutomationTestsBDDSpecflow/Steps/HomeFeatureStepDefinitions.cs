using AutomationTestsBDDSpecflow.Pages;
using System;
using TechTalk.SpecFlow;

namespace AutomationTestsBDDSpecflow.Steps
{
    [Binding]
    public class HomeFeatureStepDefinitions
    {

        private HomePage HomePage = new HomePage();
        private OrdersPage OrdersPage = new OrdersPage();
        private NavigationPage NavigationPage = new NavigationPage();

        [Given(@"I am an Authorised Administrator of the Worklist Orders portal")]
        public void GivenIAmAnAuthorisedAdministratorOfTheWorklistOrdersPortal()
        {
            Console.WriteLine("Authorised Administrator details loaded...TODO");
            //throw new PendingStepException();
        }

        [When(@"I navigate to the base website URL")]
        public void WhenINavigateToTheBaseWebsiteURL()
        {
            Console.WriteLine("Before HomePage Title: " + NavigationPage.getTitle());
            NavigationPage.NavigateToHomeURL();
            
            //throw new PendingStepException();
        }

        [Then(@"I should see the Home page by default")]
        public void ThenIShouldSeeTheHomePageByDefault()
        {
            Console.WriteLine("Checking HomePage Title: " + HomePage.getTitle());
            HomePage.VerifyHomePageExists();
        }

        [Then(@"I should see the Home menu option")]
        public void ThenIShouldSeeTheHomeMenuOption()
        {
            NavigationPage.VerifyHomeMenuExists();
        }

        [Then(@"I should see the Orders menu option")]
        public void ThenIShouldSeeTheOrdersMenuOption()
        {
            NavigationPage.VerifyOrdersMenuExists();
        }

        [When(@"I navigate to the Orders page via the Orders menu option")]
        public void WhenINavigateToTheOrdersPageViaTheOrdersMenuOption()
        {
            NavigationPage.ClickOrdersMenuOption();
        }

        [Then(@"I expect to see the Orders Worklist page")]
        public void ThenIExpectToSeeTheOrdersWorklistPage()
        {
            OrdersPage.VerifyOrdersPageExists();
        }

        [When(@"I select the Home Menu option")]
        public void WhenISelectTheHomeMenuOption()
        {
            NavigationPage.ClickHomeMenuOption();
        }
    }
}
