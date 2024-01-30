using AutomationTestsBDDSpecflow.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;

namespace AutomationTestsBDDSpecflow.Pages
{
    public class NavigationPage : BasePage
    {
        // Page Elements
        private IWebElement HomeMenuButton => Driver.FindControl(By.XPath("/html/body/app-root/body/app-nav-menu/header/nav/div/div/ul/li[1]/a"));
        private IWebElement OrdersMenuButton => Driver.FindControl(By.XPath("/html/body/app-root/body/app-nav-menu/header/nav/div/div/ul/li[2]/a"));
        private string OrdersURL = "https://localhost:44449/orders/";
        private IWebElement PageTitle => Driver.FindControl(By.XPath("/html/head/title"));

        // Page Methods
        public void ClickHomeMenuOption()
        {
            HomeMenuButton.Click();
        }

        public void ClickOrdersMenuOption()
        {
            OrdersMenuButton.Click();
        }

        public string getTitle()
        {
            return Driver.Title;
        }

        public void NavigateToHomeURL()
        {
            Driver.Navigate().GoToUrl(ConfigSettings.TestCaseURL);
        }

        public void NavigateToOrdersURL()
        {
            NavigateToHomeURL();
            Driver.Navigate().GoToUrl(OrdersURL);
            //ClickOrdersMenuOption();
        }

        public void VerifyOrdersMenuExists()
        {
            Assert.Multiple(() => {
                Assert.AreEqual(true, OrdersMenuButton.Enabled);
                //Assert.AreEqual("My account", MyAccountTab.Text);
            });
        }

        public void VerifyHomeMenuExists()
        {
            Assert.Multiple(() => {
                Assert.AreEqual(true, HomeMenuButton.Enabled);
                //Assert.AreEqual("My account", MyAccountTab.Text);
            });
        }

    }
}
