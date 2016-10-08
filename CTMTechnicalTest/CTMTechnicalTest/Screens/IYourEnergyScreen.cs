using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMTechnicalTest.Screens
{
    public interface IYourEnergyScreen
    {
            By ElectricityTariffDDL { get; }
            By GasTariffDDL { get; }
            By Economy7Yes { get; }
            By Economy7No { get; }
            By ElectricityMainHeatingSource { get; }
            By GasMainHeatingSource { get; }
            By ElectricityUsage { get; }
            By GasUsage { get; }
            By ElectricitySpendTextField { get; }
            By GasSpendTextField { get; }
            By ElectricitySpendDDL { get; }
            By GasSpendDDL { get; }
            By ElectricityBillDate { get; }
            By GasBillDate { get; }
            By ElecNextButton { get; }
            By GasNextButton { get; }
            By PostCodeTextField { get; }
            By FindPostCodeButton { get; }
            By SupplierNextButton { get; }
            By YourPandCPageTitle { get; }


    }
}
