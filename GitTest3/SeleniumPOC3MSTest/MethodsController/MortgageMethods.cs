using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace SeleniumPOC3MSTest.MethodsController
{
    public class MortgageMethods : EnvironmentConfig.EnviornmentConfig
    {
        public void EnterHomeValue()
        {
            EnvironmentConfig.EnviornmentConfig.Driver.Navigate().GoToUrl("http://www.mortgagecalculator.org/");
          
        }

        public IWebElement SearchElement()
        {
          
            IWebElement Element=driver.FindElement(By.Name("param[homevalue]"));
        
            return Element;
        }
    }
}
