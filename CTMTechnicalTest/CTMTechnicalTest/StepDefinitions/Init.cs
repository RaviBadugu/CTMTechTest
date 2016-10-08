using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CTMTechnicalTest.StepDefinitions
{
    [Binding]
    public sealed class Init
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            TestData.driverObj = new ChromeDriver(@"\\Mac\Home\Documents\Visual Studio 2015\Projects\CTMTechnicalTest\");
            
            TestData.driverObj.Navigate().GoToUrl(TestUrl.CTMUrl);

            Console.WriteLine("Before Scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TestData.driverObj.Quit();

            Console.WriteLine("After Scenario");
        }
    }
}
