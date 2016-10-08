using CTMTechnicalTest.Screens;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMTechnicalTest.Locators
{
    class YourPAndCDetailsPageLocators : IYourPAndCDetailsScreen
    {
            public By FixedTariff
            {
                get { return By.XPath(".//*[@id='tariff-selection-question']/div/label[1]/span"); }
            }

            public By VariableTariff
            {
                get { return By.Id("pre-select-variable"); }
            }

            public By AllTariffs
            {
                get { return By.Id("pre-select-all"); }
            }

            public By MonthlyDD
            {
                get { return By.XPath(".//*[@id='payment-selection-question']/div/label[1]/span"); }
            }

            public By QuaterlyDD
            {
                get { return By.Id("pre-select-payment-quarterly"); }
            }

            public By PayOnReceipt
            {
                get { return By.Id("pre-select-payment-onbill"); }
            }

            public By AllPaymentTypes
            {
                get { return By.Id("pre-select-payment-all"); }
            }

            public By EmailAddressTextField
            {
                get { return By.Id("Email"); }
            }

            public By AgreeCTMMailsCheckBox
            {
                get { return By.XPath(".//*[@id='marketingT']/div/div[2]/label/span[2]"); }
            }

            public By TandCCheckbox
            {
                get { return By.XPath(".//*[@id='terms-label']/span[2]"); }
            }

            public By GoToPricesBtn
            {
                get { return By.Id("email-submit"); }
            }

            public By PostCodeTextField
            {
                get { return By.Id("your-postcode"); }
            }

            public By FindPostCodeButton
            {
                get { return By.Id("find-postcode"); }
            }

            public By SupplierNextButton
            {
                get { return By.Id("goto-your-supplier-details"); }
            }

            public By ElecNextButton
            {
                get { return By.Id("goto-your-energy"); }
            }

            public By GasNextButton
            {
                get { return By.Id("goto-your-energy"); }
            }

            public By ElectricitySpendTextField
            {
                get { return By.Id("electricity-usage"); }
            }

            public By GasSpendTextField
            {
                get { return By.Id("gas-usage"); }
            }

            public By ResultsPageTitle
            {
                get { return By.XPath(".//*/span[contains(text(),'Your Results')]"); }
            }   
    }
}
