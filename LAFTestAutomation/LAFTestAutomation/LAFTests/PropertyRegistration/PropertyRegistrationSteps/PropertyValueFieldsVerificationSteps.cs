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
    public class PropertyValueFieldsVerificationSteps: TestInitialization
    {
        Reporter Reporter;
        public PropertyValueFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("PropertyValueFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"I am on Property_Registration Page")]
        public void GivenIAmOnProperty_RegistrationPage()
        {
            BasePage.ShouldTakeMeToPropertyRegistrationFunnelStartSlide();
        }

        [Given(@"I navigate to Property Value Section after entering details")]
        public void GivenINavigateToPropertyValueSectionAfterEnteringDetails(Table table)
        {
            var propRegFields = table.CreateInstance<PropertyRegistrationFields>();
            BasePage.PropertyRegistrationFunnel.ShouldNavigateToPropValueSectionAfterEnteringDetailsAs(propRegFields);
        }


        [Then(@"Progress line shows the selection of Bedrooms")]
        public void ThenProgressLineShowsTheSelectionOfBedrooms()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesFillingOfBedrooms());
        }

        [Then(@"Moving Forward Link is displayed as disabled")]
        public void ThenMovingForwardLinkIsDisplayedAsDisabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkDisabled());
        }

        [Then(@"Progress line shows the selection of Property Value")]
        public void ThenProgressLineShowsTheSelectionOfPropertyValue()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesFillingOfPropValue());
        }


        [Then(@"Link for Moving Forward should be disabled")]
        public void ThenLinkForMovingForwardShouldBeDisabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkDisabled());
        }

        [Then(@"Moving forward Link is displayed as enabled")]
        public void ThenMovingForwardLinkIsDisplayedAsEnabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkEnabled());
        }


        [When(@"Click on Forward Link")]
        public void WhenClickOnForwardLink()
        {
            BasePage.PropertyRegistrationFunnel.ListingCategory.MoveForwardToPropertyType();
        }

        [Then(@"Q ""(.*)"" should be displayed for Property Value selection options")]
        public void ThenQShouldBeDisplayedForPropertyValueSelectionOptions(string qText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheQuestionWith(qText));
        }

        [When(@"I Select value as ""(.*)""")]
        public void WhenISelectValueAs(string propValue)
        {
            BasePage.PropertyRegistrationFunnel.PropertyValue.SelectApproxValueAs(propValue);
        }

        [Then(@"Address question should be displayed")]
        public void ThenAddressQuestionShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.IsDisplayed());
        }

        [When(@"I move back to Property Value Selection from Address")]
        public void WhenIMoveBackToPropertyValueSelectionFromAddress()
        {
            BasePage.PropertyRegistrationFunnel.PropertyAddress.MoveBackToPropertyValueSelection();
        }

        [Then(@"Progress line indicates selection of Property Value")]
        public void ThenProgressLineIndicatesSelectionOfPropertyValue()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesFillingOfPropValue());
        }

        [Then(@"Color of the Less Than TwoHundered K value option should be ""(.*)""")]
        public void ThenColorOfTheLessThanTwoHunderedKValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOfLessThan200KValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the TwoHunderedK To FourHunderedK value option should be ""(.*)""")]
        public void ThenColorOfTheTwoHunderedKToFourHunderedKValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf200KTo400KValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the FourHunderedK To SixHunderedK value option should be ""(.*)""")]
        public void ThenColorOfTheFourHunderedKToSixHunderedKValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf400KTo600KValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the SixHunderedK To EightHunderedK value option should be ""(.*)""")]
        public void ThenColorOfTheSixHunderedKToEightHunderedKValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf600KTo800KValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the EightHunderedK To OneMillion value option should be ""(.*)""")]
        public void ThenColorOfTheEightHunderedKToOneMillionValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf800KTo1MValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the OneMillion To OneAndHalfMillion value option should be ""(.*)""")]
        public void ThenColorOfTheOneMillionToOneAndHalfMillionValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf1MTo1_5MValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the OneAndHalfMillion To TwoMillion value option should be ""(.*)""")]
        public void ThenColorOfTheOneAndHalfMillionToTwoMillionValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf1_5MTo2MValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the MoreThanTwoMillion value option should be ""(.*)""")]
        public void ThenColorOfTheMoreThanTwoMillionValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf2MPlusValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the Less Than TwoHundered value option should be ""(.*)""")]
        public void ThenColorOfTheLessThanTwoHunderedValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOfLessThan200ValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the TwoHundered To ThreeHundered value option should be ""(.*)""")]
        public void ThenColorOfTheTwoHunderedToThreeHunderedValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf200To300ValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the ThreeHundered To FourHundered value option should be ""(.*)""")]
        public void ThenColorOfTheThreeHunderedToFourHunderedValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf300To400ValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the FourHundered To FiveHundered value option should be ""(.*)""")]
        public void ThenColorOfTheFourHunderedToFiveHunderedValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf400To500ValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the FiveHundered To SevenHundered value option should be ""(.*)""")]
        public void ThenColorOfTheFiveHunderedToSevenHunderedValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf500To700ValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the SevenHundered To OneThousandvalue option should be ""(.*)""")]
        public void ThenColorOfTheSevenHunderedToOneThousandvalueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf700To1000ValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the OneThousand To FifteenHundered value option should be ""(.*)""")]
        public void ThenColorOfTheOneThousandToFifteenHunderedValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf1000To1500ValueWith(expectedColorHexValue));
        }

        [Then(@"Color of the MoreThanFifteenHundered value option should be ""(.*)""")]
        public void ThenColorOfTheMoreThanFifteenHunderedValueOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyValue.ShouldVerifyTheColorOf1500PlusValueWith(expectedColorHexValue));
        }


    }
}
