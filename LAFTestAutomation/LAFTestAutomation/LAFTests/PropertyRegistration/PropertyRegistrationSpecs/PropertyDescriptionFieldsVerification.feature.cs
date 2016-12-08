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
namespace LAFTests.PropertyRegistration.PropertyRegistrationSpecs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PropertyDescriptionFieldsVerification")]
    public partial class PropertyDescriptionFieldsVerificationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PropertyDescriptionFieldsVerification.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PropertyDescriptionFieldsVerification", "\tIn order to register property for Sell or Rent\r\n\tAs a User\r\n\tI want to be able t" +
                    "o proceed after selecting valid Property Description.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("PropReg_PropertyDescription001_Verify the Question for Property Description on Re" +
            "gistration Page.")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void PropReg_PropertyDescription001_VerifyTheQuestionForPropertyDescriptionOnRegistrationPage_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PropReg_PropertyDescription001_Verify the Question for Property Description on Re" +
                    "gistration Page.", new string[] {
                        "mytag"});
#line 7
 this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I am on Prop_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Category",
                        "PropType",
                        "Beds",
                        "ApproxValue",
                        "UnitAppNo",
                        "StreetNo",
                        "Street",
                        "Suburb",
                        "State",
                        "PostCode"});
            table1.AddRow(new string[] {
                        "Sell",
                        "House",
                        "One",
                        "LessThanTwoHunderedK",
                        "Unit 2",
                        "myStreet1",
                        "Harlem St",
                        "Inglewood",
                        "NSW",
                        "3137"});
#line 9
 testRunner.And("I navigate to Property Description after entering details", ((string)(null)), table1, "And ");
#line 12
 testRunner.Then("Q \"Which best describes your property?\" should be displayed for Property Descript" +
                    "ion section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PropReg_PropertyDescription002_Verify that Progress line indicates selection of A" +
            "ddress")]
        public virtual void PropReg_PropertyDescription002_VerifyThatProgressLineIndicatesSelectionOfAddress()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PropReg_PropertyDescription002_Verify that Progress line indicates selection of A" +
                    "ddress", ((string[])(null)));
#line 14
 this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("I am on Prop_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Category",
                        "PropType",
                        "Beds",
                        "ApproxValue",
                        "UnitAppNo",
                        "StreetNo",
                        "Street",
                        "Suburb",
                        "State",
                        "PostCode"});
            table2.AddRow(new string[] {
                        "Sell",
                        "House",
                        "One",
                        "LessThanTwoHunderedK",
                        "Unit 2",
                        "myStreet1",
                        "Harlem St",
                        "Inglewood",
                        "NSW",
                        "3137"});
#line 16
 testRunner.And("I navigate to Property Description after entering details", ((string)(null)), table2, "And ");
#line 19
 testRunner.Then("Progress line indicates selection of Address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PropReg_PropertyDescription003_Verify that link for Moving Forward should be disa" +
            "bled by default")]
        public virtual void PropReg_PropertyDescription003_VerifyThatLinkForMovingForwardShouldBeDisabledByDefault()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PropReg_PropertyDescription003_Verify that link for Moving Forward should be disa" +
                    "bled by default", ((string[])(null)));
#line 21
 this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("I am on Prop_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Category",
                        "PropType",
                        "Beds",
                        "ApproxValue",
                        "UnitAppNo",
                        "StreetNo",
                        "Street",
                        "Suburb",
                        "State",
                        "PostCode"});
            table3.AddRow(new string[] {
                        "Sell",
                        "House",
                        "One",
                        "LessThanTwoHunderedK",
                        "Unit 2",
                        "myStreet1",
                        "Harlem St",
                        "Inglewood",
                        "NSW",
                        "3137"});
#line 23
 testRunner.And("I navigate to Property Description after entering details", ((string)(null)), table3, "And ");
#line 26
 testRunner.Then("Link for Moving Forward is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PropReg_PropertyDescription004_Verify that under Progress section, Agent should b" +
            "e displayed as activated.")]
        public virtual void PropReg_PropertyDescription004_VerifyThatUnderProgressSectionAgentShouldBeDisplayedAsActivated_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PropReg_PropertyDescription004_Verify that under Progress section, Agent should b" +
                    "e displayed as activated.", ((string[])(null)));
