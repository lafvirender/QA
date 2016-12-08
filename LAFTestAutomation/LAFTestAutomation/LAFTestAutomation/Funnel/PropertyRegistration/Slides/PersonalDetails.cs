using System;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration.Slides
{
    public class PersonalDetails
    {
        private readonly TestObject _firstName;
        private readonly TestObject _lastName;
        private readonly TestObject _email;
        private readonly TestObject _mobileNumber;
        private readonly TestObject _submit;
        private readonly TestObject _eltSalutationCustomerDetails;
        private readonly TestObject _yes;
        private readonly TestObject _no;
        private readonly TestObject _finished;
        private readonly TestObject _directConnectDetails;
        private readonly TestObject _eltPersonalDetailsSlide;
        private readonly TestObject _back;

        public PersonalDetails(Browser browser,TestObjectProperties eltPersonalDetailsSlide,
                                TestObjectProperties txtFirstName, TestObjectProperties txtLastName, 
                                TestObjectProperties txtEmail, TestObjectProperties txtMobileNumber, 
                                TestObjectProperties lnkSubmit, TestObjectProperties eltSalutationCustomerDetails, 
                                TestObjectProperties lnkYes, TestObjectProperties lnkNo, 
                                TestObjectProperties btnFinished, TestObjectProperties txtDirectConnectDetails,
                                TestObjectProperties lnkBack)
        {
            _eltPersonalDetailsSlide = new TestObject(browser, eltPersonalDetailsSlide);
            _firstName = new TestObject(browser, txtFirstName);
            _lastName = new TestObject(browser, txtLastName);
            _email = new TestObject(browser, txtEmail);
            _mobileNumber = new TestObject(browser, txtMobileNumber);
            _submit = new TestObject(browser, lnkSubmit);
            _eltSalutationCustomerDetails = new TestObject(browser, eltSalutationCustomerDetails);
            _yes = new TestObject(browser, lnkYes);
            _no = new TestObject(browser, lnkNo);
            _finished = new TestObject(browser, btnFinished);
            _directConnectDetails = new TestObject(browser,txtDirectConnectDetails);
            _back = new TestObject(browser, lnkBack);
        }

        public void MoveBackToUrgencySelectionQuestion()
        {
            _submit.IsEnabled();
            _back.Click();
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltPersonalDetailsSlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatDirectConnectDetailsfieldisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (_directConnectDetails.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifySalutationForCustomerWhoIsSellingWith(string sText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sText;
            info.Actual = _eltSalutationCustomerDetails.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifySalutationForCustomerWhoIsRentingWith(string sText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sText;
            info.Actual = _eltSalutationCustomerDetails.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyErrorForFirstNameField()
        {
            return _firstName.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForLastNameField()
        {
            return _lastName.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForEmailField()
        {
            return _email.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForMobileField()
        {
            return _mobileNumber.VerifyFieldError();
        }

        public void SelectYes()
        {
            _yes.Click();
        }

        public void SelectNo()
        {
            _no.Click();
        }

        public void ClickFinished()
        {
            _finished.Click();
        }


        public void EnterCustomerDirectConnectInformation(string customerDirectConnectAnswer, string directConnectDetails )
        {
            SelectCustomerDirectConnectAnswerAs(customerDirectConnectAnswer);
            EnterDirectConnectDetailsAs(customerDirectConnectAnswer, directConnectDetails);
            ClickFinished();
        }


        private void SelectCustomerDirectConnectAnswerAs(string customerDirectConnectAnswer)
        {
            var answer = (CustomerDirectConnectEnum)Enum.Parse(typeof(CustomerDirectConnectEnum), customerDirectConnectAnswer);

            switch (answer)
            {
                case CustomerDirectConnectEnum.Yes:
                    SelectYes();
                    break;

                case CustomerDirectConnectEnum.No:
                    SelectNo();
                    break;

                default:
                    return;
            }
        }

        
        private void SetValueInDirectConnectDetailsAs(string directConnectDetails)
        {
            _directConnectDetails.SendKeys(directConnectDetails);
        }

        private void EnterDirectConnectDetailsAs(string customerDirectConnectAnswer, string directConnectDetails)
        {
            var answerDirectConnect =
                (CustomerDirectConnectEnum)Enum.Parse(typeof(CustomerDirectConnectEnum), customerDirectConnectAnswer);

            if (answerDirectConnect != CustomerDirectConnectEnum.Yes) return;
            SetValueInDirectConnectDetailsAs(directConnectDetails);
        }

        public void ClickSubmit()
        {
            _submit.Click();
        }

        private void SetValueInFirstNameAs(string firstName)
        {
            _firstName.SendKeys(firstName);
        }

        private void SetValueInLastNameAs(string lastName)
        {
            _lastName.SendKeys(lastName);
        }

        private void SetValueInEmailAs(string email)
        {
            _email.SendKeys(email);
        }

        private void SetValueInMobileNumberAs(string mobileNumber)
        {
            _mobileNumber.SendKeys(mobileNumber);
        }


        public void EnterPersonalDetailsAs(string firstName, string lastName, string email, string mobileNumber)
        {
            SetValueInFirstNameAs(firstName);
            SetValueInLastNameAs(lastName);
            SetValueInEmailAs(email);
            SetValueInMobileNumberAs(mobileNumber);
            ClickSubmit();
        }
    }
}
