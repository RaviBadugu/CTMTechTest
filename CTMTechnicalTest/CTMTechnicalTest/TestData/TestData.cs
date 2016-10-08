using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMTechnicalTest
{
   
        public static class TestData
        {

            //public static string HubURL = "http://10.0.21.6:4444/wd/hub";

            public static string ChromeNode = "chrome";
            public static IWebDriver driverObj = null;

        }

        public static class TestUrl
        {
            public static string CTMUrl = "https://energy.comparethemarket.com/energy/v2/?AFFCLIE=TST";
        }
    
}
