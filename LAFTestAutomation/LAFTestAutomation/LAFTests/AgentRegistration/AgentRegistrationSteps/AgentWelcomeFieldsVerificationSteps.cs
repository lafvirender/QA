using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.AgentRegSteps
{
    [Binding]
    class AgentWelcomeFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public AgentWelcomeFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("AgentWelcomeFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }
        [Given(@"User is on AgentSignUp Page")]
        public void GivenUserIsOnAgentSignUpPage()
        {
           BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Then(@"Heading Text ""(.*)"" is displayed")]
        public void ThenHeadingTextIsDisplayed(string qText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentWelcome.ShouldVerifyTheHeadingWith(qText));
        }

        [Given(@"User navigates to Agent Welcome section after entering details as")]
        public void GivenUserNavigatesToAgentWelcomeSectionAfterEnteringDetailsAs(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToAgentWelcomeAfterEnteringDetailsAs(agentRegFields);
        }

        [Given(@"User clicks Create My Profile")]
        public void GivenUserClicksCreateMyProfile()
        {
            BasePage.AgentRegistrationFunnel.AgentWelcome.SelectCreateProfile();
        }

        [Then(@"Complete your Proposal section should be displayed")]
        public void ThenCompleteYourProposalSectionShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.BeginAgentProposal.IsDisplayed());
        }

        [Then(@"Text ""(.*)"" should be displayed")]
        public void ThenTextShouldBeDisplayed(string text)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentWelcome.ShouldVerifyTheTextContainingFirstName(text));
        }

    }
}
