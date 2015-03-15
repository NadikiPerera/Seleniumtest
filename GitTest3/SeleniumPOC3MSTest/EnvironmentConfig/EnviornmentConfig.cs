using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumPOC3MSTest.EnvironmentConfig
{
    public  class EnviornmentConfig
    {
        public static  IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                //  Set Path for the executable file
                // System.setProperty("webdriver.ie.driver", "D:\\IEDriverServer.exe");
               // driver = new FirefoxDriver();
               //  driver = new InternetExplorerDriver();
                DesiredCapabilities capabilities = new DesiredCapabilities();
               //  capabilities = DesiredCapabilities.Chrome();
               // capabilities = DesiredCapabilities.InternetExplorer();
                capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
                capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
                driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);
                return driver;
            }
        }
    }
}
