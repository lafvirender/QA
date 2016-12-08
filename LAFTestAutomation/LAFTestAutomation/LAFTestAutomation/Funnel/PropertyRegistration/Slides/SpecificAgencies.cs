using System;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration.Slides
{
    public class SpecificAgencies
    {
        private readonly TestObject _specificAgencyDetails;
        private readonly TestObject _yes;
        private readonly TestObject _no;
        private readonly TestObject _next;
        private readonly TestObject _eltSpecificAgenciesSlide;
        private readonly TestObject _back;

        public SpecificAgencies(Browser browser, TestObjectProperties eltSpecificAgenciesSlide,
                                TestObjectProperties lnkYes, TestObjectProperties lnkNo, 
                                TestObjectProperties txtSpecificAgencyDetails, TestObjectProperties lnkNext,
                                TestObjectProperties lnkBack)
        {
            _eltSpecificAgenciesSlide = new TestObject(browser, eltSpecificAgenciesSlide);
            _specificAgencyDetails = new TestObject(browser, txtSpecificAgencyDetails);
            _yes = new TestObject(browser, lnkYes);
            _no = new TestObject(browser, lnkNo);
            _next = new TestObject(browser, lnkNext);
            _back = new TestObject(browser, lnkBack);
        }


        public void MoveBackToAgentQualitySelection()
        {
            _yes.IsDisplayed();
            _back.Click();
        }


        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltSpecificAgenciesSlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyErrorForSpecificAgenciesDetailsField()
        {
            return _specificAgencyDetails.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyThatSpecificAgenciesDetailsfieldisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (_specificAgencyDetails.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyoptionYesTextWith(string sText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sText;
            info.Actual = _yes.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyoptionNoTextWith(string sText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sText;
            info.Actual = _no.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void EnterSpecificAgenciesInformation(string specificAgency, string specificAgenciesDetails)
        {
            SelectSpecificAgenciesAs(specificAgency);
            EnterSpecificAgencyDetailsAs(specificAgency, specificAgenciesDetails);
        }

        private void SelectSpecificAgenciesAs(string specificAgency)
        {
            var answerspecificAgency = (SpecificAgenciesEnum)Enum.Parse(typeof(SpecificAgenciesEnum), specificAgency);

            switch (answerspecificAgency)
            {
                case SpecificAgenciesEnum.Yes:
                    SelectYes();
                    break;

                case SpecificAgenciesEnum.No:
                    SelectNo();
                    break;

                default:
                    return;
            }
        }

        public void SelectYes()
        {
            _yes.WaitForSlideOptionToBecomeActive();
            _yes.Click();
        }

        public void SelectNo()
        {
            _no.WaitForSlideOptionToBecomeActive();
            _no.Click();
        }

        private void SetValueInSpecificAgencyDetailsAs(string specificAgencyDetails)
        {
            _specificAgencyDetails.SendKeys(specificAgencyDetails);
        }

        private void EnterSpecificAgencyDetailsAs(string specificAgencyOption, string specificAgencyDetails)
        {

            var answerSpecificAgencies =
                (SpecificAgenciesEnum) Enum.Parse(typeof(SpecificAgenciesEnum), specificAgencyOption);

            if (answerSpecificAgencies != SpecificAgenciesEnum.Yes) return;
            SetValueInSpecificAgencyDetailsAs(specificAgencyDetails);
            ClickNext();
        }


        public void ClickNext()
        {
            _next.Click();
        }
    }
}
