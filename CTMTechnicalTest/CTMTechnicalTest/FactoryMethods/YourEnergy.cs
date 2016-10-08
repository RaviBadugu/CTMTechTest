using CTMTechnicalTest.Locators;
using CTMTechnicalTest.Screens;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace CTMTechnicalTest.FactoryMethods
{
        static class YourEnergy
        {
            static readonly IYourEnergyScreen yourEnergyScreen = new YourEnergyLocators();
        

        public static IYourEnergyScreen YourEnergyScreen(this IWebDriver driver)
            {
                return yourEnergyScreen;
            }

        //Navigating to Your Energy Page

        public static void NavigateToYourEnergyPage(this IYourEnergyScreen _ctmHome)
        {
            TestData.driverObj.Navigate().GoToUrl(TestUrl.CTMUrl);
            TestData.driverObj.FindElement(_ctmHome.PostCodeTextField).SendKeys("PE2 6YS");
            System.Threading.Thread.Sleep(8000);
            TestData.driverObj.FindElement(_ctmHome.FindPostCodeButton).Click();
            System.Threading.Thread.Sleep(8000);
            TestData.driverObj.FindElement(_ctmHome.SupplierNextButton).Click();

        }

        //Selecting a drop down list for electricty tariff

        public static void SelectEnergyTariffDDL(this IYourEnergyScreen _ctmHome, string value)
        {
             new SelectElement(TestData.driverObj.FindElement(_ctmHome.ElectricityTariffDDL)).SelectByText(value);
        }

        //Selecting a drop down list for how do you pay your electricty

        public static void SelectHowDoYouPayEDDL(this IYourEnergyScreen _ctmHome, string value)
        {
            new SelectElement(TestData.driverObj.FindElement(_ctmHome.ElectricitySpendDDL)).SelectByText(value);
        }

        //Clicking Economy meter option

        public static void ClickEconomy7No(this IYourEnergyScreen _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.Economy7No).Click();
        }

        //Clicking Main Electricity Heating Source option Yes or No

        public static void ClickMainElecSourceNo(this IYourEnergyScreen _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.ElectricityMainHeatingSource).Click();
        }

        //Clicking Main Gas Heating Source option Yes or No

        public static void ClickMainGasSourceNo(this IYourEnergyScreen _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.GasMainHeatingSource).Click();
        }

        //Clicking on Electricity usage

        public static void ClickElecUsageKWP(this IYourEnergyScreen _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.ElectricityUsage).Click();
        }

        //Clicking on Gas usage

        public static void ClickGasUsageKWP(this IYourEnergyScreen _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.GasUsage).Click();
        }

        //Clicking on ELectricity details Next Button

        public static void ClickElecNextBtn(this IYourEnergyScreen _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.ElecNextButton).Click();
        }

        //Clicking on Gas details Next Button

        public static void ClickGasNextBtn(this IYourEnergyScreen _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.GasNextButton).Click();
        }

        //Entering value in Electricity KWP text field

        public static void EnterTextIntoElecKWPTextBox(this IYourEnergyScreen _ctmHome, string value)
        {
            //System.Threading.Thread.Sleep(4000);
            TestData.driverObj.FindElement(_ctmHome.ElectricitySpendTextField).SendKeys(value);

        }

        //Entering value in Gas KWP text field

        public static void EnterTextIntoGasKWPTextBox(this IYourEnergyScreen _ctmHome, string value)
        {
            TestData.driverObj.FindElement(_ctmHome.GasSpendTextField).SendKeys(value);
        }

        ////Verifying Whether the Text entered in PostCodeTextField or not

        public static bool VerifyPandCPageDisplayed(this IYourEnergyScreen _ctmHome)
        {
            TestData.driverObj.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            return (TestData.driverObj.FindElement(_ctmHome.YourPandCPageTitle).Displayed);
        }
    }
}
