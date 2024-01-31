using AutomationTestsBDDSpecflow.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;

namespace AutomationTestsBDDSpecflow.Pages
{
    public class Orders_NewOrderPage : BasePage
    {

        private IWebElement SubmitButton => Driver.FindControl(By.XPath("/html/body/app-root/body/div/app-new-order/form/div/div[2]/div/button[1]"));
        private IWebElement CancelButton => Driver.FindControl(By.XPath("/html/body/app-root/body/div/app-new-order/form/div/div[2]/div/button[2]"));
        private IWebElement NewOrderPageHeading => Driver.FindControl(By.Id("tableLabel"));

        // Patient Information 

        private IWebElement MRN => Driver.FindControl(By.Id("mrn"));
        private IWebElement FirstName => Driver.FindControl(By.Id("first-name"));
        private IWebElement LastName => Driver.FindControl(By.Id("last-name"));
        private IWebElement SiteID => Driver.FindControl(By.Id("site-id"));
        private IWebElement AccessionNumber => Driver.FindControl(By.Id("accession-number"));
        private IWebElement Organisation => Driver.FindControl(By.Id("org-code"));
        private IWebElement Modality => Driver.FindControl(By.Id("modality"));
        private IWebElement StudyDateTime => Driver.FindControl(By.Id("study-date-time"));

        public void CancelButtonClick()
        {
            CancelButton.Click();
        }

        public string getTitle()
        {
            return Driver.Title;
        }

        public void EnterPatientMRN(string mrnprefix = "TestMRN")
        {
            var dateString = DateTime.Now.ToString("yyyyMMdd");
            MRN.SendKeys(mrnprefix + dateString);
        }

        public void EnterPatientFirstName(string firstnameprefix = "TestFirst")
        {
            var dateString = DateTime.Now.ToString("yyyyMMdd");
            FirstName.SendKeys(firstnameprefix + dateString);
        }

        public void EnterPatientLastName(string lastnameprefix = "TestLast")
        {
            var dateString = DateTime.Now.ToString("yyyyMMdd");
            LastName.SendKeys(lastnameprefix + dateString);
        }

        public void EnterStudyAccessionNumber(string accessionprefix = "T")
        {
            var dateString = DateTime.Now.ToString("MMddhhmmss");
            AccessionNumber.SendKeys(accessionprefix + dateString);
        }
   
        public void EnterStudyOrganistion(string organisation = "L")
        {
            //TODO update with Webdriver List Selection method
            Organisation.SendKeys(organisation);
            Organisation.SendKeys(Keys.Enter);
        }
        public void EnterStudySiteID(string siteid = "N")
        {
            SiteID.SendKeys(siteid);
            SiteID.SendKeys(Keys.Enter);
        }

        public void EnterStudyModality(string modality = "M")
        {
            SiteID.SendKeys(modality);
            SiteID.SendKeys(Keys.Enter);
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