#line 28
 this.ScenarioSetup(scenarioInfo);
#line 29
 testRunner.Given("I am on Prop_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Category",
                        "PropType",
                        "Beds",
                        "ApproxValue",
                        "UnitAppNo",
                        "StreetNo",
                        "Street",
                        "Suburb",
                        "State",
                        "PostCode"});
            table4.AddRow(new string[] {
                        "Sell",
                        "House",
                        "One",
                        "LessThanTwoHunderedK",
                        "Unit 2",
                        "myStreet1",
                        "Harlem St",
                        "Inglewood",
                        "NSW",
                        "3137"});
#line 30
 testRunner.And("I navigate to Property Description after entering details", ((string)(null)), table4, "And ");
#line 33
 testRunner.Then("Agent Details Progress should be displayed as activated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PropReg_PropertyDescription005_Verify that under Progress section, Agent Circle s" +
            "hould not be displayed as Filled by default.")]
        public virtual void PropReg_PropertyDescription005_VerifyThatUnderProgressSectionAgentCircleShouldNotBeDisplayedAsFilledByDefault_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PropReg_PropertyDescription005_Verify that under Progress section, Agent Circle s" +
                    "hould not be displayed as Filled by default.", ((string[])(null)));
#line 35
 this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given("I am on Prop_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Category",
                        "PropType",
                        "Beds",
                        "ApproxValue",
                        "UnitAppNo",
                        "StreetNo",
                        "Street",
                        "Suburb",
                        "State",
                        "PostCode"});
            table5.AddRow(new string[] {
                        "Sell",
                        "House",
                        "One",
                        "LessThanTwoHunderedK",
                        "Unit 2",
                        "myStreet1",
                        "Harlem St",
                        "Inglewood",
                        "NSW",
                        "3137"});
#line 37
 testRunner.And("I navigate to Property Description after entering details", ((string)(null)), table5, "And ");
#line 40
 testRunner.Then("Agent Details Progress Circle should be displayed as not Filled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PropReg_PropertyDescription006_Verify that option \"MY HOME\" should be available f" +
            "or Property Description.")]
        public virtual void PropReg_PropertyDescription006_VerifyThatOptionMYHOMEShouldBeAvailableForPropertyDescription_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PropReg_PropertyDescription006_Verify that option \"MY HOME\" should be available f" +
                    "or Property Description.", ((string[])(null)));
#line 42
 this.ScenarioSetup(scenarioInfo);
#line 43
 testRunner.Given("I am on Prop_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Category",
                        "PropType",
                        "Beds",
                        "ApproxValue",
                        "UnitAppNo",
                        "StreetNo",
                        "Street",
                        "Suburb",
                        "State",
                        "PostCode"});
            table6.AddRow(new string[] {
                        "Sell",
                        "House",
                        "One",
                        "LessThanTwoHunderedK",
                        "Unit 2",
                        "myStreet1",
                        "Harlem St",
                        "Inglewood",
                        "NSW",
                        "3137"});
#line 44
 testRunner.And("I navigate to Property Description after entering details", ((string)(null)), table6, "And ");
#line 47
 testRunner.Then("Option My Home  with text \"MY HOME\" should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PropReg_PropertyDescription007_Verify that option \"VACANT PROPERTY\" should be ava" +
            "ilable for Property Description.")]
        public virtual void PropReg_PropertyDescription007_VerifyThatOptionVACANTPROPERTYShouldBeAvailableForPropertyDescription_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PropReg_PropertyDescription007_Verify that option \"VACANT PROPERTY\" should be ava" +
                    "ilable for Property Description.", ((string[])(null)));
#line 49
 this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given("I am on Prop_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Category",
                        "PropType",
                        "Beds",
                        "ApproxValue",
                        "UnitAppNo",
                        "StreetNo",
                        "Street",
                        "Suburb",
                        "State",
                        "PostCode"});
            table7.AddRow(new string[] {
                        "Sell",
                        "House",
                        "One",
                        "LessThanTwoHunderedK",
                        "Unit 2",
                        "myStreet1",
                        "Harlem St",
                        "Inglewood",
                        "NSW",
                        "3137"});
