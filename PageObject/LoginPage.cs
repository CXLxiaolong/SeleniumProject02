using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using MyDriver;

namespace PageObject
{
    public class LoginPage
    {


        private readonly WebDriver _driver;

        public LoginPage(WebDriver driver)
        {
            _driver = driver;
        }
        public WebElement Login
        {
            get
            {
                var element = _driver.FindElement(By.Id("login"));
                return element;
            }
        }

        public WebElement Email
        {
            get
            {
                var element = _driver.FindElement(By.Id("signIn_email"));
                return element;
            }
        }
        public WebElement Password
        {
            get
            {
                var element = _driver.FindElement(By.Id("siginIn_pw"));
                return element;
            }
        }

        public WebElement ErrorHeader
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//p[@class='errorHeader']"));
                return element;
            }
        }
        public WebElement ForgotPassWord
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//a[contains(@href, '/forgotPwd')]"));
                return element;
            }
        }

        public WebElement LoginOrRegister
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//h3"));
                return element;
            }
        }

        //登录操作
        public void login(string email, string password)
        {
            Email.Sendkeys(email);
            Password.Sendkeys(password);
            Login.Click();
        }


    }
}
