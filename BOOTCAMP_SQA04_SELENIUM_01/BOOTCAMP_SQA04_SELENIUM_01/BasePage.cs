using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.HeadlessExperimental;
using OpenQA.Selenium.Interactions;
using System;
using System.Configuration;
using System.Security.Policy;
using System.Threading;
using System.Windows.Forms;

namespace BOOTCAMP_SQA04_SELENIUM_01
{

    public class BasePage
    {
        public static IWebDriver driver;
        public static string Headless = ConfigurationManager.AppSettings["Headless"].ToString();
        public static string browser = ConfigurationManager.AppSettings["ExecutionBrowser"].ToString();

        public static void SeleniumInitialization()
        {
            if (browser == "Chrome")
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("-start-maximized");

                if (Headless == "True")
                {
                    options.AddArguments("-headless");
                }

                driver = new ChromeDriver(options);
            }
            else if (browser == "Firefox")
            { 
            
            }
        }

        public static void TestClose()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        public void Write(By by, string data)
        {
            driver.FindElement(by).SendKeys(data);
        }

        public static void OpenURL(string url)
        {
            driver.Url = url;
        }

        public void Click(By by)
        {
            driver.FindElement(by).Click();       
        }

        public void Clear(By by)
        {
            driver.FindElement(by).Clear();
        }
    }
}