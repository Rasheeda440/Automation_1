using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using System.Windows.Forms;

namespace BOOTCAMP_SQA04_SELENIUM_01
{

    public class LoginPage : BasePage
    {
        #region  LOCATORS      

        By usernameTXT = By.CssSelector("#username");
        By passwordTXT = By.XPath("//*[@id=\"password\"]");
        By loginBTN = By.Id("login");
        By rememberMeCHK = By.Id("");

        #endregion

        #region PAGE METHODS
        public void Login(IWebDriver driver)
        {

            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("AmirTester");
            driver.FindElement(By.Id("password")).SendKeys("AmirTester");
            driver.FindElement(By.Id("login")).Click();

        }


        public void Login(string pageUrl, string user, string pass)
        {
            driver.Url = pageUrl;
            driver.FindElement(By.Id("username")).SendKeys(user);
            driver.FindElement(By.Id("password")).SendKeys(pass);
            driver.FindElement(By.Id("login")).Click();
        }


        public void Login(string user, string pass, int a=0)
        {
            driver.FindElement(usernameTXT).SendKeys(user);
            driver.FindElement(passwordTXT).SendKeys(pass);
            driver.FindElement(loginBTN).Click();
        }


        public void Login(string user, string pass)
        {
            Write(usernameTXT, user);
            Write(passwordTXT, pass);
            Click(loginBTN);
        }


        #endregion
    }
}