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
    public class PropertyTypeFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public PropertyTypeFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("PropertyTypeFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"I navigate to Property Type Selection after selection option")]
        public void GivenINavigateToPropertyTypeSelectionAfterSelectionOption(Table table)
        {
            var propRegFields = table.CreateInstance<PropertyRegistrationFields>();
            BasePage.PropertyRegistrationFunnel.ShouldNavigateToPropTypeSectionAfterEnteringDetailsAs(propRegFields);
        }


        [Then(@"Q ""(.*)"" should be displayed for Property Type options")]
        public void ThenQShouldBeDisplayedForPropertyTypeOptions(string questionText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheQuestionWith(questionText));
        }

        [Given(@"I am on Property Registration Page")]
        public void GivenIAmOnPropertyRegistrationFunnel()
        {
            BasePage.ShouldTakeMeToPropertyRegistrationFunnelStartSlide();
        }

        [Then(@"Link for Moving forward is displayed as enabled")]
        public void ThenLinkForMovingForwardIsDisplayedAsEnabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkDisabled());
        }

        [Then(@"Property Type House with Text ""(.*)"" should be available")]
        public void ThenPropertyTypeHouseWithTextShouldBeAvailable(string stext)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyType.ShouldVerifyPropertyTypeHouseTextWith(stext));
        }

        [Then(@"Property Type Unit with Text ""(.*)"" should be available")]
        public void ThenPropertyTypeUnitWithTextShouldBeAvailable(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyType.ShouldVerifyPropertyTypeUnitTextWith(sText));
        }

        [Then(@"Property Type Land with Text ""(.*)"" should be available")]
        public void ThenPropertyTypeLandWithTextShouldBeAvailable(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyType.ShouldVerifyPropertyTypeLandTextWith(sText));
        }

        [Then(@"Property Type Apartment with Text ""(.*)"" should be available")]
        public void ThenPropertyTypeApartmentWithTextShouldBeAvailable(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyType.ShouldVerifyPropertyTypeApartmentTextWith(sText));
        }

        [Then(@"Property Type Townhouse with Text ""(.*)"" should be available")]
        public void ThenPropertyTypeTownhouseWithTextShouldBeAvailable(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyType.ShouldVerifyPropertyTypeTownhouseTextWith(sText));
        }

        [Then(@"Property Type Villa with Text ""(.*)"" should be available")]
        public void ThenPropertyTypeVillaWithTextShouldBeAvailable(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyType.ShouldVerifyPropertyTypeVillaTextWith(sText));
        }

        [Given(@"I navigate to Property Type Selection")]
        public void GivenINavigateToPropertyTypeSelection()
        {
            BasePage.PropertyRegistrationFunnel.ListingCategory.SelectListingCategoryAs(ListingCategoryEnum.Sell.ToString());
        }

        [Then(@"Q ""(.*)"" should be displayed for Property Listing options")]
        public void ThenQShouldBeDisplayedForPropertyListingOptions(string questionText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheQuestionWith(questionText));
        }

        [When(@"I Select Property Type as ""(.*)""")]
        public void WhenISelectPropertyTypeAs(string propType)
        {
            BasePage.PropertyRegistrationFunnel.PropertyType.SelectPropertyTypeAs(propType);
        }

        [Then(@"Bedroom selection question should be displayed")]
        public void ThenBedroomSelectionQuestionShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Bedrooms.IsDisplayed());
        }

        [Then(@"Approximate Value Selection question should be displayed")]
        public void ThenApproximateValueSelectionQuestionShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.IsDisplayed());
        }

        [Then(@"Color of the House option should be ""(.*)""")]
        public void ThenColorOfTheHouseOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyType.ShouldVerifyTheColorOfHouseOptionWith(expectedColorHexValue));
        }

        [When(@"I move back to Property Type Selection from Bedrooms Selection")]
        public void WhenIMoveBackToPropertyTypeSelectionFromBedroomsSelection()
        {
            BasePage.PropertyRegistrationFunnel.Bedrooms.MoveBackToPropertyType();
        }

        [Then(@"Color of the Unit option should be ""(.*)""")]
        public void ThenColorOfTheUnitOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyType.ShouldVerifyTheColorOfUnitOptionWith(expectedColorHexValue));
        }

        [Then(@"Color of the Land option should be ""(.*)""")]
        public void ThenColorOfTheLandOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyType.ShouldVerifyTheColorOfLandOptionWith(expectedColorHexValue));
        }

        [When(@"I move back to Property Type Selection from Property Value Selection")]
        public void WhenIMoveBackToPropertyTypeSelectionFromPropertyValueSelection()
        {
            BasePage.PropertyRegistrationFunnel.PropertyValue.MoveBackToPropertyType();
        }

        [Then(@"Color of the Apartment option should be ""(.*)""")]
        public void ThenColorOfTheApartmentOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyType.ShouldVerifyTheColorOfApartmentOptionWith(expectedColorHexValue));
        }

        [Then(@"Color of the Townhouse option should be ""(.*)""")]
        public void ThenColorOfTheTownhouseOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyType.ShouldVerifyTheColorOfTownhouseOptionWith(expectedColorHexValue));
        }

        [Then(@"Color of the Villa option should be ""(.*)""")]
        public void ThenColorOfTheVillaOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyType.ShouldVerifyTheColorOfVillaOptionWith(expectedColorHexValue));
        }

        [Then(@"Property Circle in the Progress is displayed as Filled")]
        public void ThenPropertyCircleInTheProgressIsDisplayedAsFilled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatPropertyCircleIsFilledInProgressBar());
        }

        [Then(@"Progress line shows the selection of Property Type")]
        public void ThenProgressLineShowsTheSelectionOfPropertyType()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesFillingOfPropType());
        }

        [Then(@"Moving Forward Link is disabled")]
        public void ThenMovingForwardLinkIsDisabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkDisabled());
        }


        [When(@"I click on Forward Link")]
        public void WhenIClickOnForwardLink()
        {
            BasePage.PropertyRegistrationFunnel.ListingCategory.MoveForwardToPropertyType();
        }

        [Then(@"Moving Forward Link should be disabled")]
        public void ThenMovingForwardLinkShouldBeDisabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkDisabled());
        }

    }
}
