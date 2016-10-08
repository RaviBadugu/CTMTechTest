using CTMTechnicalTest.Screens;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMTechnicalTest.Locators
{
        class YourSupplierLocators : IYourSupplier
        {
            public By PostCodeTextField
            {
                get { return By.Id("your-postcode"); }
            }

            public By FindPostCodeButton
            {
                get { return By.Id("find-postcode"); }
            }

            public By ChangePostcodeLink
            {
                get { return By.Id("change-postcode"); }
            }

            public By SelectHaveBills
            {
                get { return By.Id("have-bill-label"); }
            }

            public By SelectNoBills
            {
                get { return By.Id("no-bill-label"); }
            }

            public By SelectGasAndElectricity
            {
                get { return By.ClassName("compare-what-both"); }
            }

            public By SelectElectricityOnly
            {
                get { return By.Id("compare-what-electricity"); }
            }

            public By SelectGasOnly
            {
                get { return By.Id("compare-what-gas"); }
            }

            public By SelectYes
            {
                get { return By.Id("same-supplier-yes"); }
            }

            public By SelectNo
            {
                get { return By.Id("same-supplier-no"); }
            }

            public By SelectBritishGas
            {
                get { return By.Id("dual-top-six-british-gas"); }
            }

            public By SelectEDFEnergy
            {
                get { return By.XPath(".//*[@id='dual-energy-suppliers-question']/div/div/label[2]/span"); }
            }

            public By SelectEon
            {
                get { return By.Id("dual-top-six-eon"); }
            }

            public By SelectingItemInDDL
            {
                get { return By.Id("sel_chosen"); }
            }

            public By NextButton
            {
                get { return By.XPath(".//*[@id='goto-your-supplier-details']"); }
            }

            public By GandESupplierSameRNSection
            {
                get { return By.Id("same-supplier-question"); }
            }

            public By WhoSupplyEnergy
            {
                get { return By.Id("dual-energy-suppliers-question"); }
            }

            public By YourEnergypageTitle
        {
            //get { return By.ClassName("your-energy ng-scope"); }
            //.//*/span[contains(text(),'Your Energy')]
            get { return By.XPath(".//*/span[contains(text(),'Your Energy')]"); }
        }

    }
}
