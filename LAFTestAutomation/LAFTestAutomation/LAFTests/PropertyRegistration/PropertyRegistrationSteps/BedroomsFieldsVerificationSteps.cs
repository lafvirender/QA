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
    public class BedroomsFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public BedroomsFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("BedroomsFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"I am on Property Reg Page")]
        public void GivenIAmOnPropertyRegPage()
        {
            BasePage.ShouldTakeMeToPropertyRegistrationFunnelStartSlide();
        }

        [Given(@"I navigate to Bedroom selection after entering details")]
        public void GivenINavigateToBedroomSelectionAfterEnteringDetails(Table table)
        {
            var propRegFields = table.CreateInstance<PropertyRegistrationFields>();
            BasePage.PropertyRegistrationFunnel.ShouldNavigateToBedroomSelectionAfterEnteringDetailsAs(propRegFields);
        }


        [Then(@"Q ""(.*)"" should be displayed for Bedrooms selection options")]
        public void ThenQShouldBeDisplayedForBedroomsSelectionOptions(string qText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Option for selection of one Bedrooms with text ""(.*)"" should be displayed")]
        public void ThenOptionForSelectionOfOneBedroomsWithTextShouldBeDisplayed(string bedroomCount)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Bedrooms.ShouldVerifyOneBedroomTextWith(bedroomCount));
        }

        [Then(@"Option for selection of two Bedrooms with text ""(.*)"" should be displayed")]
        public void ThenOptionForSelectionOfTwoBedroomsWithTextShouldBeDisplayed(string bedroomCount)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Bedrooms.ShouldVerifyTwoBedroomTextWith(bedroomCount));
        }

        [Then(@"Option for selection of three Bedrooms with text ""(.*)"" should be displayed")]
        public void ThenOptionForSelectionOfThreeBedroomsWithTextShouldBeDisplayed(string bedroomCount)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Bedrooms.ShouldVerifyThreeBedroomTextWith(bedroomCount));
        }

        [Then(@"Option for selection of four plus Bedrooms with text ""(.*)"" should be displayed")]
        public void ThenOptionForSelectionOfFourPlusBedroomsWithTextShouldBeDisplayed(string bedroomCount)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Bedrooms.ShouldVerifyFourPlusBedroomTextWith(bedroomCount));
        }


        [When(@"I Select Bedroom as ""(.*)""")]
        public void WhenISelectBedroomAs(string bedrooms)
        {
            BasePage.PropertyRegistrationFunnel.Bedrooms.SelectBedroomAs(bedrooms.ToString());
        }

        [Then(@"Color of the one bedroom option should be ""(.*)""")]
        public void ThenColorOfTheOneBedroomOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Bedrooms.ShouldVerifyTheColorOfOneBedroomOptionWith(expectedColorHexValue));
        }

        [When(@"I move back to Bedrooms Selection from Property Value Selection")]
        public void WhenIMoveBackToBedroomsSelectionFromPropertyValueSelection()
        {
            BasePage.PropertyRegistrationFunnel.PropertyValue.MoveBackToBedroomsSelection();
        }

        [Then(@"Color of the two bedroom option should be ""(.*)""")]
        public void ThenColorOfTheTwoBedroomOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Bedrooms.ShouldVerifyTheColorOfTwoBedroomOptionWith(expectedColorHexValue));
        }

        [Then(@"Color of the three bedroom option should be ""(.*)""")]
        public void ThenColorOfTheThreeBedroomOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Bedrooms.ShouldVerifyTheColorOfThreeBedroomOptionWith(expectedColorHexValue));
        }

        [Then(@"Color of the four plus bedroom option should be ""(.*)""")]
        public void ThenColorOfTheFourPlusBedroomOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Bedrooms.ShouldVerifyTheColorOfFourBedroomOptionWith(expectedColorHexValue));
        }

        [Then(@"Progress line indicates selection of Bedrooms")]
        public void ThenProgressLineIndicatesSelectionOfBedrooms()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesFillingOfBedrooms());
        }

        [Then(@"Progress line indicates selection of Property Type")]
        public void ThenProgressLineIndicatesSelectionOfPropertyType()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesFillingOfPropType());
        }

        [Then(@"Icon Link for Moving forward is displayed as Disabled")]
        public void ThenIconLinkForMovingForwardIsDisplayedAsDisabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkDisabled());
        }

        [Then(@"Question for selecting Approximate Value should be displayed")]
        public void ThenQuestionForSelectingApproximateValueShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.IsDisplayed());
        }

        [Then(@"Icon Link for Moving forward is displayed as enabled")]
        public void ThenIconLinkForMovingForwardIsDisplayedAsEnabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkEnabled());
        }

        [When(@"Click to Move Forward")]
        public void WhenClickToMoveForward()
        {
            BasePage.PropertyRegistrationFunnel.ListingCategory.MoveForwardToPropertyType();
        }


    }
}
