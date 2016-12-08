using System.Configuration;
using LAFTestAutomationFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.AgentRegSteps
{
    [Binding]
    public class BeforeYouStartFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public BeforeYouStartFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("BeforeYouStartFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User navigates to Agent SignUp Page")]
        public void GivenUserNavigatesToAgentSignUpPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Then(@"Heading ""(.*)"" should be displayed")]
        public void ThenHeadingShouldBeDisplayed(string headingText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.BeforeYouStart.ShouldVerifyHeadingTextWith(headingText));
        }

        [Given(@"User clicks on Next button")]
        public void GivenUserClicksOnNextButton()
        {
            BasePage.AgentRegistrationFunnel.BeforeYouStart.ShouldTakeMeToInterestSelection();
        }

        [Then(@"Interest selection section should be displayed")]
        public void ThenInterestSelectionSectionShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentInterests.IsDisplayed());
        }
    }
}
