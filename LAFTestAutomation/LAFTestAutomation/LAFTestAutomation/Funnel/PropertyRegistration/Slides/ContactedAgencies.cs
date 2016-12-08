using System;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration.Slides
{
    public class ContactedAgencies
    {
        private readonly TestObject _contactedAgencyDetails;
        private readonly TestObject _yes;
        private readonly TestObject _no;
        private readonly TestObject _next;
        private readonly TestObject _eltContactedAgenciesSlide;

        public ContactedAgencies(Browser browser, TestObjectProperties eltContactedAgenciesSlide,
                                TestObjectProperties lnkYes, TestObjectProperties lnkNo, 
                                TestObjectProperties txtContactedAgencyDetails, TestObjectProperties lnkNext)
        {
            _eltContactedAgenciesSlide = new TestObject(browser, eltContactedAgenciesSlide);
            _contactedAgencyDetails = new TestObject(browser, txtContactedAgencyDetails);
            _yes = new TestObject(browser, lnkYes);
            _no = new TestObject(browser, lnkNo);
            _next = new TestObject(browser, lnkNext);
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltContactedAgenciesSlide.WaitTillItsClassContainsActive())
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


        public VerificationInfo ShouldVerifyErrorForContactedAgenciesDetailsField()
        {
            return _contactedAgencyDetails.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyThatContactedAgenciesDetailsfieldisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (_contactedAgencyDetails.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void EnterContactedAgenciesInformation(string contactedAgencyOption , string contactedAgenciesDetails )
        {
            SelectContactedAgenciesAs(contactedAgencyOption);
            EnterContactedAgencyDetails(contactedAgencyOption, contactedAgenciesDetails);
        }

        private void SelectContactedAgenciesAs(string contactedAgency)
        {
            var answerContactedAgencies = (ContactedAgenciesEnum)Enum.Parse(typeof(ContactedAgenciesEnum), contactedAgency);

            switch (answerContactedAgencies)
            {
                case ContactedAgenciesEnum.Yes:
                    SelectYes();
                    break;

                case ContactedAgenciesEnum.No:
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

        private void SetValueInSpecificAgencyDetailsAs(string contactedAgencyDetails )
        {
            _contactedAgencyDetails.SendKeys(contactedAgencyDetails);
        }

        private void EnterContactedAgencyDetails(string contactedAgencyOption, string contactedAgencyDetails)
        {
            var answerContactedAgencies =
                (ContactedAgenciesEnum) Enum.Parse(typeof(ContactedAgenciesEnum), contactedAgencyOption);

            if (answerContactedAgencies != ContactedAgenciesEnum.Yes) return;
            SetValueInSpecificAgencyDetailsAs(contactedAgencyDetails);
            ClickNext();
        }

        public void ClickNext()
        {
            _next.Click();
        }

    }
}