#line 51
 testRunner.And("I navigate to Property Description after entering details", ((string)(null)), table7, "And ");
#line 54
 testRunner.Then("Option Vacant Property  with text \"VACANT PROPERTY\" should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PropReg_PropertyDescription008_Verify that option \"TENANTED PROPERTY\" should be a" +
            "vailable for Property Description.")]
        public virtual void PropReg_PropertyDescription008_VerifyThatOptionTENANTEDPROPERTYShouldBeAvailableForPropertyDescription_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PropReg_PropertyDescription008_Verify that option \"TENANTED PROPERTY\" should be a" +
                    "vailable for Property Description.", ((string[])(null)));
#line 56
 this.ScenarioSetup(scenarioInfo);
#line 57
 testRunner.Given("I am on Prop_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Category",
                        "PropType",
                        "Beds",
                        "ApproxValue",
                        "UnitAppNo",
                        "StreetNo",
                        "Street",
                        "Suburb",
                        "State",
                        "PostCode"});
            table8.AddRow(new string[] {
                        "Sell",
                        "House",
                        "One",
                        "LessThanTwoHunderedK",
                        "Unit 2",
                        "myStreet1",
                        "Harlem St",
                        "Inglewood",
                        "NSW",
                        "3137"});
#line 58
 testRunner.And("I navigate to Property Description after entering details", ((string)(null)), table8, "And ");
#line 61
 testRunner.Then("Option Tenanted Property  with text \"TENANTED PROPERTY\" should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PropReg_PropertyDescription009_Verify that Specific Agencies question should be d" +
            "isplayed when user selects \"My Home\" in Property Description.")]
        public virtual void PropReg_PropertyDescription009_VerifyThatSpecificAgenciesQuestionShouldBeDisplayedWhenUserSelectsMyHomeInPropertyDescription_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PropReg_PropertyDescription009_Verify that Specific Agencies question should be d" +
                    "isplayed when user selects \"My Home\" in Property Description.", ((string[])(null)));
#line 63
 this.ScenarioSetup(scenarioInfo);
#line 64
 testRunner.Given("I am on Prop_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Category",
                        "PropType",
                        "Beds",
                        "ApproxValue",
                        "UnitAppNo",
                        "StreetNo",
                        "Street",
                        "Suburb",
                        "State",
                        "PostCode"});
            table9.AddRow(new string[] {
                        "Sell",
                        "House",
                        "One",
                        "LessThanTwoHunderedK",
                        "Unit 2",
                        "myStreet1",
                        "Harlem St",
                        "Inglewood",
                        "NSW",
                        "3137"});
#line 65
 testRunner.And("I navigate to Property Description after entering details", ((string)(null)), table9, "And ");
#line 68
 testRunner.When("I Select option as \"MyHome\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then("Specific Agencies question should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PropReg_PropertyDescription010_Verify that field for entering Leasing Details sho" +
            "uld be available when option Vacant Property is selected")]
        public virtual void PropReg_PropertyDescription010_VerifyThatFieldForEnteringLeasingDetailsShouldBeAvailableWhenOptionVacantPropertyIsSelected()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PropReg_PropertyDescription010_Verify that field for entering Leasing Details sho" +
                    "uld be available when option Vacant Property is selected", ((string[])(null)));
#line 71
 this.ScenarioSetup(scenarioInfo);
#line 72
 testRunner.Given("I am on Prop_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Category",
                        "PropType",
                        "Beds",
                        "ApproxValue",
                        "UnitAppNo",
                        "StreetNo",
                        "Street",
                        "Suburb",
                        "State",
                        "PostCode"});
            table10.AddRow(new string[] {
                        "Sell",
                        "House",
                        "One",
                        "LessThanTwoHunderedK",
                        "Unit 2",
                        "myStreet1",
                        "Harlem St",
                        "Inglewood",
                        "NSW",
                        "3137"});
#line 73
 testRunner.And("I navigate to Property Description after entering details", ((string)(null)), table10, "And ");
