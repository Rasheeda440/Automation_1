using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;

namespace BOOTCAMP_SQA04_SELENIUM_01
{
    [TestClass]
    public class LoginPageTC
    {
        private TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            BasePage.SeleniumInitialization();
        }

        [ClassCleanup]
        public static void ClassClean()
        {
            BasePage.driver.Close();
        }

        [TestInitialize]
        public void TestInit()
        {
           
        }

        [TestCleanup]
        public void TestCleanup()
        {
          
        }


        [TestMethod]
        public void Login_Positive_001()
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();

            //LoginPage loginPage = new LoginPage();
            //loginPage.Login(driver);

            //driver.Close();
        }



        [TestMethod]
        public void Login_Positive_002()
        {
           
            
            LoginPage loginPage = new LoginPage();
            loginPage.Login("https://adactinhotelapp.com/", "AmirTester","AmirTester");

           
        }

        [TestMethod]
        public void Login_Positive_003()
        {
         
            BasePage.driver.Url = "https://adactinhotelapp.com/";

            LoginPage loginPage = new LoginPage();
            loginPage.Login("AmirTester", "AmirTester");

            
        }


    }
}