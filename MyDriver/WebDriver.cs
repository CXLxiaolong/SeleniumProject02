using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using Support;

namespace MyDriver
{
    public  class WebDriver
    {
        public IWebDriver Driver;
        // local WebDriver
        public WebDriver(Browser browser, int timeoutSecond = 30)  // 构造函数
        {
            Log.DoLog("Start the " + browser+ " driver");
            switch (browser)
            {
                case Browser.Firefox:
                    Driver = new FirefoxDriver();
                    break;
                case Browser.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case Browser.Ie:
                    Driver = new InternetExplorerDriver();
                    break;
                case Browser.Remote:
                    Driver = new FirefoxDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("browser", browser, null);
            }
            Log.DoLog("Set implicitly wait timeout "+timeoutSecond);
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(timeoutSecond));
            Driver.Manage().Window.Maximize();
        }
        // RemoteWebDriver
        public WebDriver(string url, DesiredCapabilities capabilities, int timeoutSecond = 30)
        {
            Log.DoLog("Start the " + capabilities.BrowserName+ " driver");
            var commandExecutorUri = new Uri(url);
            Driver = new RemoteWebDriver(commandExecutorUri, capabilities);
            Log.DoLog("Set implicitly wait timeout " + timeoutSecond);
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(timeoutSecond));
            Driver.Manage().Window.Maximize();
        }

        public  WebElement FindElement(By by)
        {
            Log.DoLog("Find element " + by);
            return new WebElement(Driver.FindElement(by));
        }

        public void GotoUrl(string url)
        {
            Log.DoLog("Go to "+url);
            Driver.Navigate().GoToUrl(url);
        }

        public void Quit()
        {
            Log.DoLog("Quit the driver");
            Driver.Quit();
        }
        public string title
        {
            get
            {
                Log.DoLog("Driver the title");
                return Driver.Title;
            }

        }
        public string url
        {
            get
            {
                Log.DoLog("Driver the url");
                return Driver.Url;
            }
        }

    }

    public enum Browser
    {
        Firefox,
        Chrome,
        Ie,
        Remote
    }
}
