using TechTalk.SpecFlow;
using LAFTestAutomationFramework.Pages;
using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.PropertyRegistrationSteps
{
    [Binding]
    public class ThankYouFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public ThankYouFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("ThankYouFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"I am on Prop_Listing Page")]
        public void GivenIAmOnProp_ListingPage()
        {
            BasePage.ShouldTakeMeToPropertyRegistrationFunnelStartSlide();
        }

        [Given(@"I navigate to Thank You page after registering property with details")]
        public void GivenINavigateToThankYouPageAfterRegisteringPropertyWithDetails(Table table)
        {
            var propRegFields = table.CreateInstance<PropertyRegistrationFields>();
            BasePage.PropertyRegistrationFunnel.ShouldNavigateToPropRegThankYouSectionAfterEnteringDetailsAs(propRegFields);
        }

        [Then(@"Message ""(.*)"" should be displayed on Thank You page with correct First Name\.")]
        public void ThenMessageShouldBeDisplayedOnThankYouPageWithCorrectFirstName_(string sMsg)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ThankYou.ShouldVerifyThankYouMessageOneWith(sMsg));
        }

        [Then(@"Message for customer details to be reviewed ""(.*)"" should be displayed on Thank You page")]
        public void ThenMessageForCustomerDetailsToBeReviewedShouldBeDisplayedOnThankYouPage(string sMsg)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ThankYou.ShouldVerifyThankYouMessageTwoWith(sMsg));
        }

        [Then(@"Message for sending results to customer email ""(.*)"" should be displayed on Thank You page")]
        public void ThenMessageForSendingResultsToCustomerEmailShouldBeDisplayedOnThankYouPage(string sMsg)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ThankYou.ShouldVerifyThankYouInfoMessageWith(sMsg));
        }

        [Then(@"Message for customer to expect email ""(.*)"" should be displayed")]
        public void ThenMessageForCustomerToExpectEmailShouldBeDisplayed(string sMsg)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ThankYou.ShouldVerifyEmailAddressMsgWith(sMsg));
        }

        [Then(@"Message for time estimate ""(.*)"" should be displayed")]
        public void ThenMessageForTimeEstimateShouldBeDisplayed(string sMsg)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ThankYou.ShouldVerifyEstimateTimeMsgWith(sMsg));
        }

    }
}
