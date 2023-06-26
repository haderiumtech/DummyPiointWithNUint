using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DummyPiointWithNUint
{
    internal class TestCasesReport
    {
        private static ExtentReports extent;
        private static ExtentTest test;


        private static ExtentReports StartReporting()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+ @"..\..\..\..\Test Case Html Report\";
            if (extent==null)
            {
                Directory.CreateDirectory(path);
                extent = new ExtentReports();
                var htmlReport = new ExtentHtmlReporter(path);
                extent.AttachReporter(htmlReport);
            }
            return extent;
        }
        public static void CreateTest(string testName)
        {
            test = StartReporting().CreateTest(testName);
        }
        public static void EndReport()
        {
            StartReporting().Flush();
        }
        public static void LogInfo(string info)
        {
            test.Info(info);
        }
        public static void LogPass(string info)
        {
            test.Pass(info);
        }
        public static void LogFail(string info)
        {
            test.Fail(info);
        }
        public static void LogScreenShot(string info, string image)
        {
            test.Info(info, MediaEntityBuilder.CreateScreenCaptureFromBase64String(image).Build());
        }

        //public void InitializeReport()
        //{
        //    string reportPath = @"D:\Ali Hammad Hassan\Automatin project\DummyPiointWithNUint\";
        //    var htmlReporter = new ExtentHtmlReporter(reportPath);
        //    extent = new ExtentReports();
        //    extent.AttachReporter(htmlReporter);
        //}

        //public void CreateTest(string testName)
        //{
        //    test = extent.CreateTest(testName);
        //}

        //public void LogTestStep(Status status, string stepDescription)
        //{
        //    test.Log(status, stepDescription);
        //}

        //public void LogTestStep(Status status, string stepDescription, MediaEntityModelProvider mediaEntity)
        //{
        //    test.Log(status, stepDescription, mediaEntity);
        //}

        //public void LogScreenshot(string screenshotPath)
        //{
        //    test.AddScreenCaptureFromPath(screenshotPath);
        //}

        //public void EndTest()
        //{
        //    extent.Flush();
        //}
    }
}
