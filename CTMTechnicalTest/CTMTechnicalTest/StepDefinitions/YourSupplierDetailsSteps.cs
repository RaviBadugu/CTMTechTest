using CTMTechnicalTest.FactoryMethods;
using CTMTechnicalTest.Locators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CTMTechnicalTest.StepDefinitions
{
        [Binding]

        public class YourSupplierDetailsSteps
        {

        private YourSupplierLocators objYourSupplierLocators = new YourSupplierLocators();

        # region As a user I want to enter all the supplier details and click next

        [Given(@"As a user I am in your supplier page")]
        public void GivenAsAUserIAmInYourSupplierPage()
        {
            TestData.driverObj.YourSupplierScreen().NavigateToCTMHome();

            Console.WriteLine("Navigating to Your Suppier Page");
        }

        [When(@"I have entered the supplier postcode")]
        public void WhenIHaveEnteredTheSupplierPostcode()
        {
            TestData.driverObj.YourSupplierScreen().EnterTextIntoPostCodeText("PE2 6YS");

            Console.WriteLine("Entering Text into Postcode text field");
        }

        [When(@"I Click on find postcode button")]
        public void WhenIClickOnFindPostcodeButton()
        {
            TestData.driverObj.YourSupplierScreen().ClickFindPostCodeButton();
            
            Console.WriteLine("Clicking Find Postcode button");
        }

        [When(@"I select yes I have my bill option")]
        public void WhenISelectYesIHaveMyBillOption()
        {
            TestData.driverObj.YourSupplierScreen().ClickHaveBills();

            Console.WriteLine("Clicking on yes i have bill");
        }

        [When(@"I click on next button")]
        public void WhenIClickOnNextButton()
        {
            System.Threading.Thread.Sleep(4000);

            TestData.driverObj.YourSupplierScreen().ClickNextButton();

            Console.WriteLine("Clicking on next button");
        }

        [Then(@"I should navigate to your energy screen")]
        public void ThenIShouldNavigateToYourEnergyScreen()
        {
            TestData.driverObj.YourSupplierScreen().VerifyYourEnergyPageDisplayed();

            Console.WriteLine("Verfying whether navigated to your energy screen or not");
        }

        #endregion

    }
}
