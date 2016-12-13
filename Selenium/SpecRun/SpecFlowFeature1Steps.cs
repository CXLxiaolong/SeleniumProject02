using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyDriver;
using OpenQA.Selenium.Remote;
using PageObject;
using Support;
using TechTalk.SpecFlow;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Selenium.SpecRun
{
    [Binding]
    //SpecFlowFeature1Steps
        //LoginAccountSteps
    public class SpecFlowFeature1Steps
    {
        public WebDriver Driver;
        public HomePage homepage;
        public ForgotPasswordPage forgotpassword;
        public LoginPage login;
        public DashBoardPage DashBoard;
      

        #region Verify the workflow of My account login

        [Given(@"forward to the My account page")]
        public void GivenForwardToTheMyAccountPage()
        {
            #region  Page
            Driver = new WebDriver(Browser.Firefox);
            homepage = new HomePage(Driver);
            forgotpassword = new ForgotPasswordPage(Driver);
            login = new LoginPage(Driver);
            DashBoard = new DashBoardPage(Driver);
            #endregion

            #region Steps

            Driver.GotoUrl("https://www.zennioptical.com/login");

         //   if (homepage.PopUpClose.IsDisplayed)
         //   {
        //        homepage.PopUpClose.Click();
        //    }
       //     Thread.Sleep(2000);
        //    homepage.MyAccount.Click();
         //   homepage.LoginOrSingout.Click();

            #endregion
        }



        [When(@"I fill in all the necessary value on the screen and login")]
        public void WhenIFillInAllTheNecessaryValueOnTheScreenAndLogin()
        {
           
            login.Email.Sendkeys("xiaolong.chen@dilatoit.com");
            login.Password.Sendkeys("!QAZ2wsx");
            login.Login.Click();
         
        }

        [Then(@"The account Login successful")]
        public void ThenTheAccountLoginSuccessful()
        {
            homepage.MyAccount.Click();
            homepage.AccountOverView.Click();
            DashBoard.Hello.Text.ShouldBeEqualsTo("HELLO");
            DashBoard.FirstName.Text.ShouldBeEqualsTo("chen");
            DashBoard.LastName.Text.ShouldBeEqualsTo("xiaolong");
            DashBoard.EmailAddress.Text.ShouldBeEqualsTo("xiaolong.chen@dilatoit.com");


        }
        #endregion

        #region Verify the workflow of My account login failed

        [When(@"I fill in all the error value on the screen and login")]
        public void WhenIFillInAllTheErrorValueOnTheScreenAndLogin()
        {
            login.login("xiaolong.chen@dilatoit.com", "1qaz@WSX");
        }

        [Then(@"The error popup occurred and login failed")]
        public void ThenTheErrorPopupOccurredAndLoginFailed()
        {
            Driver.url.ShouldContain("login?_requestid");
            login.ErrorHeader.Text.ShouldContain("输入的用户名或密码无效");
        }

        #endregion

        #region Verify the workflow of forgot password

        [When(@"I click the forgot your password button")]
        public void WhenIClickTheForgotYourPasswordButton()
        {
            login.ForgotPassWord.Click();
        }

        [When(@"I fill in valid email address and reset password")]
        public void WhenIFillInValidEmailAddressAndResetPassword()
        {
            forgotpassword.ResetPassWord("xiaolong.chen@dilatoit.com");
        }

        [Then(@"The Prompt message appears")]
        public void ThenThePromptMessageAppears()
        {

            forgotpassword.SendSuccessful.Text.ShouldContain("We have sent you an email with a link to reset your password. Please check your email.");

        }
        #endregion

        #region Verify the error email address of forgot password
        [When(@"I fill in error email address and reset password")]
        public void WhenIFillInErrorEmailAddressAndResetPassword()
        {
            forgotpassword.ResetPassWord("xiaolong.chen");
        }

        [Then(@"The error popup occurred and reset password failed")]
        public void ThenTheErrorPopupOccurredAndResetPasswordFailed()
        {
            forgotpassword.ErrorMsg.Text.ShouldBeEqualsTo("Email is invalid. Please enter a valid email address.");
        }

        #endregion

        #region Verify the workflow of logout

        [Given(@"log in my account")]
        public void GivenLogInMyAccount()
        {
            login.login("xiaolong.chen@dilatoit.com", "!QAZ2wsx");
        }

        [When(@"I click the my account button")]
        public void WhenIClickTheMyAccountButton()
        {
            homepage.MyAccount.Click();
        }
        [When(@"I click the sign out button")]
        public void WhenIClickTheSignOutButton()
        {
            homepage.Singout.Click();
        }

        [Then(@"The account sign out successful")]
        public void ThenTheAccountSignOutSuccessful()
        {
            Driver.url.ShouldContain("login?DPSLogout");
            login.LoginOrRegister.Text.ShouldContain("LOG IN OR REGISTER");

        }
        #endregion

        #region Selenium Grid

        [Given(@"I connect Selenium server and choose firefox to start")]
        public void GivenIConnectSeleniumServerAndChooseFirefoxToStart()
        {
            var url = "http://localhost:4444/wd/hub";
            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
            capabilities.SetCapability("Platform", "win10");
            Driver = new WebDriver(url, capabilities);
        }


        [Given(@"To the My account page")]
        public void GivenToTheMyAccountPage()
        {

            #region  Page
            homepage = new HomePage(Driver);
            forgotpassword = new ForgotPasswordPage(Driver);
            login = new LoginPage(Driver);
            DashBoard = new DashBoardPage(Driver);
            #endregion

            #region Steps

            Driver.GotoUrl("https://www.zennioptical.com");

            Thread.Sleep(2000);
            if (homepage.PopUpClose.IsDisplayed)
            {
                homepage.PopUpClose.Click();
            }
            Thread.Sleep(2000);

            homepage.MyAccount.Click();
            homepage.LoginOrSingout.Click();

            #endregion

        
        }


        #endregion

        #region RemoteWebDriver

        [Given(@"I connect saucelabs and choose (.*) of (.*) at (.*)")]
        public void GivenIConnectSaucelabsAndChooseFirefoxOfAtWindows(string p0, string p1, string p2)
        {
            var url = "http://ondemand.saucelabs.com/wd/hub";
            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability("Username", "xiaolongchen");
            capabilities.SetCapability("AccessKey", "ef6f34f2-d705-432f-bbcc-6771ee61cf11");
            capabilities.SetCapability("name", "Test");
            capabilities.SetCapability(CapabilityType.BrowserName, p0);
            capabilities.SetCapability("version", p1);
            capabilities.SetCapability("Platform", p2);
            Driver = new WebDriver(url, capabilities);
            // xiaolongchen
            //!QAZ2wsx

        }

        [Given(@"I Forward to the My account page")]
        public void GivenIForwardToTheMyAccount()
        {


            #region  Page
            homepage = new HomePage(Driver);
            forgotpassword = new ForgotPasswordPage(Driver);
            login = new LoginPage(Driver);
            DashBoard = new DashBoardPage(Driver);

            #endregion
            #region Steps
            Driver.GotoUrl("https://www.zennioptical.com/");
            Thread.Sleep(2000);
            if (homepage.PopUpClose.IsDisplayed)
            {
                homepage.PopUpClose.Click();
            }
            Thread.Sleep(2000);
            homepage.MyAccount.Click();
            homepage.LoginOrSingout.Click();
            #endregion
        }


        #endregion

        #region Common

        [BeforeScenario]
        public void BeforeScenario()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }

        #endregion
    }

}