using System.Collections.Generic;
using TechTalk.SpecFlow;
using LAFTestAutomationFramework.Pages;
using System.Configuration;
using LAFTestAutomationFramework.Helpers;
using NUnit.Framework;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.PropertyRegistrationSteps
{
   [Binding]
    public class PropertyListingFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;

        public PropertyListingFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("PropertyListingFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User is on Property Registration Page")]
        public void GivenUserIsOnPropertyRegistrationPage()
        {
            BasePage.ShouldTakeMeToPropertyRegistrationFunnelStartSlide();
        }

        [Then(@"Question ""(.*)"" should be displayed for Property Listing options")]
        public void ThenQuestionShouldBeDisplayedForPropertyListingOptions(string questionText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheQuestionWith(questionText));
        }

        [Then(@"Listing category Sell with Text ""(.*)"" should be available")]
        public void ThenListingCategorySellWithTextShouldBeAvailable(string listingCategoryText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ListingCategory.ShouldVerifyListingCategorySellTextWith(listingCategoryText));
        }

        [Then(@"Listing category Rent with Text ""(.*)"" should be available")]
        public void ThenListingCategoryRentWithTextShouldBeAvailable(string listingCategoryText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ListingCategory.ShouldVerifyListingCategoryRentTextWith(listingCategoryText));
        }

        [When(@"I Select Sell category")]
        public void WhenISelectSellCategory()
        {
            BasePage.PropertyRegistrationFunnel.ListingCategory.SelectSell();
        }

        [When(@"I Select Rent category")]
        public void WhenISelectRentCategory()
        {
            BasePage.PropertyRegistrationFunnel.ListingCategory.SelectRent();
        }

        [Then(@"Property Type selection question should be displayed\.")]
        public void ThenPropertyTypeSelectionQuestionShouldBeDisplayed_()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyType.IsDisplayed());
        }


        [Given(@"I navigate to Approximate Value selection question for Renting property")]
        public void GivenINavigateToApproximateValueSelectionQuestionForRentingProperty()
        {
            BasePage.PropertyRegistrationFunnel.NavigateToApproxValueSelectionForRent();
        }


        [Then(@"Below options should be available under Approximate Values")]
        public void ThenBelowOptionsShouldBeAvailableUnderApproximateValues(Table table)
        {
            IList<string> values = new List<string>();
            foreach (var row in table.Rows)
            {
                values.Add((row[0].ToString()));
            }
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldDisplayTheValuesForRentAs(values));           
        }

        [Given(@"I navigate to Approximate Value selection question for Selling property")]
        public void GivenINavigateToApproximateValueSelectionQuestionForSellingProperty()
        {
            BasePage.PropertyRegistrationFunnel.NavigateToApproxValueSelectionForSell();
        }

        [Then(@"Below options should be available under Approximate Values\.")]
        public void ThenBelowOptionsShouldBeAvailableUnderApproximateValues_(Table table)
        {
            IList<string> values = new List<string>();
            foreach (var row in table.Rows)
            {
                values.Add((row[0].ToString()));
            }
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldDisplayTheValuesForSellAs(values));
        }

        [Given(@"I Select Sell category")]
        public void GivenISelectSellCategory()
        {
            BasePage.PropertyRegistrationFunnel.ListingCategory.SelectListingCategoryAs("Sell");
        }

        [Given(@"I move back to Property Listing question")]
        public void GivenIMoveBackToPropertyListingQuestion()
        {
            BasePage.PropertyRegistrationFunnel.PropertyType.MoveBackToPropertyListing();
            BasePage.PropertyRegistrationFunnel.ListingCategory.IsDisplayed();
        }

        [Then(@"Color of the Sell option should be ""(.*)""")]
        public void ThenColorOfTheSellOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ListingCategory.ShouldVerifyTheColorOfSellOptionWith(expectedColorHexValue));
        }


        [Then(@"Color of the Rent option should be ""(.*)""")]
        public void ThenColorOfTheRentOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ListingCategory.ShouldVerifyTheColorOfRentOptionWith(expectedColorHexValue));
        }

        [Given(@"I Select Rent category")]
        public void GivenISelectRentCategory()
        {
            BasePage.PropertyRegistrationFunnel.ListingCategory.SelectListingCategoryAs("Rent");
            BasePage.PropertyRegistrationFunnel.PropertyType.IsDisplayed();
        }

        [Then(@"Links for Moving Back and Forward should be disabled")]
        public void ThenLinksForMovingBackAndForwardShouldBeDisabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyBothTheLinksForMovingBackForwardAreDisabled());
        }

        [Then(@"Property Details Progress should be displayed as activated")]
        public void ThenPropertyDetailsProgressShouldBeDisplayedAsActivated()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatPropertyIsActiveInProgressBar());
        }

        [Then(@"Label ""(.*)"" should be displayed for Property Details progress\.")]
        public void ThenLabelShouldBeDisplayedForPropertyDetailsProgress_(string label)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheLabelOfPropertyDetailsTrackingInProgressBarWith(label));
        }

        [Then(@"No progress should be displayed for Agent details by default\.")]
        public void ThenNoProgressShouldBeDisplayedForAgentDetailsByDefault_()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatAgentIsNotActiveInProgressBar());
        }

        [Then(@"Label ""(.*)"" should be displayed for Agent Details progress\.")]
        public void ThenLabelShouldBeDisplayedForAgentDetailsProgress_(string label)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheLabelOfAgentDetailsTrackingInProgressBarWith(label));
        }

        [Then(@"No progress should be displayed for Your details by default")]
        public void ThenNoProgressShouldBeDisplayedForYourDetailsByDefault()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatYouIsNotActiveInProgressBar());
        }

        [Then(@"Label ""(.*)"" should be displayed for Your Details progress\.")]
        public void ThenLabelShouldBeDisplayedForYourDetailsProgress_(string label)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheLabelOfYourDetailsTrackingInProgressBarWith(label));
        }

        [Then(@"Property Details Progress Circle should be displayed as not filled")]
        public void ThenPropertyDetailsProgressCircleShouldBeDisplayedAsNotFilled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatPropertyCircleIsNotFilledInProgressBar());
        }

        [When(@"I move back to Property Listing question")]
        public void WhenIMoveBackToPropertyListingQuestion()
        {
            BasePage.PropertyRegistrationFunnel.PropertyType.MoveBackToPropertyListing();
        }

        [Then(@"Link for navigating forward is enabled")]
        public void ThenLinkForNavigatingForwardIsEnabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkEnabled());
        }

        [When(@"Click on Forward")]
        public void WhenClickOnForward()
        {
            BasePage.PropertyRegistrationFunnel.ListingCategory.MoveForwardToPropertyType();
        }


    }
}
