using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using SeleniumPOC3MSTest.EnvironmentConfig;
using SeleniumPOC3MSTest.MethodsController;


namespace SeleniumPOC3MSTest
{
    [TestClass]
    public class UnitTest1 : EnvironmentConfig.EnviornmentConfig
    {
        EnvironmentConfig.EnviornmentConfig config = new EnvironmentConfig.EnviornmentConfig();
        MortgageMethods methods = new MortgageMethods();
        
        [TestInitialize]
        //public void TestInit()
        //{
        //    config.
        //}

        //[TestCleanup]
        //public void TestCloseup()
        //{
        //    // driver.Close();

        //}
        //New Comment for source tree
        //second comment
        //final comment

        [TestMethod]
        public void TestMethod1()
        {
            methods.EnterHomeValue();
            
            methods.SearchElement().Clear();
           
            methods.SearchElement().SendKeys("500000");
            //methods.EnterHomeValue();
            ////driver.Navigate().GoToUrl("http://www.mortgagecalculator.org/");
            driver.FindElement(By.Name("param[homevalue]")).Clear();
            driver.FindElement(By.Name("param[homevalue]")).SendKeys("500000");
            //driver.FindElement(By.Name("param[principal]")).Clear();
            //driver.FindElement(By.Name("param[principal]")).SendKeys("300000");
            //driver.FindElement(By.Name("param[interest_rate]")).Clear();
            //driver.FindElement(By.Name("param[interest_rate]")).SendKeys("3");
            //driver.FindElement(By.Name("param[term]")).Clear();
            //driver.FindElement(By.Name("param[term]")).SendKeys("20");
            
        }
    }
}
