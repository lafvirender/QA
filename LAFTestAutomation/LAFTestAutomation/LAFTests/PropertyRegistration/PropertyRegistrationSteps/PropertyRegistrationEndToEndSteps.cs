using TechTalk.SpecFlow;
using LAFTestAutomationFramework.Pages;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using System.Configuration;
using NUnit.Framework;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.PropertyRegistrationSteps
{
    [Binding]
    public class PropertyRegistrationEndToEndSteps: TestInitialization
    {
        Reporter Reporter;
        public PropertyRegistrationEndToEndSteps(BasePage basePage):
            base(basePage, ConfigurationManager.AppSettings.Get("PropertyRegistrationEndToEndSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User is on LAF Home Page")]
        public void GivenUserIsOnLAFHomePage()
        {
            BasePage.ShouldTakeMeToLAFHomePage();  
        }
        
        [Given(@"User Navigates to Property Registration Page")]
        public void GivenUserNavigatesToPropertyRegistrationPage()
        {
            BasePage.ShouldTakeMeToPropertyRegistrationFunnelStartSlide();
        }

        [When(@"User Enters the Details As '(.*)'  '(.*)'  '(.*)'  '(.*)'  '(.*)'  '(.*)'  '(.*)'  '(.*)'  '(.*)'  '(.*)'  '(.*)'  '(.*)'  '(.*)'  '(.*)'  '(.*)'  '(.*)'")]
        public void WhenUserEntersTheDetailsAs(string listingCategory, string propertyType, string bedrooms,
                                               string approxValue, string addressString, string leased, string leasingDetails, string agentQuality,
                                               string specificAgency, string specificAgenciesDetails,
                                               string contactedAgency, string contactedAgenciesDetails, string urgency, string customerDetailsString,
                                               string customerDirectConnectAnswer, string directConnectDetails)
        {
            AddressFields address = new AddressFields(addressString);
            var customerDetails = customerDetailsString.Split(',');

            BasePage.PropertyRegistrationFunnel.ShouldRegisterThePropertyWithDetails(listingCategory, propertyType,
                                                                                    bedrooms, approxValue,
                                                                                    address.UnitAppNo, address.StreetNo,
                                                                                    address.Street, address.Suburb,
                                                                                    address.State, address.PostCode,
                                                                                    leased, leasingDetails, agentQuality,
                                                                                    specificAgency, specificAgenciesDetails,
                                                                                    contactedAgency, contactedAgenciesDetails, urgency,
                                                                                    customerDetails[0], customerDetails[1],
                                                                                    customerDetails[2], customerDetails[3],
                                                                                    customerDirectConnectAnswer, directConnectDetails);
        }


        [Then(@"Property should be registered successfully")]
        public void ThenPropertyShouldBeRegisteredSuccessfully()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ThankYou.IsDisplayed());
        }

    }
}
