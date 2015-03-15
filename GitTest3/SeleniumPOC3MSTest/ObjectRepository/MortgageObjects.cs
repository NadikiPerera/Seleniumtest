using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumPOC3MSTest.ObjectRepository
{
    public class MortgageObjects
    {
         public MortgageObjects(IWebDriver driver)
       {
           PageFactory.InitElements(driver,this);
       }
    }
}
