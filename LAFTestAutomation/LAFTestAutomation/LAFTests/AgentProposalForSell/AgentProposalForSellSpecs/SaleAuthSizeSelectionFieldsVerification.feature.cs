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
namespace LAFTests.AgentProposalForSell.AgentProposalForSellSpecs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SaleAuthSizeSelectionFieldsVerification")]
    public partial class SaleAuthSizeSelectionFieldsVerificationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SaleAuthSizeSelectionFieldsVerification.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SaleAuthSizeSelectionFieldsVerification", "\tIn order to submit the proposal for Vendors\r\n\tAs an Agent\r\n\tI want to be able to" +
                    " select Sales Authority Size", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("AgentProposalForSell_SalesAuthSelection001_Verify the Question for Sales Authorit" +
            "y Size selection")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void AgentProposalForSell_SalesAuthSelection001_VerifyTheQuestionForSalesAuthoritySizeSelection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentProposalForSell_SalesAuthSelection001_Verify the Question for Sales Authorit" +
                    "y Size selection", new string[] {
                        "mytag"});
#line 7
 this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("User navigates to Agent_Registration_Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
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
                        "Sales",
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
#line 9
 testRunner.And("User navigates to BeginProposal after registering agent with", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SaleMethods",
                        "Languages"});
            table2.AddRow(new string[] {
                        "Auctions",
                        "Arabic"});
#line 12
 testRunner.When("User navigates to Sales Authority Size Selection after selecting details as", ((string)(null)), table2, "When ");
#line 15
 testRunner.Then("Question \"How long is your standard sale authority?\" is displayed for Authority T" +
                    "eam Size selection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentProposalForSell_SalesAuthSelection002_Verify that Sales Team selection quest" +
            "ion is displayed when user clicks Next after selecting Sales Authority Size")]
        public virtual void AgentProposalForSell_SalesAuthSelection002_VerifyThatSalesTeamSelectionQuestionIsDisplayedWhenUserClicksNextAfterSelectingSalesAuthoritySize()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentProposalForSell_SalesAuthSelection002_Verify that Sales Team selection quest" +
                    "ion is displayed when user clicks Next after selecting Sales Authority Size", ((string[])(null)));
#line 17
 this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("User navigates to Agent_Registration_Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
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
                        "AgencyBranch",
                        "PrincipalFirstName",
                        "PrincipalLastName",
                        "PrincipalPhone",
                        "PrincipalMobile",
                        "PrincipalEmail"});
            table3.AddRow(new string[] {
                        "Sales",
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
#line 19
 testRunner.And("User navigates to BeginProposal after registering agent with", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "SaleMethods",
                        "Languages"});
            table4.AddRow(new string[] {
                        "Auctions",
                        "Arabic"});
#line 22
 testRunner.When("User navigates to Sales Authority Size Selection after selecting details as", ((string)(null)), table4, "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SaleAuthoritySize"});
            table5.AddRow(new string[] {
                        "1 month"});
#line 25
 testRunner.And("User clicks Next after selecting Sales Authority Size As", ((string)(null)), table5, "And ");
#line 28
 testRunner.Then("Sales Team selection question is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentProposalForSell_SalesAuthSelection003_Verify that under Progress section, Au" +
            "thority circle should be displayed as Active")]
        public virtual void AgentProposalForSell_SalesAuthSelection003_VerifyThatUnderProgressSectionAuthorityCircleShouldBeDisplayedAsActive()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentProposalForSell_SalesAuthSelection003_Verify that under Progress section, Au" +
                    "thority circle should be displayed as Active", ((string[])(null)));
#line 30
 this.ScenarioSetup(scenarioInfo);
#line 31
 testRunner.Given("User navigates to Agent_Registration_Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
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
                        "AgencyBranch",
                        "PrincipalFirstName",
                        "PrincipalLastName",
                        "PrincipalPhone",
                        "PrincipalMobile",
                        "PrincipalEmail"});
            table6.AddRow(new string[] {
                        "Sales",
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
#line 32
 testRunner.And("User navigates to BeginProposal after registering agent with", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SaleMethods",
                        "Languages"});
            table7.AddRow(new string[] {
                        "Auctions",
                        "Arabic"});
#line 35
 testRunner.When("User navigates to Sales Authority Size Selection after selecting details as", ((string)(null)), table7, "When ");
#line 38
 testRunner.Then("Authority circle should be displayed as Active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentProposalForSell_SalesAuthSelection004_Verify that under Progress section, Au" +
            "thority circle should be displayed as Checked on navigating to next section")]
        public virtual void AgentProposalForSell_SalesAuthSelection004_VerifyThatUnderProgressSectionAuthorityCircleShouldBeDisplayedAsCheckedOnNavigatingToNextSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentProposalForSell_SalesAuthSelection004_Verify that under Progress section, Au" +
                    "thority circle should be displayed as Checked on navigating to next section", ((string[])(null)));
#line 40
 this.ScenarioSetup(scenarioInfo);
#line 41
 testRunner.Given("User navigates to Agent_Registration_Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
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
            table8.AddRow(new string[] {
                        "Sales",
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
#line 42
 testRunner.And("User navigates to BeginProposal after registering agent with", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "SaleMethods",
                        "Languages"});
            table9.AddRow(new string[] {
                        "Auctions",
                        "Arabic"});
#line 45
 testRunner.When("User navigates to Sales Authority Size Selection after selecting details as", ((string)(null)), table9, "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "SaleAuthoritySize"});
            table10.AddRow(new string[] {
                        "1 month"});
#line 48
 testRunner.And("User clicks Next after selecting Sales Authority Size As", ((string)(null)), table10, "And ");
#line 51
 testRunner.Then("Authority circle should be displayed as Checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AgentProposalForSell_SalesAuthSelection005_Verify options under Sale Authority Se" +
            "lection drop down")]
        public virtual void AgentProposalForSell_SalesAuthSelection005_VerifyOptionsUnderSaleAuthoritySelectionDropDown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AgentProposalForSell_SalesAuthSelection005_Verify options under Sale Authority Se" +
                    "lection drop down", ((string[])(null)));
#line 53
 this.ScenarioSetup(scenarioInfo);
#line 54
 testRunner.Given("User navigates to Agent_Registration_Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
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
                        "AgencyBranch",
                        "PrincipalFirstName",
                        "PrincipalLastName",
                        "PrincipalPhone",
                        "PrincipalMobile",
                        "PrincipalEmail"});
            table11.AddRow(new string[] {
                        "Sales",
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
#line 55
 testRunner.And("User navigates to BeginProposal after registering agent with", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "SaleMethods",
                        "Languages"});
            table12.AddRow(new string[] {
                        "Auctions",
                        "Arabic"});
#line 58
 testRunner.When("User navigates to Sales Authority Size Selection after selecting details as", ((string)(null)), table12, "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "SaleAuthoritySize"});
            table13.AddRow(new string[] {
                        "No exclusivity"});
            table13.AddRow(new string[] {
                        "1 month"});
            table13.AddRow(new string[] {
                        "2 months"});
            table13.AddRow(new string[] {
                        "3 months"});
            table13.AddRow(new string[] {
                        "4 months"});
            table13.AddRow(new string[] {
                        "5 months"});
            table13.AddRow(new string[] {
                        "6 months"});
            table13.AddRow(new string[] {
                        "9 months"});
            table13.AddRow(new string[] {
                        "12 months"});
#line 61
 testRunner.Then("Below options should be available under Sale Authority Selection drop down", ((string)(null)), table13, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
