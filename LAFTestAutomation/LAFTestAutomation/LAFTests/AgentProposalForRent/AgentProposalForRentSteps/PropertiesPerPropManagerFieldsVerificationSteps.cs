using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using LAFTestAutomationFramework.Reporting;


namespace LAFTests.AgentProposalForRent.AgentProposalForRentSteps
{
    [Binding]
    public class PropertiesPerPropManagerFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public PropertiesPerPropManagerFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("PropertiesPerPropManagerFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User goes to Agent_Registration_Page")]
        public void GivenUserGoesToAgent_Registration_Page()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User goes to Begin_Proposal after registering agent with")]
        public void GivenUserGoesToBegin_ProposalAfterRegisteringAgentWith(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [When(@"User navigates to Properties Per Property Manager page  after entering details as")]
        public void WhenUserNavigatesToPropertiesPerPropertyManagerPageAfterEnteringDetailsAs(Table table)
        {
            var landlordProposalFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.ShouldNavigateToPropertyPerPropManagerPageAfterEnteringDetailsAs(landlordProposalFields);
        }

        [Then(@"Question ""(.*)"" is displayed for Properties Per Property Manager")]
        public void ThenQuestionIsDisplayedForPropertiesPerPropertyManager(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.PropertyPerPropertyManager.ShouldVerifyTheQuestionWith(qText));
        }

        [When(@"User clicks Next after entering Properties Per Property Manager As")]
        public void WhenUserClicksNextAfterEnteringPropertiesPerPropertyManagerAs(Table table)
        {
            var landlordProposalFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.PropertyPerPropertyManager.SetPropPerPropManagerFieldAs(landlordProposalFields.PropertyPerPropManager);
        }

        [Then(@"Language Selection question is displayed")]
        public void ThenLanguageSelectionQuestionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.IsDisplayed());
        }

        [When(@"User clicks on Next")]
        public void WhenUserClicksOnNext()
        {
            BasePage.AgentProposalForRentFunnel.PropertyPerPropertyManager.ClickNext();
        }

        [Then(@"Error with msg ""(.*)"" is displayed")]
        public void ThenErrorWithMsgIsDisplayed(string errText)
        {
            Assert.IsTrue(BasePage.AgentProposalForRentFunnel.PropertyPerPropertyManager.ShouldVerifyThatErrorIsDisplayed(errText));
        }

        [Then(@"Properties circle should be displayed as Active")]
        public void ThenPropertiesCircleShouldBeDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatPropertiesIsActiveInProgressBar());
        }

        [Then(@"Properties circle should be displayed as Checked")]
        public void ThenPropertiesCircleShouldBeDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatPropertiesCircleIsChecked());
        }

    }
}
