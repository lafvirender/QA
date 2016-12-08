using TechTalk.SpecFlow;
using LAFTestAutomationFramework.Pages;
using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.PropertyRegistration.PropertyRegistrationSteps
{
    [Binding]
    public class UrgencyFieldsVerificationSteps :TestInitialization
    {
        Reporter Reporter;
        public UrgencyFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("UrgencyFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"I am on Prop_Rego_Page")]
        public void GivenIAmOnProp_Rego_Page()
        {
            BasePage.ShouldTakeMeToPropertyRegistrationFunnelStartSlide();
        }

        [Given(@"I navigate to Urgency selection section after entering details")]
        public void GivenINavigateToUrgencySelectionSectionAfterEnteringDetails(Table table)
        {
            var propRegFields = table.CreateInstance<PropertyRegistrationFields>();
            BasePage.PropertyRegistrationFunnel.ShouldNavigateToUrgencySectionAfterEnteringDetailsAs(propRegFields);
        }

        [Then(@"Q ""(.*)"" should be displayed for Urgency selection")]
        public void ThenQShouldBeDisplayedForUrgencySelection(string qText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Option Immediately with text ""(.*)"" should be available")]
        public void ThenOptionImmediatelyWithTextShouldBeAvailable(string text)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Urgency.ShouldVerifyImmediatelyOptionTextWith(text));
        }

        [Then(@"Option ZeroToThreeMonths with text ""(.*)"" should be available")]
        public void ThenOptionZeroToThreeMonthsWithTextShouldBeAvailable(string text)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Urgency.ShouldVerifyZeroToThreeMonthsOptionTextWith(text));
        }

        [Then(@"Option ThreeToSixMonths with text ""(.*)"" should be available")]
        public void ThenOptionThreeToSixMonthsWithTextShouldBeAvailable(string text)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Urgency.ShouldVerifyThreeToSixMonthsOptionTextWith(text));
        }

        [Then(@"Option SixPlusMonths with text ""(.*)"" should be available")]
        public void ThenOptionSixPlusMonthsWithTextShouldBeAvailable(string text)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Urgency.ShouldVerifySixPlusMonthsOptionTextWith(text));
        }

        [Then(@"Moving Fwd Link is displayed disabled")]
        public void ThenMovingFwdLinkIsDisplayedDisabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkDisabled());
        }

        [When(@"I Select Urgency option as ""(.*)""")]
        public void WhenISelectUrgencyOptionAs(string option)
        {
            BasePage.PropertyRegistrationFunnel.Urgency.SelectUrgencyAs(option.ToString());
        }

        [Then(@"Customer Details Entry question is displayed")]
        public void ThenCustomerDetailsEntryQuestionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PersonalDetails.IsDisplayed());
        }

        [Then(@"Color of the Immediately option should be ""(.*)""")]
        public void ThenColorOfTheImmediatelyOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Urgency.ShouldVerifyTheColorOfImmediatelyOptionWith(expectedColorHexValue));
        }

        [When(@"I move back to Urgency  Question")]
        public void WhenIMoveBackToUrgencyQuestion()
        {
            BasePage.PropertyRegistrationFunnel.PersonalDetails.MoveBackToUrgencySelectionQuestion();
            BasePage.PropertyRegistrationFunnel.Urgency.IsDisplayed();
        }

        [Then(@"Color of the ZeroToThreeMonths option should be ""(.*)""")]
        public void ThenColorOfTheZeroToThreeMonthsOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Urgency.ShouldVerifyTheColorOfZeroToThreeMonthsOptionWith(expectedColorHexValue));
        }

        [Then(@"Color of the ThreeToSixMonths option should be ""(.*)""")]
        public void ThenColorOfTheThreeToSixMonthsOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Urgency.ShouldVerifyTheColorOfThreeToSixMonthsOptionWith(expectedColorHexValue));
        }

        [Then(@"Color of the SixPlusMonths option should be ""(.*)""")]
        public void ThenColorOfTheSixPlusMonthsOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Urgency.ShouldVerifyTheColorOfSixPlusMonthsOptionWith(expectedColorHexValue));
        }

        [Then(@"Link for Moving fwd is enabled")]
        public void ThenLinkForMovingFwdIsEnabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkEnabled());
        }

        [When(@"I click on Fwd")]
        public void WhenIClickOnFwd()
        {
            BasePage.PropertyRegistrationFunnel.Urgency.MoveForwardToPersonalDetailsSection();
        }

    }
}
