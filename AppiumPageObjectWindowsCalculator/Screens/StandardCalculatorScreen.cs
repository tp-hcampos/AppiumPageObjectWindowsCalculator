using AppiumPageObjectWindowsCalculator.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumPageObjectWindowsCalculator.Screens
{
    class StandardCalculatorScreen
    {
        // [FindsBy(How = How.Name, Using = "Two")]
        // public WindowsElement TwoButton { get; set; }
        public WindowsElement buttonTwo = (WindowsElement)(TestEnvironmentSetup.TestSession.FindElement(By.Name("Two")));
        public WindowsElement buttonPlus = (WindowsElement)(TestEnvironmentSetup.TestSession.FindElement(By.Name("Plus")));
        // public WindowsElement buttonEquals = (WindowsElement)(TestEnvironmentSetup.TestSession.FindElement(By.Name("Equals")));
        public WindowsElement buttonEquals = (WindowsElement)(TestEnvironmentSetup.TestSession.FindElementByName("Equals"));

        public void TwoPlusTwo()
        {
            buttonTwo.Click();
            buttonPlus.Click();
            buttonTwo.Click();
            buttonEquals.Click();
        }
    }
}
