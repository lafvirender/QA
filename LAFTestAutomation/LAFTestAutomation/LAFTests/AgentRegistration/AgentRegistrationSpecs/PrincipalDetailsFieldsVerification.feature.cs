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
namespace LAFTests.AgentRegistration.AgentRegistrationSpecs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PrincipalDetailsFieldsVerification")]
    public partial class PrincipalDetailsFieldsVerificationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PrincipalDetailsFieldsVerification.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PrincipalDetailsFieldsVerification", "\tIn order to submit the proposal\r\n\tAs an Agent\r\n\tI want to be able to register af" +
                    "ter selecting valid values in Principal Details", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("AgentSignUp_PrincipalDetails001_Verify that link for Moving Forward should be dis" +
            "abled by default")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void AgentSignUp_PrincipalDetails001_VerifyThatLinkForMovingForwardShouldBeDisabledByDefault()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentSignUp_PrincipalDetails001_Verify that link for Moving Forward should be dis" +
                    "abled by default", new string[] {
                        "mytag"});
#line 7
 this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("User is on Agent_Registration Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Interest",
                        "AgentFirstName",
                        "AgentLastName",
                        "AgentPhone",
                        "AgentMobile",
                        "AgentEmail",
                        "AgentPosition",
                        "AgencyUnitAppNo",
                        "AgencyStreetNo",
                        "AgencyStreet",
                        "AgencySuburb",
                        "AgencyState",
                        "AgencyPostCode",
                        "AgencyName",
                        "AgencyBranch"});
            table1.AddRow(new string[] {
                        "Rentals",
                        "First",
                        "Last",
                        "0412213456",
                        "0412213456",
                        "randomize",
                        "Sales Consultant",
                        "Unit1",
                        "testStreet",
                        "streetname",
                        "testSuburb",
                        "VIC",
                        "3081",
                        "testAgency",
                        "branch"});
#line 9
 testRunner.And("User navigates to Principal Details section after entering details as", ((string)(null)), table1, "And ");
#line 12
 testRunner.Then("Link for moving Forward is not enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentSignUp_PrincipalDetails002_Verify the Question for Principal Details on Agen" +
            "t SignUp.")]
        public virtual void AgentSignUp_PrincipalDetails002_VerifyTheQuestionForPrincipalDetailsOnAgentSignUp_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentSignUp_PrincipalDetails002_Verify the Question for Principal Details on Agen" +
                    "t SignUp.", ((string[])(null)));
#line 14
 this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("User is on Agent_Registration Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Interest",
                        "AgentFirstName",
                        "AgentLastName",
                        "AgentPhone",
                        "AgentMobile",
                        "AgentEmail",
                        "AgentPosition",
                        "AgencyUnitAppNo",
                        "AgencyStreetNo",
                        "AgencyStreet",
                        "AgencySuburb",
                        "AgencyState",
                        "AgencyPostCode",
                        "AgencyName",
                        "AgencyBranch"});
            table2.AddRow(new string[] {
                        "Rentals",
                        "First",
                        "Last",
                        "0412213456",
                        "0412213456",
                        "randomize",
                        "Sales Consultant",
                        "Unit1",
                        "testStreet",
                        "streetname",
                        "testSuburb",
                        "VIC",
                        "3081",
                        "testAgency",
                        "branch"});
#line 16
 testRunner.And("User navigates to Principal Details section after entering details as", ((string)(null)), table2, "And ");
#line 19
 testRunner.Then("Question \"Are you the Principal?\" should be displayed for Principal Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentSignUp_PrincipalDetails003_Verify that Progress line for Principal Details i" +
            "s not filled by default.")]
        public virtual void AgentSignUp_PrincipalDetails003_VerifyThatProgressLineForPrincipalDetailsIsNotFilledByDefault_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentSignUp_PrincipalDetails003_Verify that Progress line for Principal Details i" +
                    "s not filled by default.", ((string[])(null)));
