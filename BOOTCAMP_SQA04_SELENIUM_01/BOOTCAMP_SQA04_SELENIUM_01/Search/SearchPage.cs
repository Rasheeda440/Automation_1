using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using System.Windows.Forms;

namespace BOOTCAMP_SQA04_SELENIUM_01
{

    public class SearchPage : BasePage
    {
        public By locationDropD = By.Id("location");
        public By searchBTN = By.Id("Submit");


        public void SearchHotel(string location)
        {
            Write(locationDropD, location);
            Click(searchBTN);        
        }






    }
}