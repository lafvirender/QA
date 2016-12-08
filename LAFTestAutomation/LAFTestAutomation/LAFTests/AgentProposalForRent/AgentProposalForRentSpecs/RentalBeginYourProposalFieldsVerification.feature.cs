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
namespace LAFTests.AgentProposalForRent.AgentProposalForRentSpecs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("RentalBeginYourProposalFieldsVerification")]
    public partial class RentalBeginYourProposalFieldsVerificationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RentalBeginYourProposalFieldsVerification.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "RentalBeginYourProposalFieldsVerification", "\tIn order to submit the proposal for Vendors\r\n\tAs an Agent\r\n\tI want to be able to" +
                    " Begin Proposal", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("AgentProposalForRent_BeginProposal001_Verify the Heading Text for Begin Proposal")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void AgentProposalForRent_BeginProposal001_VerifyTheHeadingTextForBeginProposal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentProposalForRent_BeginProposal001_Verify the Heading Text for Begin Proposal", new string[] {
                        "mytag"});
#line 8
 this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("User navigates to Agent_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
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
                        "AgencyBranch",
                        "PrincipalFirstName",
                        "PrincipalLastName",
                        "PrincipalPhone",
                        "PrincipalMobile",
                        "PrincipalEmail"});
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
                        "branch",
                        "PFirst",
                        "PLast",
                        "0412213456",
                        "0412213456",
                        "a@testing167658756.com"});
#line 10
 testRunner.And("User navigates to Begin_Proposal after registering Agent with details", ((string)(null)), table1, "And ");
#line 13
 testRunner.Then("Heading Text \"Complete your Proposal\" should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentProposalForRent_BeginProposal002_Verify that Property Managment Team Size se" +
            "lection section is dislayed on clicking Begin")]
        public virtual void AgentProposalForRent_BeginProposal002_VerifyThatPropertyManagmentTeamSizeSelectionSectionIsDislayedOnClickingBegin()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentProposalForRent_BeginProposal002_Verify that Property Managment Team Size se" +
                    "lection section is dislayed on clicking Begin", ((string[])(null)));
#line 15
 this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given("User navigates to Agent_Reg Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
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
                        "AgencyBranch",
                        "PrincipalFirstName",
                        "PrincipalLastName",
                        "PrincipalPhone",
                        "PrincipalMobile",
                        "PrincipalEmail"});
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
                        "branch",
                        "PFirst",
                        "PLast",
                        "0412213456",
                        "0412213456",
                        "a@testing167658756.com"});
#line 17
 testRunner.And("User navigates to Begin_Proposal after registering Agent with details", ((string)(null)), table2, "And ");
#line 20
 testRunner.And("User clicks on Begin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.Then("Property Managment Team Size selection section is dislayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