#line 21
 this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("User is on Agent_Registration Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Interest",
                        "AgentFirstName",
                        "AgentLastName",
                        "AgentPhone",
                        "AgentMobile",
                        "AgentEmail",
                        "AgentPosition",
                        "AgencyUnitAppNo",
                        "AgencyStreetNo",
                        "AgencyStreet",
                        "AgencySuburb",
                        "AgencyState",
                        "AgencyPostCode",
                        "AgencyName",
                        "AgencyBranch"});
            table3.AddRow(new string[] {
                        "Rentals",
                        "First",
                        "Last",
                        "0412213456",
                        "0412213456",
                        "randomize",
                        "Sales Consultant",
                        "Unit1",
                        "testStreet",
                        "streetname",
                        "testSuburb",
                        "VIC",
                        "3081",
                        "testAgency",
                        "branch"});
#line 23
 testRunner.And("User navigates to Principal Details section after entering details as", ((string)(null)), table3, "And ");
#line 26
 testRunner.Then("Progress line for Principal Details is not filled by default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentSignUp_PrincipalDetails004_Verify that Yes button should be available on Pri" +
            "ncipal Details")]
        public virtual void AgentSignUp_PrincipalDetails004_VerifyThatYesButtonShouldBeAvailableOnPrincipalDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentSignUp_PrincipalDetails004_Verify that Yes button should be available on Pri" +
                    "ncipal Details", ((string[])(null)));
#line 28
 this.ScenarioSetup(scenarioInfo);
#line 29
 testRunner.Given("User is on Agent_Registration Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Interest",
                        "AgentFirstName",
                        "AgentLastName",
                        "AgentPhone",
                        "AgentMobile",
                        "AgentEmail",
                        "AgentPosition",
                        "AgencyUnitAppNo",
                        "AgencyStreetNo",
                        "AgencyStreet",
                        "AgencySuburb",
                        "AgencyState",
                        "AgencyPostCode",
                        "AgencyName",
                        "AgencyBranch"});
            table4.AddRow(new string[] {
                        "Rentals",
                        "First",
                        "Last",
                        "0412213456",
                        "0412213456",
                        "randomize",
                        "Sales Consultant",
                        "Unit1",
                        "testStreet",
                        "streetname",
                        "testSuburb",
                        "VIC",
                        "3081",
                        "testAgency",
                        "branch"});
#line 30
 testRunner.And("User navigates to Principal Details section after entering details as", ((string)(null)), table4, "And ");
#line 33
 testRunner.Then("Yes button should be available on Principal Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentSignUp_PrincipalDetails005_Verify that No button should be available on Prin" +
            "cipal Details")]
        public virtual void AgentSignUp_PrincipalDetails005_VerifyThatNoButtonShouldBeAvailableOnPrincipalDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentSignUp_PrincipalDetails005_Verify that No button should be available on Prin" +
                    "cipal Details", ((string[])(null)));
#line 35
 this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given("User is on Agent_Registration Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Interest",
                        "AgentFirstName",
                        "AgentLastName",
                        "AgentPhone",
                        "AgentMobile",
                        "AgentEmail",
                        "AgentPosition",
                        "AgencyUnitAppNo",
                        "AgencyStreetNo",
                        "AgencyStreet",
                        "AgencySuburb",
                        "AgencyState",
                        "AgencyPostCode",
                        "AgencyName",
                        "AgencyBranch"});
            table5.AddRow(new string[] {
                        "Rentals",
                        "First",
                        "Last",
                        "0412213456",
                        "0412213456",
                        "randomize",
                        "Sales Consultant",
                        "Unit1",
                        "testStreet",
                        "streetname",
                        "testSuburb",
                        "VIC",
                        "3081",
                        "testAgency",
                        "branch"});
#line 37
 testRunner.And("User navigates to Principal Details section after entering details as", ((string)(null)), table5, "And ");
#line 40
 testRunner.Then("No button should be available on Principal Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentSignUp_PrincipalDetails006_Verify that on selecting the option No on Princip" +
            "al Details, fields Principal First Name, Principal Last Nam and Principal Email " +
            "Address should be displayed")]
        public virtual void AgentSignUp_PrincipalDetails006_VerifyThatOnSelectingTheOptionNoOnPrincipalDetailsFieldsPrincipalFirstNamePrincipalLastNamAndPrincipalEmailAddressShouldBeDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentSignUp_PrincipalDetails006_Verify that on selecting the option No on Princip" +
                    "al Details, fields Principal First Name, Principal Last Nam and Principal Email " +
                    "Address should be displayed", ((string[])(null)));
#line 42
 this.ScenarioSetup(scenarioInfo);
#line 43
 testRunner.Given("User is on Agent_Registration Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Interest",
                        "AgentFirstName",
                        "AgentLastName",
                        "AgentPhone",
                        "AgentMobile",
                        "AgentEmail",
                        "AgentPosition",
                        "AgencyUnitAppNo",
                        "AgencyStreetNo",
                        "AgencyStreet",
                        "AgencySuburb",
                        "AgencyState",
                        "AgencyPostCode",
                        "AgencyName",
                        "AgencyBranch"});
            table6.AddRow(new string[] {
                        "Rentals",
                        "First",
                        "Last",
                        "0412213456",
                        "0412213456",
                        "randomize",
                        "Sales Consultant",
                        "Unit1",
                        "testStreet",
                        "streetname",
                        "testSuburb",
                        "VIC",
                        "3081",
                        "testAgency",
                        "branch"});
#line 44
 testRunner.And("User navigates to Principal Details section after entering details as", ((string)(null)), table6, "And ");
#line 47
 testRunner.When("I select option No on Principal Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("Fields Principal First Name, Principal Last Name, Principal Email Address should " +
                    "be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentSignUp_PrincipalDetails007_Verify that error is displayed for empty Principa" +
            "l First Name field")]
        public virtual void AgentSignUp_PrincipalDetails007_VerifyThatErrorIsDisplayedForEmptyPrincipalFirstNameField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentSignUp_PrincipalDetails007_Verify that error is displayed for empty Principa" +
                    "l First Name field", ((string[])(null)));
#line 50
 this.ScenarioSetup(scenarioInfo);
#line 51
 testRunner.Given("User is on Agent_Registration Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Interest",
                        "AgentFirstName",
                        "AgentLastName",
                        "AgentPhone",
                        "AgentMobile",
                        "AgentEmail",
                        "AgentPosition",
                        "AgencyUnitAppNo",
                        "AgencyStreetNo",
                        "AgencyStreet",
                        "AgencySuburb",
                        "AgencyState",
                        "AgencyPostCode",
                        "AgencyName",
                        "AgencyBranch"});
            table7.AddRow(new string[] {
                        "Rentals",
                        "First",
                        "Last",
                        "0412213456",
                        "0412213456",
                        "randomize",
                        "Sales Consultant",
                        "Unit1",
                        "testStreet",
                        "streetname",
                        "testSuburb",
                        "VIC",
                        "3081",
                        "testAgency",
                        "branch"});
#line 52
 testRunner.And("User navigates to Principal Details section after entering details as", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "PrincipalFirstName",
                        "PrincipalLastName",
                        "PrincipalEmail"});
            table8.AddRow(new string[] {
                        "",
                        "PLast",
                        "a@bcde.com"});
#line 55
 testRunner.When("I Enter values in Principal Details as", ((string)(null)), table8, "When ");
#line 58
 testRunner.Then("Error \"Your principal\'s name\" should be displayed for empty Principal First Name " +
                    "field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentSignUp_PrincipalDetails008_Verify that error is displayed for empty Principa" +
            "l Last Name field")]
        public virtual void AgentSignUp_PrincipalDetails008_VerifyThatErrorIsDisplayedForEmptyPrincipalLastNameField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentSignUp_PrincipalDetails008_Verify that error is displayed for empty Principa" +
                    "l Last Name field", ((string[])(null)));
#line 60
 this.ScenarioSetup(scenarioInfo);
