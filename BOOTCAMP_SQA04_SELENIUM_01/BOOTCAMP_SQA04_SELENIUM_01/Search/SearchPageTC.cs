using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.DOM;
using OpenQA.Selenium.Interactions;
using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;

namespace BOOTCAMP_SQA04_SELENIUM_01
{
    [TestClass]
    public class SearchPageTC
    {
        private TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestInitialize]
        public void TestInit()
        {
            BasePage.SeleniumInitialization();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            BasePage.TestClose();
        }

        [TestMethod]
        public void SearchHotel()
        {
            

            LoginPage loginPage = new LoginPage();   
            SearchPage searchPage = new SearchPage();

            BasePage.OpenURL("https://adactinhotelapp.com/");
            loginPage.Login("AmirTester","AmirTester");
            searchPage.SearchHotel("Sydney");

           
            
        }    
    }
}