﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Selenium.SpecRun
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("login", new string[] {
            "TestDILATO"}, SourceFile="SpecRun\\SpecFlowFeature1.feature", SourceLine=1)]
    public partial class LoginFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SpecFlowFeature1.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "login", null, ProgrammingLanguage.CSharp, new string[] {
                        "TestDILATO"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the workflow of My account login", new string[] {
                "TestCaseZenni-1",
                "loginCases"}, SourceLine=6)]
        public virtual void VerifyTheWorkflowOfMyAccountLogin()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the workflow of My account login", new string[] {
                        "TestCaseZenni-1",
                        "loginCases"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I forward to the My account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I fill in all the necessary value on the screen and login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("The account Login successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the workflow of My account login failed", new string[] {
                "TestCaseZenni-2",
                "loginCases"}, SourceLine=13)]
        public virtual void VerifyTheWorkflowOfMyAccountLoginFailed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the workflow of My account login failed", new string[] {
                        "TestCaseZenni-2",
                        "loginCases"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("I forward to the My account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.When("I fill in all the error value on the screen and login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("The error popup occurred and login failed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the workflow of forgot password", new string[] {
                "TestCaseZenni-3",
                "ForgotPassword"}, SourceLine=20)]
        public virtual void VerifyTheWorkflowOfForgotPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the workflow of forgot password", new string[] {
                        "TestCaseZenni-3",
                        "ForgotPassword"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("I forward to the My account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.When("I click the forgot your password button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.And("I fill in valid email address and reset password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.Then("The Prompt message appears", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the error email address of forgot password", new string[] {
                "TestCaseZenni-4",
                "ForgotPassword"}, SourceLine=28)]
        public virtual void VerifyTheErrorEmailAddressOfForgotPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the error email address of forgot password", new string[] {
                        "TestCaseZenni-4",
                        "ForgotPassword"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given("I forward to the My account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
 testRunner.When("I click the forgot your password button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.And("I fill in error email address and reset password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.Then("The error popup occurred and reset password failed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the workflow of logout", new string[] {
                "TestCaseZenni-5",
                "Logout"}, SourceLine=36)]
        public virtual void VerifyTheWorkflowOfLogout()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the workflow of logout", new string[] {
                        "TestCaseZenni-5",
                        "Logout"});
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
 testRunner.Given("I forward to the My account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.And("log in my account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.When("I click the my account button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.And("I click the sign out button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.Then("The account sign out successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify no login account click Account Overview the jump to the login page", new string[] {
                "TestCaseZenni-6",
                "Logout"}, SourceLine=45)]
        public virtual void VerifyNoLoginAccountClickAccountOverviewTheJumpToTheLoginPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify no login account click Account Overview the jump to the login page", new string[] {
                        "TestCaseZenni-6",
                        "Logout"});
#line 46
this.ScenarioSetup(scenarioInfo);
#line 47
 testRunner.Given("I forward to the My account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
 testRunner.When("I click the my account button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.And("I click the Account Overview button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.Then("The jump to login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void TestSaucelabs(string browser, string version, string platform, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Selenium-Remote"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Test Saucelabs", @__tags);
#line 54
this.ScenarioSetup(scenarioInfo);
#line 55
 testRunner.Given(string.Format("I connect saucelabs and choose {0} of {1} at {2}", browser, version, platform), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 56
 testRunner.And("Forward to the My account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.When("I fill in all the necessary value on the screen and login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("The account Login successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Test Saucelabs, Firefox", new string[] {
                "Selenium-Remote"}, SourceLine=60)]
        public virtual void TestSaucelabs_Firefox()
        {
            this.TestSaucelabs("Firefox", "47.0", "Windows 7", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Test Saucelabs, Chrome", new string[] {
                "Selenium-Remote"}, SourceLine=60)]
        public virtual void TestSaucelabs_Chrome()
        {
            this.TestSaucelabs("Chrome", "50.0", "Windows 10", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Test Saucelabs, Safari", new string[] {
                "Selenium-Remote"}, SourceLine=60)]
        public virtual void TestSaucelabs_Safari()
        {
            this.TestSaucelabs("Safari", "9.0", "OS X 10.11", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion