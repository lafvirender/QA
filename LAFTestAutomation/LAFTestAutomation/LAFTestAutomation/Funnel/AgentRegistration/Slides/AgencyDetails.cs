using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentRegistration.Slides
{
    public class AgencyDetails : AddressVerification
    {
        private readonly TestObject _agencyDetailsSlide;
        private readonly TestObject _agencyName;
        private readonly TestObject _branch;
        private readonly TestObject _addressSearch;
        private readonly TestObject _next;
        private readonly TestObject _agencyDetailsHeading;
        private readonly TestObject _enterManualAddress;
        private readonly TestObject _errors;

        public AgencyDetails(Browser browser, TestObjectProperties eltAgencyDetailsSlide,
                              TestObjectProperties lnkManualAddress,
                              TestObjectProperties txtApartmentNo, TestObjectProperties txtStreetNo,
                              TestObjectProperties txtStreet, TestObjectProperties txtSuburb,
                              TestObjectProperties txtState, TestObjectProperties txtPostcode,
                              TestObjectProperties lnkNext, TestObjectProperties lnkBack,
                              TestObjectProperties txtAddressSearch, TestObjectProperties eltMatchingAddListItem,
                              TestObjectProperties txtAgencyName, TestObjectProperties txtBranchName,
                              TestObjectProperties eltAgencyDetailsHeading, TestObjectProperties LnkEnterManualAddress,
                              TestObjectProperties eltErrors)
                               : base(browser, lnkManualAddress, txtApartmentNo, txtStreetNo, txtStreet, txtSuburb,
                                   txtState, txtPostcode, txtAddressSearch, eltMatchingAddListItem)
        {

            _agencyDetailsSlide = new TestObject(browser, eltAgencyDetailsSlide);
            _agencyName = new TestObject(browser, txtAgencyName);
            _branch = new TestObject(browser, txtBranchName);
            _addressSearch = new TestObject(browser, txtAddressSearch);
            _next = new TestObject(browser, lnkNext);
            _agencyDetailsHeading = new TestObject(browser, eltAgencyDetailsHeading);
            _enterManualAddress = new TestObject(browser, LnkEnterManualAddress);
            _errors = new TestObject(browser, eltErrors);
        }

        public VerificationInfo ShouldVerifyThatAddressFieldsForManualAddressEntryAreDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if ( ShouldVerifyThatApartmentNumberfieldisAvailable().Result &&
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

        public VerificationInfo ShouldVerifyErrorForStreetNoField(string errText)
        {
            VerificationInfo info = new VerificationInfo();
            if (streetNo.VerifyFieldError().Result
                && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errText))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyErrorForStateField(string errText)
        {
            VerificationInfo info = new VerificationInfo();
            if (state.VerifyFieldError().Result
                && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errText))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyErrorForStreetField(string errText)
        {
            VerificationInfo info = new VerificationInfo();
            if (street.VerifyFieldError().Result
                && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errText))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyErrorForSuburbField(string errText)
        {
            VerificationInfo info = new VerificationInfo();
            if (suburb.VerifyFieldError().Result
                 && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errText))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyErrorForPostCodeField(string errString)
        {
            VerificationInfo info = new VerificationInfo();
            if (postcode.VerifyFieldError().Result
            && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errString))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public new VerificationInfo ShouldVerifyManualAddressOptionTextWith(string sText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sText;
            info.Actual = _enterManualAddress.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheQuestionWith(string questionString)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = questionString;
            info.Actual = GetQuestionText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        private string GetQuestionText()
        {
            return _agencyDetailsHeading.GetText();
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
        }

        public void EnterAgencyNameAndBranchAs(string agencyName, string branch)
        {
            SetValueInAgencyNameAs(agencyName);
            SetValueInBranchAs(branch);
        }

        public void EnterAgencyDetailsAs(string unitNo, string streetNo,
                                           string street, string suburb,
                                           string state, string postCode,
                                           string agencyName, string branchName)
        {
            EnterAddressManuallyAs(unitNo, streetNo,
                                   street, suburb,
                                   state, postCode);
            EnterAgencyNameAndBranchAs(agencyName, branchName);
            ClickNext();
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

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_agencyDetailsSlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyErrorForAgencyNameField(string errText)
        {
            VerificationInfo info = new VerificationInfo();
            if (_agencyName.VerifyFieldError().Result
             && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errText))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyErrorForBranchField(string errText)
        {
            VerificationInfo info = new VerificationInfo();
            if (_branch.VerifyFieldError().Result
                && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errText))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        private void SetValueInAgencyNameAs(string agencyName)
        {
            if (!string.IsNullOrEmpty(agencyName))
                _agencyName.SendKeys(agencyName);
        }

        private void SetValueInBranchAs(string branch)
        {
            if (!string.IsNullOrEmpty(branch))
                _branch.SendKeys(branch);
        }
    }
}
