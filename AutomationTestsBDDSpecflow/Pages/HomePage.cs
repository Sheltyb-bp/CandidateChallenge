using AutomationTestsBDDSpecflow.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;

namespace AutomationTestsBDDSpecflow.Pages
{
    public class HomePage : BasePage
    {
        // Page Elements
        private IWebElement HomePageHeading => Driver.FindControl(By.XPath("/html/body/app-root/body/app-nav-menu/header/nav/div/a"));

        
        // Page Methods
        public string getTitle()
        {
            return Driver.Title;
        }
        public void VerifyHomePageExists()
        {
            //TODO Add all Assertions to show that we are on the Homepage
            Assert.Multiple(() => {
                Assert.AreEqual("AutomationTestSample", HomePageHeading.Text);
                //Assert.AreEqual("My account", MyAccountTab.Text);
            });
        }
    }
}
