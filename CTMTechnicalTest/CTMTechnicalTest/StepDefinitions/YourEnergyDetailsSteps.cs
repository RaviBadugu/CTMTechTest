using CTMTechnicalTest.Locators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using CTMTechnicalTest.FactoryMethods;

namespace CTMTechnicalTest.StepDefinitions
{

    
        [Binding]

        public class YourEnergyDetailsSteps
        {
        private YourEnergyLocators objYourEnergyLocators = new YourEnergyLocators();

        CommonTestDataForPageObj commonTestData = new CommonTestDataForPageObj();

        #region As a user I want enter all the energy details in your energy screen and click next button

        [Given(@"As a user I am in your energy page")]
        public void GivenAsAUserIAmInYourEnergyPage()
        {
            TestData.driverObj.YourEnergyScreen().NavigateToYourEnergyPage();
            Console.WriteLine("Navigating to Your Energy Page");
        }

        [When(@"I enter all the energy details in your energy screen")]
        public void WhenIEnterAllTheEnergyDetailsInYourEnergyScreen()
        {
            commonTestData.TestDataForEnergyPage();
        }

        [When(@"I click on the next button")]
        public void WhenIClickOnTheNextButton()
        {
            TestData.driverObj.YourEnergyScreen().ClickGasNextBtn();
        }

        [Then(@"I should navigate to the your details page")]
        public void ThenIShouldNavigateToTheYourDetailsPage()
        {
            TestData.driverObj.YourEnergyScreen().VerifyPandCPageDisplayed();
        }

        #endregion

    }
}
