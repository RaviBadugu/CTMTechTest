using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMTechnicalTest.Screens
{
    public interface IYourPAndCDetailsScreen
    {
        By FixedTariff { get; }
        By VariableTariff { get; }
        By AllTariffs { get; }
        By MonthlyDD { get; }
        By QuaterlyDD { get; }
        By PayOnReceipt { get; }
        By AllPaymentTypes { get; }
        By EmailAddressTextField { get; }
        By AgreeCTMMailsCheckBox { get; }
        By TandCCheckbox { get; }
        By GoToPricesBtn { get; }
        By PostCodeTextField { get; }
        By FindPostCodeButton { get; }
        By SupplierNextButton { get; }
        By ElectricitySpendTextField { get; }
        By GasSpendTextField { get; }
        By ElecNextButton { get; }
        By GasNextButton { get; }
        By ResultsPageTitle { get; }
    }
}
