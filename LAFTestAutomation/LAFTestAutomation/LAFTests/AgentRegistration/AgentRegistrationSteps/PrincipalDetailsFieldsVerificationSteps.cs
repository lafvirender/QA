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
    class PrincipalDetailsFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public PrincipalDetailsFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("PrincipalDetailsFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User is on Agent_Registration Page")]
        public void GivenUserIsOnAgent_RegistrationPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User navigates to Principal Details section after entering details as")]
        public void GivenUserNavigatesToPrincipalDetailsSectionAfterEnteringDetailsAs(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToPrincipalDetailsSectionAfterEnteringDetailsAs(agentRegFields);
        }

        [Then(@"Link for moving Forward is not enabled")]
        public void ThenLinkForMovingForwardIsNotEnabled()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.IsForwardLinkDisabled());
        }

        [Then(@"Question ""(.*)"" should be displayed for Principal Details")]
        public void ThenQuestionShouldBeDisplayedForPrincipalDetails(string qText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.PrincipalDetails.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Progress line indicates entry of Agency Details")]
        public void ThenProgressLineIndicatesEntryOfAgencyDetails()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Yes button should be available on Principal Details")]
        public void ThenYesButtonShouldBeAvailableOnPrincipalDetails()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.PrincipalDetails.ShouldVerifyThatYesButtonIsAvailable());
        }

        [Then(@"No button should be available on Principal Details")]
        public void ThenNoButtonShouldBeAvailableOnPrincipalDetails()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.PrincipalDetails.ShouldVerifyThatNoButtonIsAvailable());
        }

        [When(@"I select option Yes on Principal Details")]
        public void WhenISelectOptionYesOnPrincipalDetails()
        {
            BasePage.AgentRegistrationFunnel.PrincipalDetails.SelectYes();
        }

        [When(@"I select option No on Principal Details")]
        public void WhenISelectOptionNoOnPrincipalDetails()
        {
            BasePage.AgentRegistrationFunnel.PrincipalDetails.SelectNo();
        }

        [Given(@"User select option No on Principal Details")]
        public void GivenUserSelectOptionNoOnPrincipalDetails()
        {
            BasePage.AgentRegistrationFunnel.PrincipalDetails.SelectNo();
        }


        [Then(@"Fields Principal First Name, Principal Last Name, Principal Email Address should be displayed")]
        public void ThenFieldsPrincipalFirstNamePrincipalLastNamePrincipalEmailAddressShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.PrincipalDetails.ShouldVerifyThatFieldsForPrincipalDetailsAreDisplayed());
        }


        [Given(@"User select option Yes on Principal Details")]
        public void GivenUserSelectOptionYesOnPrincipalDetails()
        {
            BasePage.AgentRegistrationFunnel.PrincipalDetails.SelectYes();
        }

        [When(@"I Enter values in Principal Details as")]
        public void WhenIEnterValuesInPrincipalDetailsAs(Table table)
        {
            var principalDetailsFields = table.CreateInstance<PrincipalDetailsFields>();
            BasePage.AgentRegistrationFunnel.PrincipalDetails.EnterPrincipalDetailsAs(principalDetailsFields.PrincipalFirstName, principalDetailsFields.PrincipalLastName,
                                                                                      principalDetailsFields.PrincipalEmail);
        }

        [Then(@"Error ""(.*)"" should be displayed for empty Principal First Name field")]
        public void ThenErrorShouldBeDisplayedForEmptyPrincipalFirstNameField(string errText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.PrincipalDetails.ShouldVerifyErrorForPrincipalFirstNameField(errText));
        }

        [Then(@"Error ""(.*)"" should be displayed for empty Principal Last Name field")]
        public void ThenErrorShouldBeDisplayedForEmptyPrincipalLastNameField(string errText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.PrincipalDetails.ShouldVerifyErrorForPrincipalLastNameField(errText));
        }

        [Then(@"Error ""(.*)"" should be displayed for empty Principal Email Address field")]
        public void ThenErrorShouldBeDisplayedForEmptyPrincipalEmailAddressField(string errText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.PrincipalDetails.ShouldVerifyErrorForPrincipalEmailField(errText));
        }

        [Then(@"Key Information section is displayed")]
        public void ThenKeyInformationSectionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.KeyInfo.IsDisplayed());
        }

        [Then(@"Progress line for Principal Details is not filled by default")]
        public void ThenProgressLineForPrincipalDetailsIsNotFilledByDefault()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesEntryOfPrincipalDetails());
        }

        [Then(@"Progress line for Principal Details is displayed as filled")]
        public void ThenProgressLineForPrincipalDetailsIsDisplayedAsFilled()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesEntryOfPrincipalDetails());
        }

    }
}

