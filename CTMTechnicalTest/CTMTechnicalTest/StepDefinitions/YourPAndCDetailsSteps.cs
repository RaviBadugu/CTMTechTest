using CTMTechnicalTest.FactoryMethods;
using CTMTechnicalTest.Locators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CTMTechnicalTest.StepDefinitions
{
            [Binding]

            public class YourPAndCDetailsSteps
            {

            private YourPAndCDetailsPageLocators objYourPAndCDetailsPageLocators = new YourPAndCDetailsPageLocators();

            CommonTestDataForPageObj commonTestDataOBj = new CommonTestDataForPageObj();

            #region As a user I want to enter the preferences and contact details in your details page and clicking on go to prices button

            [Given(@"As a user I am in your details page")]
            public void GivenAsAUserIAmInYourDetailsPage()
            {
                TestData.driverObj.YourPAndCDetailsScreen().NavigateToYourPandCPage();
                Console.WriteLine("Navigating to Your Preferences and Details Page");
            }

            [When(@"I enter preferences and contact details in your details page")]
            public void WhenIEnterPreferencesAndContactDetailsInYourDetailsPage()
            {
                commonTestDataOBj.TestDataForPandCPage();
            }

            [When(@"I click on the go to prices button")]
            public void WhenIClickOnTheGoToPricesButton()
            {
                TestData.driverObj.YourPAndCDetailsScreen().ClickGoToPrices();
            }

            [Then(@"I should navigate to the your results page")]
            public void ThenIShouldNavigateToTheYourResultsPage()
            {
                TestData.driverObj.YourPAndCDetailsScreen().VerifyResultsPageDisplayed();
            }
        
            #endregion

    }
}
