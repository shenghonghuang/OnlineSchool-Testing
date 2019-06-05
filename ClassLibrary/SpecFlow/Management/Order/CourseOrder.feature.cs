﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ClassLibrary.SpecFlow.Management.Order
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Course Orders")]
    public partial class CourseOrdersFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CourseOrder.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Course Orders", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("View Course Orders")]
        [NUnit.Framework.CategoryAttribute("ViewCourseOrders")]
        public virtual void ViewCourseOrders()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("View Course Orders", new string[] {
                        "ViewCourseOrders"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I am in home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.Then("I click LINK of LOGIN", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.Then("I fill administrator account in [TEXTBOX|USERNAME], [TEXTBOX|PASSWORD] and click " +
                    "[BUTTON|LOGIN] on [PAGE|LOGIN]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.Then("I move mouse on the avatar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.Then("I click [MENU|MANAGEMENT] ON [PAGE|HOME]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.Then("I click [MENU|ORDER] ON [PAGE|MANAGEMENT]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.Then("I click [MENU|COURSE ORDER] ON [MENU|ORDER]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.Then("I click [BUTTON|SEARCH] ON [PAGE|COURSE ORDER]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.Then("I select 2017-12-14 22:51 on [DATETIMEPICKER|START DATE TIME] on [PAGE|COURSE ORD" +
                    "ER]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.Then("I click [BUTTON|SEARCH] ON [PAGE|COURSE ORDER]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.Then("I select 2017-12-14 22:51 on [DATETIMEPICKER|END DATE TIME] on [PAGE|COURSE ORDER" +
                    "]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.Then("I click [BUTTON|SEARCH] ON [PAGE|COURSE ORDER]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.Then("I select PAID on [DROPDOWNLIST|STATUS] on [PAGE|COURSE ORDER]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.Then("I click [BUTTON|SEARCH] ON [PAGE|COURSE ORDER]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.Then("I select ALIPAY on [DROPDOWNLIST|PAYMENT METHOD] on [PAGE|COURSE ORDER]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.Then("I click [BUTTON|SEARCH] ON [PAGE|COURSE ORDER]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.Then("I select COURSE NAME on [TEXTBOX|KEYWORD TYPE] on [PAGE|COURSE ORDER]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.Then("I click [BUTTON|SEARCH] ON [PAGE|COURSE ORDER]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

