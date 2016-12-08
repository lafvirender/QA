
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentRegistration.Slides
{
    public class PrincipalDetails
    {
        private readonly TestObject _principalDetailsSlide;
        private readonly TestObject _principalFirstName;
        private readonly TestObject _principalLastName;
        private readonly TestObject _principalEmail;
        private readonly TestObject _next;
        private readonly TestObject _yes;
        private readonly TestObject _no;
        private readonly TestObject _principalDetailsQuestion;
        private readonly TestObject _errors;

        public PrincipalDetails(Browser browser, TestObjectProperties eltPrincipalDetailsSlide,
                                TestObjectProperties txtPrincipalFirstName,
                                TestObjectProperties txtPrincipalLastName, TestObjectProperties txtPrincipalEmail,
                                TestObjectProperties lnkNext, TestObjectProperties btnYes, TestObjectProperties btnNo,
                                TestObjectProperties eltPrincipalDetailsQuestion, TestObjectProperties eltErrors)
        {
            _principalDetailsSlide = new TestObject(browser, eltPrincipalDetailsSlide);
            _principalFirstName = new TestObject(browser, txtPrincipalFirstName);
            _principalLastName = new TestObject(browser, txtPrincipalLastName);
            _principalEmail = new TestObject(browser, txtPrincipalEmail);
            _next = new TestObject(browser, lnkNext);
            _yes = new TestObject(browser, btnYes);
            _no = new TestObject(browser, btnNo);
            _principalDetailsQuestion = new TestObject(browser, eltPrincipalDetailsQuestion);
            _errors = new TestObject(browser, eltErrors);
        }


        public VerificationInfo ShouldVerifyThatFieldsForPrincipalDetailsAreDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (ShouldVerifyThatPricipalFirstNameFieldisAvailable().Result &&
                   ShouldVerifyThatPricipalLastNameFieldisAvailable().Result &&
                   ShouldVerifyThatPricipalEMailFieldisAvailable().Result)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatPricipalFirstNameFieldisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (_principalFirstName.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatPricipalLastNameFieldisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (_principalLastName.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;

        }

        public VerificationInfo ShouldVerifyThatPricipalEMailFieldisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (_principalEmail.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheQuestionWith(string questionString)
        {
            VerificationInfo info = new VerificationInfo();
            info.Actual = questionString;
            info.Expected = GetQuestionText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        private string GetQuestionText()
        {
            return _principalDetailsQuestion.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_principalDetailsSlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _principalDetailsSlide.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyErrorForPrincipalFirstNameField(string errString)
        {
            VerificationInfo info = new VerificationInfo();
            if (_principalFirstName.VerifyFieldError().Result
                 && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errString))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _principalFirstName.VerifyFieldError().Actual + "-" + _errors.GetAListOfAllMatchingTestObjectsTextsValues().ToString();
            return info;
        }

        public VerificationInfo ShouldVerifyErrorForPrincipalLastNameField(string errString)
        {
            VerificationInfo info = new VerificationInfo();
            if (_principalLastName.VerifyFieldError().Result
                && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errString))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _principalLastName.VerifyFieldError().Actual + "-" + _errors.GetAListOfAllMatchingTestObjectsTextsValues().ToString();

            return info;
        }

        public VerificationInfo ShouldVerifyErrorForPrincipalEmailField(string errString)
        {
            VerificationInfo info = new VerificationInfo();
            if (_principalEmail.VerifyFieldError().Result
                && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errString))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _principalEmail.VerifyFieldError().Actual + "-" + _errors.GetAListOfAllMatchingTestObjectsTextsValues().ToString();

            return info;
        }

        private void SetValueInPrincipalFirstNameAs(string fName)
        {
            if (!string.IsNullOrEmpty(fName))
                _principalFirstName.SendKeys(fName);
        }

        private void SetValueInPrincipalLastNameAs(string lName)
        {
            if (!string.IsNullOrEmpty(lName))
                _principalLastName.SendKeys(lName);
        }

        private void SetValueInPrincipalEmailAs(string email)
        {
            if (!string.IsNullOrEmpty(email))
                _principalEmail.SendKeys(email);
        }

        private void ClickNext()
        {
            _next.Click();
        }

        public void EnterPrincipalDetailsAs(string firstName, string lastName, string email)
        {
            SelectNo();
            SetValueInPrincipalFirstNameAs(firstName);
            SetValueInPrincipalLastNameAs(lastName);
            SetValueInPrincipalEmailAs(email);
            ClickNext();
        }

        public VerificationInfo ShouldVerifyThatYesButtonIsAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (_yes.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatNoButtonIsAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (_no.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void SelectYes()
        {
            _yes.Click();
        }

        public void SelectNo()
        {
            _no.Click();
        }
    }
}
