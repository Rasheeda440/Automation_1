using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using System.Windows.Forms;

namespace BOOTCAMP_SQA04_SELENIUM_01
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }


        //[TestMethod]
        //[Description("This is for demo purpose")]
        //[Owner("Yahya")]
        ////[Ignore]
        //public void TestCase_001()
        //{
        //    MessageBox.Show("TestCase_001");
        //}


        //[TestMethod]
        //[Timeout(5000)]
        //public void TestCase_002()
        //{
        //    Thread.Sleep(6000);
        //    ///MessageBox.Show("TestCase_002");
        //}

        //[TestMethod]
        //[Owner("Yahya"), WorkItem(3241)]
        //[TestCategory("Login"), TestCategory("Positive")]
        //[Description("This is for demo purpose")]
        //[Priority(1)]
        //public void TestCase_003()
        //{
        //    MessageBox.Show("TestCase_003");

        //}

        //[TestMethod]
        //[DataRow("AmirTester", "AmirTester")]
        //[DataRow("Test", "Test123")]
        //[DataRow("#@#$$#@$", "@#$#@")]
        //public void TestCase_Login_001(string user, string pass)
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://adactinhotelapp.com/";
        //    driver.FindElement(By.Id("username")).SendKeys(user);
        //    driver.FindElement(By.Id("password")).SendKeys(pass);
        //    driver.FindElement(By.Id("login")).Click();

        //    driver.Close();
        //}



        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data1.xml", "TestCase_Login_002", DataAccessMethod.Random)]
        public void TestCase_Login_002()
        {
            string pass = TestContext.DataRow["password"].ToString();
            string user = TestContext.DataRow["username"].ToString();

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys(user);
            driver.FindElement(By.Id("password")).SendKeys(pass);
            driver.FindElement(By.Id("login")).Click();

            string actualText = driver.FindElement(By.ClassName("welcome_menu")).Text;

            Assert.AreEqual("Welcome to Adactin Group of Hotels", actualText);

            driver.Close();
        }

        //[TestMethod]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"data.csv", "data#csv", DataAccessMethod.Random)]
        //public void TestCase_Login_002_CSV()
        //{
        //    string pass = TestContext.DataRow["password"].ToString();
        //    string user = TestContext.DataRow["username"].ToString();

        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://adactinhotelapp.com/";
        //    driver.FindElement(By.Id("username")).SendKeys(user);
        //    driver.FindElement(By.Id("password")).SendKeys(pass);
        //    driver.FindElement(By.Id("login")).Click();

        //    //  string actualText = driver.FindElement(By.ClassName("welcome_menu")).Text;

        //    //  Assert.AreEqual("Welcome to Adactin Group of Hotels", actualText);

        //    driver.Close();
        //}

        //[TestMethod]
        //public void TestCase_Login_003_positive()
        //{

        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://adactinhotelapp.com/";
        //    driver.FindElement(By.Id("username")).SendKeys("AmirTester");
        //    driver.FindElement(By.Id("password")).SendKeys("AmirTester");
        //    driver.FindElement(By.Id("login")).Click();

        //    string actualText = driver.FindElement(By.ClassName("welcome_menu")).Text;
        //    Assert.AreEqual("Welcome to Adactin Group of Hotels", actualText);

        //    driver.Close();
        //}


        //[TestMethod]
        //public void TestCase_Login_004_negative()
        //{

        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://adactinhotelapp.com/";
        //    driver.FindElement(By.Id("username")).SendKeys("AmirTester123");
        //    driver.FindElement(By.Id("password")).SendKeys("AmirTester123");
        //    driver.FindElement(By.Id("login")).Click();

        //    string actualText = driver.FindElement(By.ClassName("auth_error")).Text;
        //    Assert.AreEqual("Invalid Login details or Your Password might have expired. Click here to reset your password", actualText);

        //    driver.Close();
        //}



        //[TestMethod]
        //public void CheckBox()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://demoqa.com/checkbox";

        //    driver.FindElement(By.CssSelector("button[title=Toggle]")).Click();
        //    driver.FindElement(By.CssSelector(".rct-checkbox:nth-child(2)")).Click();

        //    driver.Close();

        //}


        //[TestMethod]
        //public void RadioButton()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://demoqa.com/";
        //    driver.FindElement(By.CssSelector("#app div.home-body div div:nth-child(1) div div.card-body h5")).Click();
        //    driver.FindElement(By.Id("item-2")).Click();
        //    Actions actions = new Actions(driver);

        //    IWebElement elementLocator = driver.FindElement(By.Id("yesRadio"));
        //    actions.Click(elementLocator).Build().Perform();
        //    Thread.Sleep(5000);
        //    driver.Close();

        //}

        //[TestMethod]
        //public void DemoQA_Elements_RC_Buttons()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://demoqa.com/";
        //    driver.FindElement(By.CssSelector("#app div.home-body div div:nth-child(1) div div.card-body h5")).Click();
        //    driver.FindElement(By.Id("item-4")).Click();
        //    Actions actions = new Actions(driver);
        //    IWebElement elementLocator = driver.FindElement(By.Id("rightClickBtn"));
        //    actions.ContextClick(elementLocator).Perform();
        //    Thread.Sleep(5000);
        //    driver.Close();
        //}

        //[TestMethod]
        //public void DemoQA_Elements_DC_Buttons()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://demoqa.com/";
        //    driver.FindElement(By.CssSelector("#app div.home-body div div:nth-child(1) div div.card-body h5")).Click();
        //    driver.FindElement(By.Id("item-4")).Click();
        //    Actions actions = new Actions(driver);

        //    actions.DoubleClick(driver.FindElement(By.Id("doubleClickBtn"))).Perform();
        //    Assert.AreEqual("You have done a double click", driver.FindElement(By.Id("doubleClickMessage")).Text);

        //    Thread.Sleep(5000);
        //    driver.Close();
        //}

        //#region WebTable
        //[TestMethod]
        //public void DemoQA_Elements_WebTables()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://demoqa.com/";
        //    driver.FindElement(By.CssSelector("#app div.home-body div div:nth-child(1) div div.card-body h5")).Click();
        //    driver.FindElement(By.Id("item-3")).Click();
        //    driver.FindElement(By.Id("searchBox")).SendKeys("Kierra");
        //    driver.FindElement(By.Id("addNewRecordButton")).Click();
        //    Thread.Sleep(5000);
        //    driver.Close();
        //}

        //#endregion


        //#region Window and Frame

        //[TestMethod]
        //public void NewTab()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://demoqa.com/browser-windows";
        //    driver.FindElement(By.Id("tabButton")).Click();

        //    driver.Manage().Window.Maximize();

        //    // Browser Tab Switch
        //    driver.SwitchTo().Window(driver.WindowHandles[1]);
        //    string text = driver.FindElement(By.Id("sampleHeading")).Text;
        //    Console.WriteLine(text);

        //    string title = driver.Url;
        //    Console.WriteLine(title);

        //    Thread.Sleep(5000);
        //    driver.Quit();
        //}

        //[TestMethod]
        //public void NewWindow()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://demoqa.com/browser-windows";
        //    driver.FindElement(By.Id("windowButton")).Click();

        //    // Browser Window Switch
        //    driver.SwitchTo().Window(driver.WindowHandles[1]);
        //    string text = driver.FindElement(By.Id("sampleHeading")).Text;
        //    Console.WriteLine(text);

        //    Thread.Sleep(5000);
        //    driver.Quit();
        //}

        //[TestMethod]
        //public void NewMessageWindow()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://demoqa.com/browser-windows";
        //    driver.FindElement(By.Id("messageWindowButton")).Click();

        //    // Browser Message Window Switch
        //    var handlers = driver.WindowHandles;
        //    foreach (var handler in handlers)
        //    {
        //        driver.Title.Contains("Google Chrome");
        //    }
        //    string text = driver.FindElement(By.TagName("body")).Text;
        //    Console.WriteLine(text);

        //    Thread.Sleep(5000);
        //    driver.Quit();
        //}

        //[TestMethod]
        //public void MultiFrame()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://demoqa.com/frames";
        //    IWebElement frame1 = driver.FindElement(By.Id("frame1"));
        //    driver.SwitchTo().Frame(frame1);
        //    string frame1text = driver.FindElement(By.Id("sampleHeading")).Text;
        //    Console.WriteLine(frame1text);

        //    driver.SwitchTo().DefaultContent();

        //    IWebElement frame2 = driver.FindElement(By.Id("frame2"));
        //    driver.SwitchTo().Frame(frame2);
        //    string frame2text = driver.FindElement(By.Id("sampleHeading")).Text;
        //    Console.WriteLine(frame2text);

        //    driver.Quit();
        //}

        //[TestMethod]
        //public void NestedFrame()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://demoqa.com/nestedframes";
        //    IWebElement frame1 = driver.FindElement(By.Id("frame1"));
        //    driver.SwitchTo().Frame(frame1);
        //    string parentFrameText = driver.FindElement(By.TagName("body")).Text;
        //    Console.WriteLine(parentFrameText);

        //    driver.SwitchTo().Frame(0);
        //    string childFrameText = driver.FindElement(By.TagName("p")).Text;
        //    Console.WriteLine(childFrameText);

        //    driver.Quit();
        //}

        //#endregion Window and Frame
    }

    [TestClass]
    public class UnitTest2
    {
        //[TestMethod]
        //[Description("This is for demo purpose")]
        //[Owner("Yahya")]
        ////[Ignore]
        //public void TestCase_001()
        //{
        //    MessageBox.Show("TestCase_001");
        //}


        //[TestMethod]
        //[Timeout(5000)]
        //public void TestCase_002()
        //{
        //    Thread.Sleep(6000);
        //    ///MessageBox.Show("TestCase_002");
        //}

        //[TestMethod]
        //[Owner("Yahya"), WorkItem(3241)]
        //[TestCategory("Login"), TestCategory("Positive")]
        //[Description("This is for demo purpose")]
        //[Priority(1)]
        //public void TestCase_003()
        //{
        //    MessageBox.Show("TestCase_003");

        //}

        //[TestMethod]
        //public void TestCase_Login_001()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://adactinhotelapp.com/";
        //    driver.FindElement(By.Id("username")).SendKeys("AmirTester");
        //    driver.FindElement(By.Id("password")).SendKeys("AmirTester");
        //    driver.FindElement(By.Id("login")).Click();

        //    driver.Close();

        //}
    }
}
