using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using WebDriverManager;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Threading;
using AventStack.ExtentReports.MarkupUtils;

namespace Sele_Test
{
    [TestFixture]
    [Parallelizable]
    class Sendtext
    {

        public static ExtentTest test;
        public static ExtentReports extent;

        IWebDriver WB = null;
        string url = "http://192.168.0.114/javad/";
        // [SetUp]
        // public void SetUp()
        // {
        //    new DriverManager().SetUpDriver(new ChromeConfig());
        //    //WB = new ChromeDriver();
        //    //WB = new ChromeDriver(@"C:\WebDriver\bin");
        //    WB = new ChromeDriver(@"C:\Windows\System32\Selenium");
        // }


        [OneTimeSetUp]
        public void ExtentStart()
        {

            extent = new ExtentReports();
            var htmlreporter = new ExtentHtmlReporter(@"D:\Report_Device\" + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + "\\Rep.html", AventStack.ExtentReports.Reporter.Configuration.ViewStyle.SPA);
            extent.AttachReporter(htmlreporter);

        }

        public void Openbrowser()
        {
            //Create Browser
            WB = null;
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless");
            WB = new ChromeDriver(@"C:\Windows\System32\Selenium");
            WB.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //WB = new ChromeDriver();
            WB.Navigate().GoToUrl(url);
        }
        public void Login(string userName = "admin", string password = "123")
        {


            //Find Element By Name
            IWebElement El = WB.FindElement(By.Name("ctl00$ContentPlaceHolder1$txtUserCode"));
            IWebElement PS = WB.FindElement(By.Name("ctl00$ContentPlaceHolder1$txtPassword"));
            IWebElement Sbut = WB.FindElement(By.Name("ctl00$ContentPlaceHolder1$btnLogin"));

            //Send Key
            El.SendKeys(userName);
            PS.SendKeys(password);
            Sbut.Click();
            //test = null;
            //test = extent.CreateTest("Login-Test").Info("Login");
            //test.Log(Status.Info, "login SuccessFully");
            // /Console.BackgroundColor = ConsoleColor.DarkBlue;
            //  Console.WriteLine("---> Login Successfully!\n");
            //  Console.BackgroundColor = ConsoleColor.Black;
            // Test Definition_traffic_regulations

            // FinancialYear();
        }

        public void Definition_traffic_regulations()
        {
            url = "http://192.168.0.114/javad/Basic/AttendanceControlOptions/13";
            Openbrowser();
            Login();
            IWebElement BtnNew = WB.FindElement(By.ClassName("btn-outline-info"));
            BtnNew.Click();
            IWebElement ZoneCode = WB.FindElement(By.Id("txtAttendanceControlCode"));
            IWebElement ZoneName = WB.FindElement(By.Id("txtAttendanceControlTitle"));
            IWebElement ZoneFDate = WB.FindElement(By.Id("txtFromDate"));
            IWebElement ZoneTDate = WB.FindElement(By.Id("txtToDate"));
            IWebElement ZoneD1Fh = WB.FindElement(By.Id("txtSaturdayFromTime"));
            IWebElement ZoneD1Th = WB.FindElement(By.Id("txtSaturdayToTime"));
            IWebElement ZoneD2Fh = WB.FindElement(By.Id("txtSundayFromTime"));
            IWebElement ZoneD2Th = WB.FindElement(By.Id("txtSundayToTime"));
            IWebElement ZoneD3Fh = WB.FindElement(By.Id("txtMondayFromTime"));
            IWebElement ZoneD3Th = WB.FindElement(By.Id("txtMondayToTime"));
            IWebElement ZoneD4Fh = WB.FindElement(By.Id("txtTuesdayFromTime"));
            IWebElement ZoneD4Th = WB.FindElement(By.Id("txtTuesdayToTime"));
            IWebElement ZoneD5Fh = WB.FindElement(By.Id("txtWednesdayFromTime"));
            IWebElement ZoneD5Th = WB.FindElement(By.Id("txtWednesdayToTime"));
            IWebElement ZoneD6Fh = WB.FindElement(By.Id("txtThursdayFromTime"));
            IWebElement ZoneD6Th = WB.FindElement(By.Id("txtThursdayToTime"));
            IWebElement ZoneD7Fh = WB.FindElement(By.Id("txtFridayFromTime"));
            IWebElement ZoneD7Th = WB.FindElement(By.Id("txtFridayToTime"));
            IWebElement Btnsuccess = WB.FindElement(By.Id("btnSaveDevice"));
            var FromH = "00:00";
            var ToH = "23:59";


            //Random
            Random rd = new Random();
            int rand_num = rd.Next(10000, 20000);
            //
            ZoneCode.SendKeys(Convert.ToString(rand_num));
            ZoneName.SendKeys("Test" + Convert.ToString(rand_num));
            ZoneFDate.SendKeys("1401/11/01");
            ZoneTDate.SendKeys("1401/12/30");
            ZoneD1Fh.SendKeys(FromH);
            ZoneD2Fh.SendKeys(FromH);
            ZoneD3Fh.SendKeys(FromH);
            ZoneD4Fh.SendKeys(FromH);
            ZoneD5Fh.SendKeys(FromH);
            ZoneD6Fh.SendKeys(FromH);
            ZoneD7Fh.SendKeys(FromH);
            ZoneD1Th.SendKeys(ToH);
            ZoneD2Th.SendKeys(ToH);
            ZoneD3Th.SendKeys(ToH);
            ZoneD4Th.SendKeys(ToH);
            ZoneD5Th.SendKeys(ToH);
            ZoneD6Th.SendKeys(ToH);
            ZoneD7Th.SendKeys(ToH);

            Btnsuccess.Click();



        }
        public void Definition_Building()
        {
            url = "http://192.168.0.114/javad/Basic/Building/13";
            //url = "http://192.168.0.70:1010/Basic/Building/13";
            Openbrowser();
            Login();
            IWebElement BtnNew = WB.FindElement(By.ClassName("btn-outline-info"));
            BtnNew.Click();

            //Random
            //Random rd = new Random();
            //string rand_num = Convert.ToString(rd.Next(1, 256));
            //

            //IWebElement ZoneD7Th = WB.FindElement(By.Id("txtFridayToTime"));
            IWebElement buildingName = WB.FindElement(By.Id("txtBuildingName"));
            IWebElement buildingDisc = WB.FindElement(By.Id("txtBuildingDescription"));
            IWebElement Btnsuccess = WB.FindElement(By.ClassName("btn-success"));
            buildingName.SendKeys("Tower");
            buildingDisc.SendKeys("Test Add Building Id :");
            Btnsuccess.Click();
            Console.WriteLine(buildingName);
            Console.WriteLine(buildingDisc);
        }


        [Test]

        public void TestFlow()
        {
            //Login();
            //Definition_traffic_regulations();
            //Definition_Building();
            // url = "http://192.168.0.114/javad/Attendance/Devices/24";
            url = "http://192.168.0.151/madaktosite/Attendance/Devices/24";
            Openbrowser();
            Login();
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(4000);
                Definition_Device(i);
            }
        }
        public async void Definition_Device(int i)
        {
            test = extent.CreateTest("Definition_Device" + i).Info("Definition_Device" + i);
            //test = test.CreateNode(new GherkinKeyword("1234"), "test1234");
            // test = extent.CreateTest("Definition_Device").Info("Definition_Device");            
            //test.Log(Status.Info, "login SuccessFully");            
            WB.Navigate().GoToUrl(url);
            Thread.Sleep(2000);
            IWebElement BtnNew = WB.FindElement(By.ClassName("btn-outline-info"));
            BtnNew.Click();
            IWebElement DeviceName = WB.FindElement(By.Id("txtDeviceName"));
            IWebElement DeviceNumber = WB.FindElement(By.Id("txtDeviceNumber"));
            IWebElement MacSN = WB.FindElement(By.Id("txtMacSN"));
            IWebElement DeviceModel = WB.FindElement(By.Id("drpDeviceModel"));
            IWebElement IpAddress = WB.FindElement(By.Id("txtIpAddress"));
            IWebElement DevicePort = WB.FindElement(By.Id("txtDevicePort"));
            //IWebElement btnSaveDevice = WB.FindElement(By.Id("btnSaveDevice"));
            IJavaScriptExecutor javaScript = (IJavaScriptExecutor)WB;
            javaScript.ExecuteScript("getLastCodeByTableName($('#txtDeviceCode'),'attTblDevices')");
            javaScript.ExecuteScript("$('#selDeviceType').val(['1','2']).trigger('change')");




            //Random
            Random rd = new Random();
            string rand_num = Convert.ToString(rd.Next(1, 255));
            //

            DeviceName.SendKeys("Device" + rand_num);
            DeviceNumber.SendKeys(rand_num);
            MacSN.SendKeys("SN-" + rand_num);
            DeviceModel.SendKeys("MD 260");
            IpAddress.Clear();
            IpAddress.SendKeys(Convert.ToString(rd.Next(1, 255)) + "." + Convert.ToString(rd.Next(1, 255)) + "." + Convert.ToString(rd.Next(1, 255)) + "." + Convert.ToString(rd.Next(1, 255)));
            DevicePort.SendKeys("4370");
            try
            {
                var btnSave = WB.FindElement(By.Id("btnSaveDevice"));
                Thread.Sleep(4000);
                btnSave.Click();
                Thread.Sleep(3000);
                IWebElement operationStatus = WB.FindElement(By.Id("MadaktoUnitTestMessage"));
                string jsonResult = operationStatus.Text;
                if (string.IsNullOrEmpty(jsonResult))
                {
                    test.Log(Status.Fail, "Test UnComplete : " + "عملیات تست نافص شده فیلد ها پر نشده است");
                    return;
                }
                var tmp2 = JsonConvert.DeserializeObject(jsonResult);
                List<TestResult> tmp = JsonConvert.DeserializeObject<List<TestResult>>(jsonResult);
                foreach (var item in tmp)
                {
                    if (tmp != null && item.MessageType != "Success")
                    {
                        test.Fail(item.Message);
                    }
                    else if (tmp != null)
                        test.Log(Status.Pass, "Test Pass`: " + item.Message);
                }
                //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h3[contains(.,'WELCOME :)')]")));
                //Test Result
            }

            catch (Exception e)

            {               
                test.Log(Status.Fail, "Test Fail : " + "عملیات تست نافص شده");
                throw;

            }

            javaScript.ExecuteScript("$('#MadaktoUnitTestMessage').html('')");
            //btnSaveDevice.Click();
            test.Extent.Flush();
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

        public void FinancialYear()
        {
            //var yourParentElement = WB.FindElement(By.XPath(".//ul[class='row']"));
            //var children = yourParentElement.FindElements(By.XPath("*"));
            //foreach (c = children)
            //{
            //    Console.WriteLine(c);
            //}

            //IWebElement FY_newfy = WB.FindElement(By.xpath("//ul[@class='toc chapters']"));
            //FY_newfy.Click();
            IWebElement FY_code = WB.FindElement(By.Id("txtYearCode"));
            IWebElement FY_Title = WB.FindElement(By.Id("txtYearTitle"));
            IWebElement FY_FromDate = WB.FindElement(By.Id("txtYearFromDate"));
            IWebElement FY_ToDate = WB.FindElement(By.Id("txtYearToDate"));
            // IWebElement FY_ChYear = WB.FindElement(By.Id("chkYearStatus"));
            //IWebElement FY_Sbut = WB.FindElements(By.ClassName("btn-success"));

            FY_code.SendKeys("1403");
            FY_Title.SendKeys("Sel1403");
            FY_FromDate.SendKeys("1403/01/01");
            FY_ToDate.SendKeys("1403/12/29");

            // Console.WriteLine(FY_Sbut);

        }

        [TearDown]
        public void Closebrowser()
        {
            Console.WriteLine("Closing Browser ...");
        }
    }
    public class TestResult : AventStack.ExtentReports.Gherkin.Model.IGherkinFormatterModel
    {
        public string MessageType { get; set; }
        public string Message { get; set; }
    }
}