#line 76
 testRunner.When("I Select option as \"VacantProperty\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("Field for entering Leasing Details should be available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PropReg_PropertyDescription011_Verify that field for entering Leasing Details sho" +
            "uld be available when option Tenanted Property is selected")]
        public virtual void PropReg_PropertyDescription011_VerifyThatFieldForEnteringLeasingDetailsShouldBeAvailableWhenOptionTenantedPropertyIsSelected()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PropReg_PropertyDescription011_Verify that field for entering Leasing Details sho" +
                    "uld be available when option Tenanted Property is selected", ((string[])(null)));
#line 79
 this.ScenarioSetup(scenarioInfo);
#line 80
 testRunner.Given("I am on Prop_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Category",
                        "PropType",
                        "Beds",
                        "ApproxValue",
                        "UnitAppNo",
                        "StreetNo",
                        "Street",
                        "Suburb",
                        "State",
                        "PostCode"});
            table11.AddRow(new string[] {
                        "Sell",
                        "House",
                        "One",
                        "LessThanTwoHunderedK",
                        "Unit 2",
                        "myStreet1",
                        "Harlem St",
                        "Inglewood",
                        "NSW",
                        "3137"});
#line 81
 testRunner.And("I navigate to Property Description after entering details", ((string)(null)), table11, "And ");
#line 84
 testRunner.When("I Select option as \"TenantedProperty\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("Field for entering Leasing Details should be available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PropReg_PropertyDescription012_Verify that error is displayed for empty Leasing D" +
            "etails field")]
        public virtual void PropReg_PropertyDescription012_VerifyThatErrorIsDisplayedForEmptyLeasingDetailsField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PropReg_PropertyDescription012_Verify that error is displayed for empty Leasing D" +
                    "etails field", ((string[])(null)));
#line 87
 this.ScenarioSetup(scenarioInfo);
#line 88
 testRunner.Given("I am on Prop_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Category",
                        "PropType",
                        "Beds",
                        "ApproxValue",
                        "UnitAppNo",
                        "StreetNo",
                        "Street",
                        "Suburb",
                        "State",
                        "PostCode"});
            table12.AddRow(new string[] {
                        "Sell",
                        "House",
                        "One",
                        "LessThanTwoHunderedK",
                        "Unit 2",
                        "myStreet1",
                        "Harlem St",
                        "Inglewood",
                        "NSW",
                        "3137"});
#line 89
 testRunner.And("I navigate to Property Description after entering details", ((string)(null)), table12, "And ");
#line 92
 testRunner.When("I Select option as \"TenantedProperty\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
 testRunner.And("Click Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.Then("Error is displayed for empty Leasing Details field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PropReg_PropertyDescription013_Verify that Specific Agencies question should be d" +
            "isplayed when user selects \"Vacant Property\" in Property Description and enters " +
            "Leasing Details")]
        public virtual void PropReg_PropertyDescription013_VerifyThatSpecificAgenciesQuestionShouldBeDisplayedWhenUserSelectsVacantPropertyInPropertyDescriptionAndEntersLeasingDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PropReg_PropertyDescription013_Verify that Specific Agencies question should be d" +
                    "isplayed when user selects \"Vacant Property\" in Property Description and enters " +
                    "Leasing Details", ((string[])(null)));
#line 96
 this.ScenarioSetup(scenarioInfo);
#line 97
 testRunner.Given("I am on Prop_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Category",
                        "PropType",
                        "Beds",
                        "ApproxValue",
                        "UnitAppNo",
                        "StreetNo",
                        "Street",
                        "Suburb",
                        "State",
                        "PostCode"});
            table13.AddRow(new string[] {
                        "Sell",
                        "House",
                        "One",
                        "LessThanTwoHunderedK",
                        "Unit 2",
                        "myStreet1",
                        "Harlem St",
                        "Inglewood",
                        "NSW",
                        "3137"});
#line 98
 testRunner.And("I navigate to Property Description after entering details", ((string)(null)), table13, "And ");
#line 101
 testRunner.When("I Select leased option as \"VacantProperty\" and enter leased details as \"Leasing D" +
                    "etails\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
 testRunner.Then("Specific Agencies question should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
