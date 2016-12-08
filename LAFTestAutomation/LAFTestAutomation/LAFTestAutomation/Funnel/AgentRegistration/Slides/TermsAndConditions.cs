using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentRegistration.Slides
{
    public class TermsAndConditions
    {

        private readonly TestObject _accept;
        private readonly TestObject _termsAndCondSlide;
        private readonly TestObject _termsContainer;
        private readonly TestObject _chkAcceptTerms;
        private readonly TestObject _errors;
        private readonly TestObject _expandTermsAndCond;
        private readonly TestObject _termsHeading;
        private readonly TestObject _closeTermsPopup;

        public TermsAndConditions(Browser browser, TestObjectProperties eltTermsAndCondSlide, TestObjectProperties btnAccept,
                                   TestObjectProperties eltTermsContainer, TestObjectProperties ChkAcceptTermsandCond,
                                   TestObjectProperties eltErrors, TestObjectProperties LnkExpandTermsandCond, TestObjectProperties EltTermsHeading,
                                   TestObjectProperties BtnCloseTermsPopup)
        {
            _accept = new TestObject(browser, btnAccept);
            _termsAndCondSlide = new TestObject(browser, eltTermsAndCondSlide);
            _termsContainer = new TestObject(browser, eltTermsContainer);
            _chkAcceptTerms = new TestObject(browser, ChkAcceptTermsandCond);
            _errors = new TestObject(browser, eltErrors);
            _expandTermsAndCond = new TestObject(browser, LnkExpandTermsandCond);
            _termsHeading = new TestObject(browser, EltTermsHeading);
            _closeTermsPopup = new TestObject(browser, BtnCloseTermsPopup);
        }

        public VerificationInfo ShouldVerifyThatSubmitButtonIsDisabled()
        {
            VerificationInfo info = new VerificationInfo();
            if (_accept.GetClassAttributeValue().Contains("disabled"))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _accept.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyThatSubmitButtonIsEnabled()
        {
            VerificationInfo info = new VerificationInfo();
            if (_accept.GetClassAttributeValue().Contains("disabled"))
                info.Result = false;
            else
                info.Result = true;

            info.Actual = _accept.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_accept.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void ReadTermsTillEnd()
        {
            ClickAccept();
            _chkAcceptTerms.scrollToViewElement();
            // _termsContainer.scrollToViewElement();
        }

        public void ReadTermsAndSelectAcceptanceCheck()
        {
            OpenTermsPopup();
            _chkAcceptTerms.scrollToViewElement();
            SelectAcceptanceCheck();
            CloseTermsPopup();
            // _termsContainer.scrollToViewElement();
        }

        public VerificationInfo ShouldVerifyTheHeadingWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Actual = text;
            info.Expected = GetHeadingText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        private string GetHeadingText()
        {
            return _termsHeading.GetText();
        }

        public VerificationInfo ShouldVerifyThatErrorForSelectingAcceptanceCheck(string errText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Actual = errText;
            info.Expected = _errors.GetAListOfAllMatchingTestObjectsTextsValues().ToString();
            if (_errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errText))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public void AcceptTheTerms()
        {
            ReadTermsAndSelectAcceptanceCheck();
            ClickAccept();
        }

        public void ExpandTermsAndCondition()
        {
            _expandTermsAndCond.Click();
        }

        public void OpenTermsPopup()
        {
            _expandTermsAndCond.Click();
        }

        public void CloseTermsPopup()
        {
            if(_closeTermsPopup.IsDisplayed())
                _closeTermsPopup.Click();
        }

        public void ClickAccept()
        {
            _accept.Click();
        }

        public void SelectAcceptanceCheck()
        {
            _chkAcceptTerms.Click();
        }

        public void DeSelectAcceptanceCheck()
        {
            OpenTermsPopup();
            if (_chkAcceptTerms.IsSelected())
                _chkAcceptTerms.Click();
            CloseTermsPopup();
        }
    }
}
