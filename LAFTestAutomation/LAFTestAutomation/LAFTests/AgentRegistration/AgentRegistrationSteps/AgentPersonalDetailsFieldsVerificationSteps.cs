using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.AgentRegSteps
{
    [Binding]
    public class AgentPersonalDetailsFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public AgentPersonalDetailsFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("AgentPersonalDetailsFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User is on Agent_SignUp Page")]
        public void GivenUserIsOnAgent_SignUpPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User navigates to About You section after selecting")]
        public void GivenUserNavigatesToAboutYouSectionAfterSelecting(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToAgentPersonalDetailsSectionAfterEnteringDetailsAs(agentRegFields);
        }

        [Then(@"Link for moving forward is not enabled")]
        public void ThenLinkForMovingForwardIsNotEnabled()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.IsForwardLinkDisabled());
        }

        [Then(@"Question ""(.*)"" should be displayed for About you section")]
        public void ThenQuestionShouldBeDisplayedForAboutYouSection(string qText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentDetails.ShouldVerifyTheQuestionWith(qText));
        }


        [When(@"I click Next after entering details as")]
        public void WhenIClickNextAfterEnteringDetailsAs(Table table)
        {
            var agentDetails = table.CreateInstance<AgentPersonalDetails>();
            BasePage.AgentRegistrationFunnel.AgentDetails.EnterAgentDetailsAs(agentDetails.AgentFirstName, agentDetails.AgentLastName,
                                                                      agentDetails.AgentPhone, agentDetails.AgentMobile, 
                                                                      agentDetails.AgentEmail, agentDetails.AgentPosition);
        }

        [Then(@"Error ""(.*)"" should be displayed for empty First Name field")]
        public void ThenErrorShouldBeDisplayedForEmptyFirstNameField(string errString)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentDetails.ShouldVerifyErrorForAgentFirstNameField(errString));
        }


        [Then(@"Error  ""(.*)"" should be displayed for empty Last Name field")]
        public void ThenErrorShouldBeDisplayedForEmptyLastNameField(string errString)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentDetails.ShouldVerifyErrorForAgentLastNameField(errString));
        }

        [Then(@"Error ""(.*)"" should be displayed for empty Phone Number field")]
        public void ThenErrorShouldBeDisplayedForEmptyPhoneNumberField(string errString)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentDetails.ShouldVerifyErrorAndMsgForAgentPhoneField(errString));
        }

        [Then(@"Error ""(.*)"" should be displayed for empty Mobile Number field")]
        public void ThenErrorShouldBeDisplayedForEmptyMobileNumberField(string errString)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentDetails.ShouldVerifyErrorAndMsgForAgentMobileField(errString));
        }

        [Then(@"Error should be displayed for Phone Number field")]
        public void ThenErrorShouldBeDisplayedForPhoneNumberField()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentDetails.ShouldVerifyErrorForAgentPhoneField());
        }

        [Then(@"Error should be displayed for Mobile Number field")]
        public void ThenErrorShouldBeDisplayedForMobileNumberField()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentDetails.ShouldVerifyErrorForAgentMobileField());
        }


        [Then(@"Error ""(.*)"" should be displayed for empty Email Address field")]
        public void ThenErrorShouldBeDisplayedForEmptyEmailAddressField(string errString)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentDetails.ShouldVerifyErrorForAgentEmailField(errString));
        }

        [Then(@"Error ""(.*)"" should be displayed for empty Position field")]
        public void ThenErrorShouldBeDisplayedForEmptyPositionField(string errString)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentDetails.ShouldVerifyErrorForAgentPositionField(errString));
        }

        [Then(@"Agency Details section is displayed")]
        public void ThenAgencyDetailsSectionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.IsDisplayed());
        }

        [Then(@"Error ""(.*)"" should be displayed for invalid Email Address")]
        public void ThenErrorShouldBeDisplayedForInvalidEmailAddress(string errString)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentDetails.ShouldVerifyErrorForAgentEmailField(errString));
        }

        [Then(@"Agency Circle under Progress bar should be displayed as activated")]
        public void ThenAgencyCircleUnderProgressBarShouldBeDisplayedAsActivated()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyThatAgencyIsActiveInProgressBar());
        }

        [Then(@"Below options should be available under Choose Job Title drop down")]
        public void ThenBelowOptionsShouldBeAvailableUnderChooseJobTitleDropDown(Table table)
        {
            IList<string> values = new List<string>();
            foreach (var row in table.Rows)
            {
                values.Add((row[0].ToString()));
            }
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentDetails.ShouldDisplayTheJobTitleValuesAs(values));
        }

        [Then(@"Progress line for Agent Details is not filled by default")]
        public void ThenProgressLineForAgentDetailsIsNotFilledByDefault()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesEntryOfAgentBasicDetails());
        }

        [Then(@"Progress Line for Agent Details is displayed as filled and About You circle  is displayed as checked")]
        public void ThenProgressLineForAgentDetailsIsDisplayedAsFilledAndAboutYouCircleIsDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ProgressLineForAgentDetailsIsFilledAndAboutYouCircleIsChecked());
        }


    }
}
