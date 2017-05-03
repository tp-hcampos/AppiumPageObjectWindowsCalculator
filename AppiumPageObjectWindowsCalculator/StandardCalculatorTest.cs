using AppiumPageObjectWindowsCalculator.Screens;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;

namespace AppiumPageObjectWindowsCalculator
{
    [TestClass]
    public class StandardCalculatorTest : Configuration.TestEnvironmentSetup
    {
        private StandardCalculatorScreen standardCalculatorScreen;

        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
            EnvironmentSetup(context);
        }

        [ClassCleanup]
        public static void TearDown()
        {
            TestSessionTeardDown();
        }

        [TestInitialize]
        public void StartTests()
        {
            TimeOutDuration timeSpan = new TimeOutDuration(new TimeSpan(0, 0, 0, 5, 0));
            standardCalculatorScreen = new StandardCalculatorScreen();
            PageFactory.InitElements(TestSession, standardCalculatorScreen, new AppiumPageObjectMemberDecorator(timeSpan));
        }

        [TestMethod]
        public void FirstTest()
        {
            standardCalculatorScreen.TwoPlusTwo();
        }
    }
}
