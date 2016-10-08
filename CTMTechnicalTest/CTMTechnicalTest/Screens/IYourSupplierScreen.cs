using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMTechnicalTest.Screens
{
        public interface IYourSupplier
        {
            By PostCodeTextField { get; }
            By FindPostCodeButton { get; }
            By ChangePostcodeLink { get; }
            By SelectHaveBills { get; }
            By SelectNoBills { get; }
            By SelectGasAndElectricity { get; }
            By SelectElectricityOnly { get; }
            By SelectGasOnly { get; }
            By SelectYes { get; }
            By SelectNo { get; }
            By SelectBritishGas { get; }
            By SelectEDFEnergy { get; }
            By SelectEon { get; }
            By SelectingItemInDDL { get; }
            By NextButton { get; }
            By GandESupplierSameRNSection { get; }
            By WhoSupplyEnergy { get; }
            By YourEnergypageTitle { get; }
        

    }
}
