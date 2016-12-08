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
    public class AgencyDetailsFieldsVerificationSteps :TestInitialization
    {
        Reporter Reporter;
        public AgencyDetailsFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("AgencyDetailsFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }


        [Given(@"User is on Agent Registration Page")]
        public void GivenUserIsOnAgentRegistrationPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User navigates to About Your Agency section after entering details as")]
        public void GivenUserNavigatesToAboutYourAgencySectionAfterEnteringDetailsAs(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToAgencyDetailsSectionAfterEnteringDetailsAs(agentRegFields);
        }

        [Then(@"Question ""(.*)"" should be displayed for About your Agency section")]
        public void ThenQuestionShouldBeDisplayedForAboutYourAgencySection(string qText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Progress line indicates entry of Agent Basic Details")]
        public void ThenProgressLineIndicatesEntryOfAgentBasicDetails()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesEntryOfAgentBasicDetails());
        }


        [Then(@"Option for entering the address manually with text ""(.*)"" is displayed")]
        public void ThenOptionForEnteringTheAddressManuallyWithTextIsDisplayed(string sText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyManualAddressOptionTextWith(sText));
        }

        [Then(@"Search field is available for searching the address")]
        public void ThenSearchFieldIsAvailableForSearchingTheAddress()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyThatAddressSearchfieldisAvailable());
        }

        [Then(@"Next button is available on Agency Details section")]
        public void ThenNextButtonIsAvailableOnAgencyDetailsSection()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyThatNextButtonisAvailable());
        }

        [Then(@"Link for Moving Forward is Disabled")]
        public void ThenLinkForMovingForwardIsDisabled()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.IsForwardLinkDisabled());
        }

        [When(@"I select option Enter your address manually")]
        public void WhenISelectOptionEnterYourAddressManually()
        {
            BasePage.AgentRegistrationFunnel.AgencyDetails.SelectManualAddress();
        }

        [Then(@"Fields Unit/App No\., StreetNo\., Street, Suburb, State and PostCode are displayed")]
        public void ThenFieldsUnitAppNo_StreetNo_StreetSuburbStateAndPostCodeAreDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyThatAddressFieldsForManualAddressEntryAreDisplayed());
        }

        [When(@"I Click on Next button")]
        public void WhenIClickOnNextButton()
        {
            BasePage.AgentRegistrationFunnel.AgencyDetails.ClickNext();
        }

        [Then(@"Error should be displayed for empty Address Search field")]
        public void ThenErrorShouldBeDisplayedForEmptyAddressSearchField()
        {
            ScenarioContext.Current.Pending();
            //Assert.IsTrue(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyErrorForAddressSearchField());
        }

        [When(@"I Enter values in Agency Details as")]
        public void WhenIEnterValuesInAgencyDetailsAs(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.AgencyDetails.EnterAgencyDetailsAs(agentRegFields.AgencyUnitAppNo, agentRegFields.AgencyStreetNo,
                                                                          agentRegFields.AgencyStreet, agentRegFields.AgencySuburb,
                                                                          agentRegFields.AgencyState, agentRegFields.AgencyPostCode,
                                                                          agentRegFields.AgencyName, agentRegFields.AgencyBranch);
        }

        [Then(@"Error should be displayed for empty  Street No field")]
        public void ThenErrorShouldBeDisplayedForEmptyStreetNoField()
        {
            //Assert.IsTrue(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyErrorForStreetNoField());
            ScenarioContext.Current.Pending();
        }


        [Then(@"Error ""(.*)"" should be displayed for empty  Street field")]
        public void ThenErrorShouldBeDisplayedForEmptyStreetField(string errText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyErrorForStreetField(errText));
        }


        [Then(@"Error ""(.*)"" should be displayed for empty  Suburb field")]
        public void ThenErrorShouldBeDisplayedForEmptySuburbField(string errText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyErrorForSuburbField(errText));
        }


        [Then(@"Error should be displayed for empty  State field")]
        public void ThenErrorShouldBeDisplayedForEmptyStateField()
        {
            //Assert.IsTrue(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyErrorForStateField());
            ScenarioContext.Current.Pending();
        }

        [Then(@"Error ""(.*)"" should be displayed for empty  Postcode field")]
        public void ThenErrorShouldBeDisplayedForEmptyPostcodeField(string errText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyErrorForPostCodeField(errText));
        }

        [Then(@"Error ""(.*)"" should be displayed for empty  Agency Name field")]
        public void ThenErrorShouldBeDisplayedForEmptyAgencyNameField(string errText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyErrorForAgencyNameField(errText));
        }

        [Then(@"Error ""(.*)"" should be displayed for empty  Branch field")]
        public void ThenErrorShouldBeDisplayedForEmptyBranchField(string errText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyErrorForBranchField(errText));
        }

        [Then(@"Principal Details section is displayed")]
        public void ThenPrincipalDetailsSectionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.PrincipalDetails.IsDisplayed());
        }

        [Then(@"Progress circle for Agency is displayed as not filled by default")]
        public void ThenProgressCircleForAgencyIsDisplayedAsNotFilledByDefault()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyThatAgencyCircleIsFilledInProgressBar());
        }

        [Then(@"Progress circle for Agency is displayed as filled")]
        public void ThenProgressCircleForAgencyIsDisplayedAsFilled()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyThatAgencyCircleIsFilledInProgressBar());
        }

        [Then(@"Error ""(.*)"" should be displayed for Street No field")]
        public void ThenErrorShouldBeDisplayedForStreetNoField(string errText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyErrorForStreetNoField(errText));
        }

        [Then(@"Error ""(.*)"" should be displayed for State field")]
        public void ThenErrorShouldBeDisplayedForStateField(string errText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyErrorForStateField(errText));
        }

        [Then(@"Error ""(.*)"" should be displayed for Suburb field")]
        public void ThenErrorShouldBeDisplayedForSuburbField(string errText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyErrorForSuburbField(errText));
        }

        [Then(@"Error ""(.*)"" should be displayed for Agency Name field")]
        public void ThenErrorShouldBeDisplayedForAgencyNameField(string errText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgencyDetails.ShouldVerifyErrorForAgencyNameField(errText));
        }

    }
}
