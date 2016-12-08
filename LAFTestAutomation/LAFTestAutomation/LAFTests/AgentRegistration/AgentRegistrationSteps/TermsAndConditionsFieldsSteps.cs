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
    public class TermsAndConditionsFieldsSteps : TestInitialization
    {
        Reporter Reporter;
        public TermsAndConditionsFieldsSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("TermsAndConditionsFieldsSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }


        [Given(@"User navigates to AgentSignUp Page")]
        public void GivenUserNavigatesToAgentSignUpPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Then(@"Text ""(.*)"" is displayed")]
        public void ThenTextIsDisplayed(string qText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.TermsAndConditions.ShouldVerifyTheHeadingWith(qText));
        }

        [Given(@"User navigates to Terms And Conditions section after entering details as")]
        public void GivenUserNavigatesToTermsAndConditionsSectionAfterEnteringDetailsAs(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToTermsAndCondAfterEnteringDetailsAs(agentRegFields);
        }

        [Given(@"User Accepts the Terms and Conditions")]
        public void GivenUserAcceptsTheTermsAndConditions()
        {
            BasePage.AgentRegistrationFunnel.TermsAndConditions.AcceptTheTerms();
        }

        [Then(@"Agent Welcome section should be displayed")]
        public void ThenAgentWelcomeSectionShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentWelcome.IsDisplayed());
        }


        [Then(@"Submit button is displayed as Disabled")]
        public void ThenSubmitButtonIsDisplayedAsDisabled()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.TermsAndConditions.ShouldVerifyThatSubmitButtonIsDisabled());
        }

        [Given(@"User reads and checks the acceptance checkbox on terms and conditions")]
        public void GivenUserReadsAndChecksTheAcceptanceCheckboxOnTermsAndConditions()
        {
            BasePage.AgentRegistrationFunnel.TermsAndConditions.ReadTermsAndSelectAcceptanceCheck();
        }
        [Given(@"User deselects acceptance checkbox on terms and conditions")]
        public void GivenUserDeselectsAcceptanceCheckboxOnTermsAndConditions()
        {
            BasePage.AgentRegistrationFunnel.TermsAndConditions.DeSelectAcceptanceCheck();
        }


        [Given(@"User reads terms and conditions")]
        public void GivenUserReadsTermsAndConditions()
        {
            BasePage.AgentRegistrationFunnel.TermsAndConditions.ReadTermsTillEnd();
        }

        [Then(@"Submit button is Enabled after reading terms and condition")]
        public void ThenSubmitButtonIsEnabledAfterReadingTermsAndCondition()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.TermsAndConditions.ShouldVerifyThatSubmitButtonIsEnabled());
        }

        [When(@"User clicks Submit")]
        public void WhenUserClicksSubmit()
        {
            BasePage.AgentRegistrationFunnel.TermsAndConditions.ClickAccept();
        }

        [Then(@"Error ""(.*)"" is displayed")]
        public void ThenErrorIsDisplayed(string errText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.TermsAndConditions.ShouldVerifyThatErrorForSelectingAcceptanceCheck(errText));
        }

        [Then(@"T&Cs Circle should be displayed as not filled")]
        public void ThenTCsCircleShouldBeDisplayedAsNotFilled()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyThatTAndCsCircleIsFilledInProgressBar());
        }

    }
}
