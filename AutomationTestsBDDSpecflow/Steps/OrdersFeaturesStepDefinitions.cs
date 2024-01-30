using AutomationTestsBDDSpecflow.Pages;
using System;
using TechTalk.SpecFlow;

namespace AutomationTestsBDDSpecflow.Steps
{
    [Binding]
    public class OrdersFeaturesStepDefinitions
    {

        private OrdersPage OrdersPage = new OrdersPage();
        private NavigationPage NavigationPage = new NavigationPage();

        [When(@"I navigate to the Orders page via the Orders URL")]
        public void WhenINavigateToTheOrdersPageViaTheOrdersURL()
        {
            Console.WriteLine("Before OrdersPage Title: " + NavigationPage.getTitle());
            NavigationPage.NavigateToOrdersURL();
        }

        [Then(@"I expect to see the Orders Worklist with the Orders table visible")]
        public void ThenIExpectToSeeTheOrdersWorklistWithTheOrdersTableVisible()
        {
            OrdersPage.VerifyOrdersPageExists();
        }

        [Then(@"I expect to see Orders listed in the Worklist with all fields visible")]
        public void ThenIExpectToSeeOrdersListedInTheWorklistWithAllFieldsVisible()
        {
            throw new PendingStepException();
        }

        
        //TODO Create API response framework
        [When(@"I create a New Order via API")]
        public void WhenICreateANewOrderViaAPI()
        {
            throw new PendingStepException();
        }

        [Then(@"I expect to see the Orders Worklist updated with the New Order")]
        public void ThenIExpectToSeeTheOrdersWorklistUpdatedWithTheNewOrder()
        {
            throw new PendingStepException();
        }

        [When(@"I Create a New Order")]
        public void WhenICreateANewOrder()
        {
            OrdersPage.ClickNewOrderButton();
        }


        [When(@"I cancel an existing Order")]
        public void WhenICancelAnExistingOrder()
        {
            throw new PendingStepException();
        }

        [Then(@"I expect to see the Orders Worklist updated excluding cancelled Orders")]
        public void ThenIExpectToSeeTheOrdersWorklistUpdatedExcludingCancelledOrders()
        {
            throw new PendingStepException();
        }

        [When(@"I expect to see the Orders Worklist page")]
        public void WhenIExpectToSeeTheOrdersWorklistPage()
        {
            OrdersPage.VerifyOrdersPageExists();
        }

    }
}
