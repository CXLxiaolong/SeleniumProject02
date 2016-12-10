using MyDriver;
using OpenQA.Selenium;

namespace PageObject
{
    public class ForgotPasswordPage
    {
        private readonly WebDriver _driver;

        public ForgotPasswordPage(WebDriver driver)
        {
            _driver = driver;
        }

        #region Element
        public WebElement EmailAddress
        {
            get
            {
                var element = _driver.FindElement(By.Id("forgot_email_address"));
                return element;
            }
        }
        

        public WebElement ResetPassword
        {
            get
            {
                var element = _driver.FindElement(By.Id("btn_reset_pwd"));
                return element;
            }
        }

        public WebElement Back
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//input[@class='styleBtn black btnBack']"));
                return element;
            }
        }

        // Error INFO
        public WebElement ErrorMsg
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//p[@class='error']/i"));
                return element;
            }
        }
        public WebElement SendSuccessful
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@class='r_msg']"));
                return element;
            }
        }

        #endregion

        #region operation

        public void ResetPassWord(string email)
        {

            EmailAddress.Sendkeys(email);
            ResetPassword.Click();
        }

        #endregion
    }
}
