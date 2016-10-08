using CTMTechnicalTest.FactoryMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMTechnicalTest.StepDefinitions
{
    public class CommonTestDataForPageObj
    {
        public void TestDataForPandCPage()
        {
            System.Threading.Thread.Sleep(8000);
            TestData.driverObj.YourPAndCDetailsScreen().ClickFixedTariff();
            System.Threading.Thread.Sleep(8000);
            TestData.driverObj.YourPAndCDetailsScreen().ClickMonthlyDD();
            System.Threading.Thread.Sleep(8000);
            TestData.driverObj.YourPAndCDetailsScreen().EnterTextIntoEmailId("ravibadugu@outlook.com");
            System.Threading.Thread.Sleep(8000);
            TestData.driverObj.YourPAndCDetailsScreen().ClickAgree();
            System.Threading.Thread.Sleep(8000);
            TestData.driverObj.YourPAndCDetailsScreen().ClickTerms();
        }

        public void TestDataForEnergyPage()
        {
            System.Threading.Thread.Sleep(8000);
            TestData.driverObj.YourEnergyScreen().EnterTextIntoElecKWPTextBox("123");
            System.Threading.Thread.Sleep(4000);
            TestData.driverObj.YourEnergyScreen().ClickElecNextBtn();
            System.Threading.Thread.Sleep(4000);
            TestData.driverObj.YourEnergyScreen().EnterTextIntoGasKWPTextBox("123");
            System.Threading.Thread.Sleep(4000);
            TestData.driverObj.YourEnergyScreen().ClickGasNextBtn();
        }
    }
}
