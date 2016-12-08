using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;
using LAFTestAutomationFramework.Reporting;


namespace LAFTests.AgentProposalForSell.AgentProposalForSellSteps
{
    [Binding]
    public class AgentFeeStructureFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public AgentFeeStructureFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("AgentFeeStructureFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User goes to Agent_Registration Page")]
        public void GivenUserGoesToAgent_RegistrationPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User goes to BeginProposal Page after registering agent with details as below")]
        public void GivenUserGoesToBeginProposalPageAfterRegisteringAgentWithDetailsAsBelow(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [When(@"User navigates to Fee Structure section after entering details as")]
        public void WhenUserNavigatesToFeeStructureSectionAfterEnteringDetailsAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.ShouldNavigateToAgentFeeStructureSectionAfterEnteringDetailsAs(vendPropFields);
        }

        [Then(@"Question ""(.*)"" is displayed for Agent Fee Structure section")]
        public void ThenQuestionIsDisplayedForAgentFeeStructureSection(string text)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldVerifyTheQuestionWith(text));
        }

        [Then(@"Below options should be available under Properties between drop down")]
        public void ThenBelowOptionsShouldBeAvailableUnderPropertiesBetweenDropDown(Table table)
        {
            IList<string> values = new List<string>();
            foreach (var row in table.Rows)
            {
                values.Add((row[0].ToString()));
            }
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldDisplayThePropertyBetweenValuesAs(values));
        }

        [Then(@"Below options should be available under CommissionTypes drop down")]
        public void ThenBelowOptionsShouldBeAvailableUnderCommissionTypesDropDown(Table table)
        {
            IList<string> values = new List<string>();
            foreach (var row in table.Rows)
            {
                values.Add((row[0].ToString()));
            }
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldDisplayTheCommissionTypesValuesAs(values));
        }

        [Then(@"Below options should be available under Marketing Budget drop down")]
        public void ThenBelowOptionsShouldBeAvailableUnderMarketingBudgetDropDown(Table table)
        {
            IList<string> values = new List<string>();
            foreach (var row in table.Rows)
            {
                values.Add((row[0].ToString()));
            }
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldDisplayTheMarketingBudgetValuesAs(values));
        }

        [Then(@"Second Fee Structure section is displayed")]
        public void ThenSecondFeeStructureSectionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldVerifyThatSecondFeeStructureIsDisplayed());
        }

        [When(@"User clicks Add Higher Range button")]
        public void WhenUserClicksAddHigherRangeButton()
        {
            BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ClickAddHigherRange();
        }

        [When(@"User clicks Add Higher Range second time")]
        public void WhenUserClicksAddHigherRangeSecondTime()
        {
            BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ClickAddHigherRangeSecondTime();
        }


        [Then(@"Third Fee Structure section is displayed")]
        public void ThenThirdFeeStructureSectionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldVerifyThatThirdFeeStructureIsDisplayed());
        }

        [When(@"User selects the Commission Type as")]
        public void WhenUserSelectsTheCommissionTypeAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.AgentFeeStructure.SelectFirstFeeStructureCommissionTypeAs(vendPropFields.FirstFeeStrCommissionType);
        }

        [When(@"User enter Commission Percentage as ""(.*)""")]
        public void WhenUserEnterCommissionPercentageAs(string percentage)
        {
            BasePage.AgentProposalForSellFunnel.AgentFeeStructure.SetFirstFeeStructureCommissionPercentageAs(percentage);
        }

        [When(@"User Clicks Submit")]
        public void WhenUserClicksSubmit()
        {
            BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ClickSubmit();
        }

        [Then(@"Confirmation for Proposal Submission is displayed")]
        public void ThenConfirmationForProposalSubmissionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesProposalConfirmation.IsDisplayed());
        }

        [When(@"User enter Commission Fixed Fee as ""(.*)""")]
        public void WhenUserEnterCommissionFixedFeeAs(string fixedFee)
        {
            BasePage.AgentProposalForSellFunnel.AgentFeeStructure.SetFirstFeeStructureCommissionFixedFeeAs(fixedFee);
        }

        [When(@"User enters the Fee Structure Details as")]
        public void WhenUserEntersTheFeeStructureDetailsAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldEntertheFirstFeeStructureDetailsAs(vendPropFields);
            BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldEntertheSecondFeeStructureDetailsAs(vendPropFields);
            BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldEntertheThirdFeeStructureDetailsAs(vendPropFields);
        }

        [Then(@"Error Message ""(.*)"" is displayed")]
        public void ThenErrorMessageIsDisplayed(string errText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldVerifyThatErrorIsDisplayed(errText));
        }

        [Then(@"Value ""(.*)"" is displayed in Properties Between LowerBound and Value ""(.*)"" is displayed in Properties Between UpperBound for New Fee Structure")]
        public void ThenValueIsDisplayedInPropertiesBetweenLowerBoundAndValueIsDisplayedInPropertiesBetweenUpperBoundForNewFeeStructure(string lowerBound, string upperBound)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldVerifyTheSecondFeeStrPropBetweenLBAndUBValueWith(lowerBound, upperBound));                   
        }

        [Then(@"Value ""(.*)"" is displayed in Properties Between LowerBound and Value ""(.*)"" is displayed in Properties Between UpperBound for New Third Fee Structure")]
        public void ThenValueIsDisplayedInPropertiesBetweenLowerBoundAndValueIsDisplayedInPropertiesBetweenUpperBoundForNewThirdFeeStructure(string lowerBound, string upperBound)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldVerifyTheThirdFeeStrPropBetweenLBAndUBValueWith(lowerBound, upperBound));
        }

        [When(@"User Clicks Delete Range button")]
        public void WhenUserClicksDeleteRangeButton()
        {
            BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ClickDeleteRange();
        }

        [When(@"User Clicks Delete Range second time")]
        public void WhenUserClicksDeleteRangeSecondTime()
        {
            BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ClickDeleteRangeToDeleteSecFeeStr();
        }


        [Then(@"Third Fee Structure section is deleted and is not displayed")]
        public void ThenThirdFeeStructureSectionIsDeletedAndIsNotDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldVerifyThatThirdFeeStructureIsNotDisplayed());
        }

        [Then(@"Second Fee Structure section is deleted and is not displayed")]
        public void ThenSecondFeeStructureSectionIsDeletedAndIsNotDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentFeeStructure.ShouldVerifyThatSecondFeeStructureIsNotDisplayed());
        }

        [Then(@"Fees circle should be displayed as Active")]
        public void ThenFeesCircleShouldBeDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatFeesIsActiveInProgressBar());
        }

    }
}
