using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration.Slides
{
    public class PropertyAddress : AddressVerification
    {
        private readonly TestObject _eltAddressSlide;
        private readonly TestObject _next;
        private readonly TestObject _back;

        public PropertyAddress(Browser browser, TestObjectProperties eltAddressSlide,
                               TestObjectProperties lnkManualAddress, TestObjectProperties txtApartmentNo, 
                               TestObjectProperties txtStreetNo, TestObjectProperties txtStreet, 
                               TestObjectProperties txtSuburb, TestObjectProperties txtState, 
                               TestObjectProperties txtPostcode, TestObjectProperties lnkNext,
                               TestObjectProperties lnkBack, TestObjectProperties txtAddressSearch, 
                               TestObjectProperties eltMatchingAddListItem)
                                : base(browser, lnkManualAddress, 
                                      txtApartmentNo, txtStreetNo, 
                                      txtStreet, txtSuburb,
                                      txtState, txtPostcode, 
                                      txtAddressSearch, eltMatchingAddListItem)
        {
            _back = new TestObject(browser, lnkBack);
            _next = new TestObject(browser, lnkNext);
            _eltAddressSlide = new TestObject(browser, eltAddressSlide);
        }

        public void ClickNext()
        {
            _next.Click();
        }

        public void EnterAddressManuallyAs(string unitNo, string streetNo,
            string street, string suburb,
            string state, string postCode)
        {
            SelectManualAddress();
            SetValueInApartmentNoAs(unitNo);
            SetValueInStreetNoAs(streetNo);
            SetValueInStreetAs(street);
            SetValueInSuburbAs(suburb);
            SetValueInStateAs(state);
            SetValueInPostCodeAs(postCode);
            ClickNext();
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltAddressSlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltAddressSlide.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyThatAddressFieldsForManualAddressEntryAreDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (ShouldVerifyThatApartmentNumberfieldisAvailable().Result &&
                   ShouldVerifyThatStreetNumberfieldisAvailable().Result &&
                   ShouldVerifyThatStreetfieldisAvailable().Result &&
                   ShouldVerifyThatStatefieldisAvailable().Result &&
                   ShouldVerifyThatSuburbfieldisAvailable().Result &&
                   ShouldVerifyThatPostcodefieldisAvailable().Result)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatNextButtonisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (_next.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void MoveBackToPropertyValueSelection()
        {
            _back.Click();
        }

        public void MoveBackToAddressSelection()
        {
            _back.Click();
        }
}
}
