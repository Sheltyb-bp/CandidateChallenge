using AutomationTestsBDDSpecflow.Pages;
using System;
using TechTalk.SpecFlow;

namespace AutomationTestsBDDSpecflow.Steps
{
    [Binding]
    public class OrdersFeature_NewOrdersStepDefinitions
    {

        private Orders_NewOrderPage NewOrderPage = new Orders_NewOrderPage();
        private NavigationPage NavigationPage = new NavigationPage();

 

        [When(@"I submit the New Order with only mandatory fields filled in with valid values")]
        public void WhenISubmitTheNewOrderWithOnlyMandatoryFieldsFilledInWithValidValues()
        {
            throw new PendingStepException();
        }

        [Then(@"I expect to see the Order successfully created")]
        public void ThenIExpectToSeeTheOrderSuccessfullyCreated()
        {
            throw new PendingStepException();
        }

        [Then(@"I expect to see the New Order in the Orders Worklist")]
        public void ThenIExpectToSeeTheNewOrderInTheOrdersWorklist()
        {
            throw new PendingStepException();
        }

        [When(@"I submit the New Order with no fields filled in")]
        public void WhenISubmitTheNewOrderWithNoFieldsFilledIn()
        {
            throw new PendingStepException();
        }

        [Then(@"I expect to remain on the Create Orders page")]
        public void ThenIExpectToRemainOnTheCreateOrdersPage()
        {
            throw new PendingStepException();
        }

        [Then(@"I expect to see field validation error messages for all mandatory Orders fields")]
        public void ThenIExpectToSeeFieldValidationErrorMessagesForAllMandatoryOrdersFields()
        {
            throw new PendingStepException();
        }

        [When(@"I fill in the New Patient details with valid values")]
        public void WhenIFillInTheNewPatientDetailsWithValidValues()
        {
            throw new PendingStepException();
        }

        [When(@"I fill in the Study Details valid values")]
        public void WhenIFillInTheStudyDetailsValidValues()
        {
            throw new PendingStepException();
        }

        [When(@"I cancel the New Order before submitting")]
        public void WhenICancelTheNewOrderBeforeSubmitting()
        {
            NewOrderPage.CancelButtonClick();
            
        }

        [Then(@"I expect to see the cancellation message")]
        public void ThenIExpectToSeeTheCancellationMessage()
        {
            throw new PendingStepException();
        }
    }
}
