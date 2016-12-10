using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Selenium.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public static IWebDriver Driver;

        [TestInitialize]
        public void TestInitialize()
        {
            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("http://localhost:8082/");
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            Driver.Manage().Window.Maximize();
            Driver.FindElement(By.XPath("//a[text()='CONTACT US']")).Click();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var topicInterested = new SelectElement(Driver.FindElement(By.Id("edit-submitted-im-interesting-in")));
            var actualValue = topicInterested.Options;
            var text = "Select a topic ...、Cloud Testing、Embedded System Testing、Globalization Testing、Offshore Test Center、System Integration Testing、Test Automation、Function Testing、Mobile Testing、Cloud Services、SKYPALACE、Mobile Test Automation、Test Automation Framework、IaaS Cloud Enablement、Desktop Virtualization、Others";
            var expectedValue = text.Split('、');
            for (var i = 0; i < actualValue.Count; i++)
            {
                topicInterested.SelectByIndex(i);
                Assert.AreEqual(expectedValue[i], topicInterested.SelectedOption.Text, "Topic Interested value not as expected at index {0}",i);
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Driver.Quit();
        }
    }
}
