using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppiumPageObjectWindowsCalculator.Configuration
{
    public class TestEnvironmentSetup
    {
        public static WindowsDriver<WindowsElement> TestSession;
        protected static Uri AppiumDriverUri = new Uri("http://127.0.0.1:4723/wd/hub");

        public static void EnvironmentSetup(TestContext context)
        {
            if (TestSession == null)
            {
                // launch the calculator app
                DesiredCapabilities capabilities = new DesiredCapabilities();
                capabilities.SetCapability("platformName", "WINDOWS");
                capabilities.SetCapability("platform", "WINDOWS");
                capabilities.SetCapability("deviceName", "WindowsPC");
                capabilities.SetCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
                TestSession = new WindowsDriver<WindowsElement>(AppiumDriverUri, capabilities);
                Assert.IsNotNull(TestSession);
                TestSession.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(4));
            }
            Assert.IsNotNull(TestSession);
        }

        public static void TestSessionTeardDown()
        {
            TestSession.Dispose();
            TestSession = null;
        }
    }
}