#line 61
 testRunner.Given("User is on Agent_Registration Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Interest",
                        "AgentFirstName",
                        "AgentLastName",
                        "AgentPhone",
                        "AgentMobile",
                        "AgentEmail",
                        "AgentPosition",
                        "AgencyUnitAppNo",
                        "AgencyStreetNo",
                        "AgencyStreet",
                        "AgencySuburb",
                        "AgencyState",
                        "AgencyPostCode",
                        "AgencyName",
                        "AgencyBranch"});
            table9.AddRow(new string[] {
                        "Rentals",
                        "First",
                        "Last",
                        "0412213456",
                        "0412213456",
                        "randomize",
                        "Sales Consultant",
                        "Unit1",
                        "testStreet",
                        "streetname",
                        "testSuburb",
                        "VIC",
                        "3081",
                        "testAgency",
                        "branch"});
#line 62
 testRunner.And("User navigates to Principal Details section after entering details as", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "PrincipalFirstName",
                        "PrincipalLastName",
                        "PrincipalEmail"});
            table10.AddRow(new string[] {
                        "PFirst",
                        "",
                        "a@bcde.com"});
#line 65
 testRunner.When("I Enter values in Principal Details as", ((string)(null)), table10, "When ");
#line 68
 testRunner.Then("Error \"Your principal\'s last name\" should be displayed for empty Principal Last N" +
                    "ame field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentSignUp_PrincipalDetails009_Verify that error is displayed for empty Principa" +
            "l EMail Address field")]
        public virtual void AgentSignUp_PrincipalDetails009_VerifyThatErrorIsDisplayedForEmptyPrincipalEMailAddressField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentSignUp_PrincipalDetails009_Verify that error is displayed for empty Principa" +
                    "l EMail Address field", ((string[])(null)));
#line 70
 this.ScenarioSetup(scenarioInfo);
#line 71
 testRunner.Given("User is on Agent_Registration Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Interest",
                        "AgentFirstName",
                        "AgentLastName",
                        "AgentPhone",
                        "AgentMobile",
                        "AgentEmail",
                        "AgentPosition",
                        "AgencyUnitAppNo",
                        "AgencyStreetNo",
                        "AgencyStreet",
                        "AgencySuburb",
                        "AgencyState",
                        "AgencyPostCode",
                        "AgencyName",
                        "AgencyBranch"});
            table11.AddRow(new string[] {
                        "Rentals",
                        "First",
                        "Last",
                        "0412213456",
                        "0412213456",
                        "randomize",
                        "Sales Consultant",
                        "Unit1",
                        "testStreet",
                        "streetname",
                        "testSuburb",
                        "VIC",
                        "3081",
                        "testAgency",
                        "branch"});
#line 72
 testRunner.And("User navigates to Principal Details section after entering details as", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "PrincipalFirstName",
                        "PrincipalLastName",
                        "PrincipalEmail"});
            table12.AddRow(new string[] {
                        "PFirst",
                        "PLast",
                        ""});
#line 75
 testRunner.When("I Enter values in Principal Details as", ((string)(null)), table12, "When ");
#line 78
 testRunner.Then("Error \"Your principal\'s email address\" should be displayed for empty Principal Em" +
                    "ail Address field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentSignUp_PrincipalDetails010_Verify that on selecting the option Yes on Princi" +
            "pal Details, Key Information section is displayed")]
        public virtual void AgentSignUp_PrincipalDetails010_VerifyThatOnSelectingTheOptionYesOnPrincipalDetailsKeyInformationSectionIsDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentSignUp_PrincipalDetails010_Verify that on selecting the option Yes on Princi" +
                    "pal Details, Key Information section is displayed", ((string[])(null)));
#line 80
 this.ScenarioSetup(scenarioInfo);
#line 81
 testRunner.Given("User is on Agent_Registration Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Interest",
                        "AgentFirstName",
                        "AgentLastName",
                        "AgentPhone",
                        "AgentMobile",
                        "AgentEmail",
                        "AgentPosition",
                        "AgencyUnitAppNo",
                        "AgencyStreetNo",
                        "AgencyStreet",
                        "AgencySuburb",
                        "AgencyState",
                        "AgencyPostCode",
                        "AgencyName",
                        "AgencyBranch"});
            table13.AddRow(new string[] {
                        "Rentals",
                        "First",
                        "Last",
                        "0412213456",
                        "0412213456",
                        "randomize",
                        "Sales Consultant",
                        "Unit1",
                        "testStreet",
                        "streetname",
                        "testSuburb",
                        "VIC",
                        "3081",
                        "testAgency",
                        "branch"});
