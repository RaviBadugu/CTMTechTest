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
        static class YourSupplier
        {
            static readonly IYourSupplier yourSupplierScreen = new YourSupplierLocators();

            public static IYourSupplier YourSupplierScreen(this IWebDriver driver)
            {
                return yourSupplierScreen;
            }

       //Navigating to CTM Page

        public static void NavigateToCTMHome(this IYourSupplier _ctmHome)
        {
            TestData.driverObj.Navigate().GoToUrl(TestUrl.CTMUrl);
            
        }
       
        //Entering Text in PostCodeTextField

        public static void EnterTextIntoPostCodeText(this IYourSupplier _ctmHome, string pSearchText)
        {
            TestData.driverObj.FindElement(_ctmHome.PostCodeTextField).SendKeys(pSearchText); 
        }

        //Verifying Whether the Text entered in PostCodeTextField or not

        public static bool VerifyPostCodeTextField(this IYourSupplier _ctmHome)
        {
            return (TestData.driverObj.FindElement(_ctmHome.PostCodeTextField).Displayed);
        }

        //Clicking FindPostCodeButton

        public static void ClickFindPostCodeButton(this IYourSupplier _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.FindPostCodeButton).Click();
        }

        //Clicking HaveBills

        public static void ClickHaveBills(this IYourSupplier _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.SelectHaveBills).Click();
        }

        //Clicking GasAndElectricity

        public static void ClickGasAndElectricity(this IYourSupplier _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.SelectGasAndElectricity).Click();
        }

        //Clicking BritishGas

        public static void ClickBritishGas(this IYourSupplier _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.SelectBritishGas).Click();
        }

        //Clicking EDFEnergy

        public static void ClickEDFEnergy(this IYourSupplier _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.SelectEDFEnergy).Click();
        }

        //Clicking Eon

        public static void ClickEon(this IYourSupplier _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.SelectEon).Click();
        }

        //Clicking on Other Supplier Drop Down List

        public static void ClickOtherSupplierDDL(this IYourSupplier _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.SelectingItemInDDL).Click();
        }

        //Clicking on Next button

        public static void ClickNextButton(this IYourSupplier _ctmHome)
        {
            TestData.driverObj.FindElement(_ctmHome.NextButton).Click();
        }

        //Verifying Whether the Change PostCode link displayed or not

        public static bool VerifyChangePostCodeLink(this IYourSupplier _ctmHome)
        {
            return (TestData.driverObj.FindElement(_ctmHome.ChangePostcodeLink).Displayed);
        }

        //Verifying Whether the Gas and Electricity suppliers same or not section displayed or not

        public static bool VerifyGandESupplierSameRNSec(this IYourSupplier _ctmHome)
        {
            return (TestData.driverObj.FindElement(_ctmHome.GandESupplierSameRNSection).Displayed);
        }

        //Verifying Whether who is your energy supplier section displayed or not

        public static bool VerifyWhoSupplyEnergy(this IYourSupplier _ctmHome)
        {
            return (TestData.driverObj.FindElement(_ctmHome.WhoSupplyEnergy).Displayed);
        }

        //Verifying Whether it is navigated to your energy screen or not

        public static bool VerifyYourEnergyPageDisplayed(this IYourSupplier _ctmHome)
        {
            TestData.driverObj.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            return (TestData.driverObj.FindElement(_ctmHome.YourEnergypageTitle).Displayed);
        }
    }
}