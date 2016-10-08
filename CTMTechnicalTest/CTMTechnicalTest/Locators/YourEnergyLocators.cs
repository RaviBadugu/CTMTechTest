using CTMTechnicalTest.Screens;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMTechnicalTest.Locators
{
    public  class YourEnergyLocators : IYourEnergyScreen

    {
            public By ElectricityTariffDDL
            {
                get { return By.Id("electricity_tariff_additional_info_chosen"); }
            }

            public By GasTariffDDL
            {
                get { return By.Id("gas_tariff_additional_info_chosen"); }
            }

            public By Economy7Yes
            {
                get { return By.Id("economy-7-yes"); }
            }

            public By Economy7No
            {
                get { return By.Id("economy-7-no"); }
            }

            public By ElectricityMainHeatingSource
            {
                get { return By.Id("electricity-main-heating-no"); }
            }

            public By GasMainHeatingSource
            {
                get { return By.Id("gas-main-heating-yes"); }
            }

            public By ElectricityUsage
            {
                get { return By.Id("kwhSpend"); }
            }

            public By GasUsage
            {
                get { return By.Id("kwhSpendG"); }
            }

            public By ElectricitySpendTextField
            {
                get { return By.Id("electricity-usage"); }
            }

            public By GasSpendTextField
            {
                get { return By.Id("gas-usage"); }
            }
            
            public By ElectricitySpendDDL
            {
                get { return By.Id("electricity_payment_method_dropdown_link_chosen"); }
            }

            public By GasSpendDDL
            {
                get { return By.Id("gas_payment_method_dropdown_link_chosenn"); }
            }

            public By ElectricityBillDate
            {
                get { return By.Id("electricity-bill-day"); }
            }

            public By GasBillDate
            {
                get { return By.Id("gas-bill-day"); }
            }

            public By ElecNextButton
            {
                get { return By.Id("goto-your-energy"); }
            }

            public By GasNextButton
            {
                get { return By.Id("goto-your-energy"); }
            }
            
            public By SupplierNextButton
            {
                get { return By.Id("goto-your-supplier-details"); }
            }

            public By PostCodeTextField
            {
                get { return By.Id("your-postcode"); }
            }

            public By FindPostCodeButton
            {
                get { return By.Id("find-postcode"); }
            }

            public By YourPandCPageTitle
            {
                get { return By.XPath(".//*/span[contains(text(),'Your Details')]"); }
            }
            
    }
}