#line 82
 testRunner.And("User navigates to Principal Details section after entering details as", ((string)(null)), table13, "And ");
#line 85
 testRunner.When("I select option Yes on Principal Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.Then("Key Information section is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentSignUp_PrincipalDetails011_Verify that after enter Principal FirstName, Last" +
            "Name and Email address, Key Information section is displayed")]
        public virtual void AgentSignUp_PrincipalDetails011_VerifyThatAfterEnterPrincipalFirstNameLastNameAndEmailAddressKeyInformationSectionIsDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentSignUp_PrincipalDetails011_Verify that after enter Principal FirstName, Last" +
                    "Name and Email address, Key Information section is displayed", ((string[])(null)));
#line 88
 this.ScenarioSetup(scenarioInfo);
#line 89
 testRunner.Given("User is on Agent_Registration Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Interest",
                        "AgentFirstName",
                        "AgentLastName",
                        "AgentPhone",
                        "AgentMobile",
                        "AgentEmail",
                        "AgentPosition",
                        "AgencyUnitAppNo",
                        "AgencyStreetNo",
                        "AgencyStreet",
                        "AgencySuburb",
                        "AgencyState",
                        "AgencyPostCode",
                        "AgencyName",
                        "AgencyBranch"});
            table14.AddRow(new string[] {
                        "Rentals",
                        "First",
                        "Last",
                        "0412213456",
                        "0412213456",
                        "randomize",
                        "Sales Consultant",
                        "Unit1",
                        "testStreet",
                        "streetname",
                        "testSuburb",
                        "VIC",
                        "3081",
                        "testAgency",
                        "branch"});
#line 90
 testRunner.And("User navigates to Principal Details section after entering details as", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "PrincipalFirstName",
                        "PrincipalLastName",
                        "PrincipalEmail"});
            table15.AddRow(new string[] {
                        "PFirst",
                        "PLast",
                        "a@bcde.com"});
#line 93
 testRunner.When("I Enter values in Principal Details as", ((string)(null)), table15, "When ");
#line 96
 testRunner.Then("Key Information section is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentSignUp_PrincipalDetails012_Verify that Progress line for Principal Details i" +
            "s displayed as filled on navigating to next section")]
        public virtual void AgentSignUp_PrincipalDetails012_VerifyThatProgressLineForPrincipalDetailsIsDisplayedAsFilledOnNavigatingToNextSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentSignUp_PrincipalDetails012_Verify that Progress line for Principal Details i" +
                    "s displayed as filled on navigating to next section", ((string[])(null)));
#line 98
 this.ScenarioSetup(scenarioInfo);
#line 99
 testRunner.Given("User is on Agent_Registration Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Interest",
                        "AgentFirstName",
                        "AgentLastName",
                        "AgentPhone",
                        "AgentMobile",
                        "AgentEmail",
                        "AgentPosition",
                        "AgencyUnitAppNo",
                        "AgencyStreetNo",
                        "AgencyStreet",
                        "AgencySuburb",
                        "AgencyState",
                        "AgencyPostCode",
                        "AgencyName",
                        "AgencyBranch"});
            table16.AddRow(new string[] {
                        "Rentals",
                        "First",
                        "Last",
                        "0412213456",
                        "0412213456",
                        "randomize",
                        "Sales Consultant",
                        "Unit1",
                        "testStreet",
                        "streetname",
                        "testSuburb",
                        "VIC",
                        "3081",
                        "testAgency",
                        "branch"});
#line 100
 testRunner.And("User navigates to Principal Details section after entering details as", ((string)(null)), table16, "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "PrincipalFirstName",
                        "PrincipalLastName",
                        "PrincipalEmail"});
            table17.AddRow(new string[] {
                        "PFirst",
                        "PLast",
                        "a@bcde.com"});
#line 103
 testRunner.When("I Enter values in Principal Details as", ((string)(null)), table17, "When ");
#line 106
 testRunner.Then("Progress line for Principal Details is displayed as filled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
