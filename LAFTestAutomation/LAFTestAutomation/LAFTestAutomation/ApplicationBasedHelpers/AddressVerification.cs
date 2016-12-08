using System;
using System.Linq;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.ApplicationBasedHelpers
{
    public class AddressVerification
    {
       public TestObject apartmentNo;
        public TestObject manualAddress;
        public TestObject streetNo;
        public TestObject street;
        public TestObject suburb;
        public TestObject state;
        public TestObject postcode;
        public TestObject addressSearch;
        public TestObject eltMatchingAddListItem;

        public AddressVerification(Browser browser, TestObjectProperties lnkManualAddress, 
                                   TestObjectProperties txtApartmentNo, TestObjectProperties txtStreetNo,
                                   TestObjectProperties txtStreet, TestObjectProperties txtSuburb, 
                                   TestObjectProperties txtState, TestObjectProperties txtPostcode, 
                                   TestObjectProperties txtAddressSearch, TestObjectProperties matchingAddListItem)
        {
            manualAddress = new TestObject(browser, lnkManualAddress);
            apartmentNo = new TestObject(browser, txtApartmentNo);
            streetNo = new TestObject(browser, txtStreetNo);
            street = new TestObject(browser, txtStreet);
            suburb = new TestObject(browser, txtSuburb);
            state = new TestObject(browser, txtState);
            postcode = new TestObject(browser, txtPostcode);
            addressSearch = new TestObject(browser, txtAddressSearch);
            eltMatchingAddListItem = new TestObject(browser, matchingAddListItem);
        }

        public VerificationInfo ShouldVerifyThatAddressOptionsInListStartsWith(string schKeyword)
        {
            VerificationInfo info = new VerificationInfo();
            if (eltMatchingAddListItem.GetAListOfAllMatchingTestObjectsTitleValues().All(title => title.StartsWith(schKeyword)))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = string.Join(",", eltMatchingAddListItem.GetAListOfAllMatchingTestObjectsTitleValues().ToArray());
            return info;
        }

        public string ShouldGetTitleOfAddressListItem(int listItemNumber)
        {
            return eltMatchingAddListItem.GetAListOfAllMatchingTestObjectsTitleValues()[listItemNumber - 1];
        }

        public VerificationInfo ShouldVerifyThatStreetNoFieldValueIs(string streetNum)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = streetNum;
            info.Actual = streetNo.GetFieldValue();
            if (streetNo.GetFieldValue().Equals(streetNum, StringComparison.OrdinalIgnoreCase))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatStreetFieldValueIs(string st)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = st;
            info.Actual = street.GetFieldValue();
            if (street.GetFieldValue().Equals(st, StringComparison.OrdinalIgnoreCase))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatSuburbFieldValueIs(string sub)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sub;
            info.Actual = suburb.GetFieldValue();
            if (suburb.GetFieldValue().Equals(sub, StringComparison.OrdinalIgnoreCase))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatStateFieldValueIs(string st)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = st;
            info.Actual = state.GetFieldValue();
            if (state.GetFieldValue().Equals(st, StringComparison.OrdinalIgnoreCase))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatPostCodeFieldValueIs(string pc)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = pc;
            info.Actual = postcode.GetFieldValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public AddressFields ShouldSelectAddressInTheListFor(int listItemNumber)
        {
            AddressFields address = new AddressFields();
            var title = ShouldGetTitleOfAddressListItem(listItemNumber);
            var arr = title.Split(',');
            address.UnitAppNo = arr[0].Trim();
            var streetNo_streetName = arr[1].Trim();
            var suburb_state_postcode = arr[2].Trim();

            address.StreetNo = streetNo_streetName.Substring(0, streetNo_streetName.Length - streetNo_streetName.Substring(streetNo_streetName.IndexOf(" ", StringComparison.Ordinal)).Length);       
            address.Street = streetNo_streetName.Substring(streetNo_streetName.IndexOf(" ", StringComparison.Ordinal)+1);
            address.Suburb = suburb_state_postcode.Split()[0];
            address.State = suburb_state_postcode.Split()[1];
            address.PostCode = suburb_state_postcode.Split()[2];
            eltMatchingAddListItem.SelectMatchingItemNumber(listItemNumber);

            return address;

        }
         
        public VerificationInfo ShouldVerifyErrorForAddressSearchField()
        {
            return addressSearch.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForStreetNoField()
        {
            return streetNo.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForUnit_AppNoField()
        {
            return apartmentNo.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForStreetField()
        {
            return street.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForSuburbField()
        {
            return suburb.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForStateField()
        {
            return state.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForPostCodeField()
        {
            return postcode.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyThatAddressSearchfieldisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (addressSearch.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatApartmentNumberfieldisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (apartmentNo.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatStreetNumberfieldisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (streetNo.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatStreetfieldisAvailable()
        {

            VerificationInfo info = new VerificationInfo();
            if (street.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatSuburbfieldisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (suburb.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatStatefieldisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (state.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatPostcodefieldisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (postcode.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyManualAddressOptionTextWith(string sText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sText;
            info.Actual = manualAddress.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void SelectManualAddress()
        {
            manualAddress.Click();
        }

        public void SetValueInAddressSearchFieldAs(string schKeyword)
        {
            addressSearch.SendKeys(schKeyword);
        }

        public void SetValueInApartmentNoAs(string unitNo)
        {
            if (!string.IsNullOrEmpty(unitNo))
            {
                apartmentNo.SendKeys(unitNo);
            }
        }

        public void SetValueInStreetNoAs(string stNum)
        {
            if (!string.IsNullOrEmpty(stNum))
            {
                streetNo.SendKeys(stNum);
            }
        }

        public void SetValueInStreetAs(string strt)
        {
            if (!string.IsNullOrEmpty(strt))
            {
                street.SendKeys(strt);
            }
        }

        public void SetValueInSuburbAs(string sub)
        {
            if (!string.IsNullOrEmpty(sub))
            {
                suburb.SendKeys(sub);
            }
        }

        public void SetValueInStateAs(string st)
        {
            if (!string.IsNullOrEmpty(st))
            {
                state.SendKeys(st);
            }
        }

        public void SetValueInPostCodeAs(string pc)
        {
            if (!string.IsNullOrEmpty(pc))
            {
                postcode.SendKeys(pc);
            }
        }
    }
}
