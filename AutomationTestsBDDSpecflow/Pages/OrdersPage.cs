using AutomationTestsBDDSpecflow.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;

namespace AutomationTestsBDDSpecflow.Pages
{
    public class OrdersPage : BasePage
    {

        private IWebElement NewOrderButton => Driver.FindControl(By.XPath("/html/body/app-root/body/div/app-orders/button"));
        private IWebElement OrdersPageHeading => Driver.FindControl(By.Id("tableLabel"));
        public void ClickNewOrderButton()
        {
            NewOrderButton.Click();
        }

        public string getTitle()
        {
            return Driver.Title;
        }


        public void VerifyOrdersPageExists()
        {
            //TODO Add all Assertions to show that we are on the Orders Page
            Assert.Multiple(() => {
                Assert.AreEqual("Orders", OrdersPageHeading.Text);
                Assert.AreEqual("Create New", NewOrderButton.Text);
                //Assert.AreEqual("My account", MyAccountTab.Text);
            });
        }
    }
}
