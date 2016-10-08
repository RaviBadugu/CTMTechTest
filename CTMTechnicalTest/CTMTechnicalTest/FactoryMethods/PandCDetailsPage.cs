using CTMTechnicalTest.Locators;
using CTMTechnicalTest.Screens;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMTechnicalTest.FactoryMethods
{
    static class PandCDetailsPage
    {
        static readonly IYourPAndCDetailsScreen yourPAndCDetailsScreen = new YourPAndCDetailsPageLocators();


        public static IYourPAndCDetailsScreen YourPAndCDetailsScreen(this IWebDriver driver)
        {
            return yourPAndCDetailsScreen;
        }

        //Navigating to Your preferences and contact details Page

        public static void NavigateToYourPandCPage(this IYourPAndCDetailsScreen _ctmHome)
        {
            TestData.driverObj.Navigate().GoToUrl(TestUrl.CTMUrl);
            TestData.driverObj.FindElement(_ctmHome.PostCodeTextField).SendKeys("PE2 6YS");
            System.Threading.Thread.Sleep(4000);
            TestData.driverObj.FindElement(_ctmHome.FindPostCodeButton).Click();
            System.Threading.Thread.Sleep(4000);
            TestData.driverObj.FindElement(_ctmHome.SupplierNextButton).Click();
            System.Threading.Thread.Sleep(4000);
            TestData.driverObj.FindElement(_ctmHome.ElectricitySpendTextField).SendKeys("123");
            System.Threading.Thread.Sleep(4000);
            TestData.driverObj.FindElement(_ctmHome.ElecNextButton).Click();
            System.Threading.Thread.Sleep(4000);
            TestData.driverObj.FindElement(_ctmHome.GasSpendTextField).SendKeys("123");
            System.Threading.Thread.Sleep(4000);
            TestData.driverObj.FindElement(_ctmHome.GasNextButton).Click();

        }

        //Clicking on Interested Tariff options

        public static void ClickFixedTariff(this IYourPAndCDetailsScreen _ctmHome)
        {
            System.Threading.Thread.Sleep(4000);
            TestData.driverObj.FindElement(_ctmHome.FixedTariff).Click();
        }

        //Clicking on Payment type interested in

        public static void ClickMonthlyDD(this IYourPAndCDetailsScreen _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.MonthlyDD).Click();
        }

        //Entering Text in EmailID Text Box

        public static void EnterTextIntoEmailId(this IYourPAndCDetailsScreen _ctmHome, string pSearchText)
        {
            TestData.driverObj.FindElement(_ctmHome.EmailAddressTextField).SendKeys(pSearchText);
        }

        //Clicking on radio button to agree CTM update

        public static void ClickAgree(this IYourPAndCDetailsScreen _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.AgreeCTMMailsCheckBox).Click();
        }

        //Clicking on radio button to agree terms

        public static void ClickTerms(this IYourPAndCDetailsScreen _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.TandCCheckbox).Click();
        }

        //Clicking on go to prices

        public static void ClickGoToPrices(this IYourPAndCDetailsScreen _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.GoToPricesBtn).Click();
        }

        //Verifying Whether Results page displayed or not

        public static bool VerifyResultsPageDisplayed(this IYourPAndCDetailsScreen _ctmHome)
        {
            TestData.driverObj.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            return (TestData.driverObj.FindElement(_ctmHome.ResultsPageTitle).Displayed);
        }
    }
}
