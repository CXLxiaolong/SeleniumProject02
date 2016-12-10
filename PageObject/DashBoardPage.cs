using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using MyDriver;

namespace PageObject
{
    public class DashBoardPage
    {

        private readonly WebDriver _driver;

        public DashBoardPage(WebDriver driver)
        {
            _driver = driver;
        }

        public WebElement Hello
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//h1/span"));
                return element;
            }
        }

        public WebElement FirstName
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@class='acctDashboard']/ul/li/dl[1]/dd"));
                return element;
            }
        }

        public WebElement LastName
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@class='acctDashboard']/ul/li/dl[2]/dd"));
                return element;
            }
        }
        public WebElement EmailAddress
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@class='acctDashboard']/ul/li/dl[3]/dd"));
                return element;
            }
        }


    }
}
