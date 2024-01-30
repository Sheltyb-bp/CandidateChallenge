using AutomationTestsBDDSpecflow.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;

namespace AutomationTestsBDDSpecflow.Pages
{
    public class Orders_NewOrderPage : BasePage
    {

        private IWebElement SubmitButton => Driver.FindControl(By.XPath("/html/body/app-root/body/div/app-new-order/form/div/div[2]/div/button[1]"));
        private IWebElement CancelButton => Driver.FindControl(By.XPath("/html/body/app-root/body/div/app-new-order/form/div/div[2]/div/button[1]"));
        private IWebElement NewOrderPageHeading => Driver.FindControl(By.Id("tableLabel"));
        public void CancelButtonClick()
        {
            CancelButton.Click();
        }

        public string getTitle()
        {
            return Driver.Title;
        }


        public void VerifyNewOrderPageExists()
        {
            //TODO Add all Assertions to show that we are on the Orders Page
            Assert.Multiple(() => {
                Assert.AreEqual("Orders", NewOrderPageHeading.Text);
                Assert.AreEqual("Cancel", CancelButton.Text);
                Assert.AreEqual("Submit", SubmitButton.Text);
                //Assert.AreEqual("My account", MyAccountTab.Text);
            });
        }
    }
}
