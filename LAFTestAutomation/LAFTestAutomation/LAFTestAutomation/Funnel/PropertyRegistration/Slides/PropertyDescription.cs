using System;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration.Slides
{
    public class PropertyDescription
    {
        private readonly TestObject _myHome;
        private readonly TestObject _vacantProperty;
        private readonly TestObject _tenantedProperty;
        private readonly TestObject _leasingDetails;
        private readonly TestObject _next;
        private readonly TestObject _eltPropertyDescriptionSlide;

        public PropertyDescription(Browser browser, TestObjectProperties eltPropertyDescriptionSlide,
                                    TestObjectProperties lnkMyHome, TestObjectProperties lnkVacantProperty, 
                                    TestObjectProperties lnkTenantedProperty, TestObjectProperties txtLeasingDetails,
                                    TestObjectProperties lnkNext)
        {
            _eltPropertyDescriptionSlide = new TestObject(browser, eltPropertyDescriptionSlide);
            _myHome = new TestObject(browser, lnkMyHome);
            _vacantProperty = new TestObject(browser, lnkVacantProperty);
            _tenantedProperty = new TestObject(browser, lnkTenantedProperty);
            _leasingDetails = new TestObject(browser, txtLeasingDetails);
            _next = new TestObject(browser, lnkNext);
        }


        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltPropertyDescriptionSlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatLeasingDetailsfieldisAvailable()
        {
            VerificationInfo info = new VerificationInfo();
            if (_leasingDetails.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyErrorForLeasingDetailsField()
        {
            return _leasingDetails.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyoptionMyHomeTextWith(string sText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sText;
            info.Actual = _myHome.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyoptionVacantPropertyTextWith(string sText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sText;
            info.Actual = _vacantProperty.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyoptionTenantedPropertyTextWith(string sText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sText;
            info.Actual = _tenantedProperty.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }


        public void EnterLeasedInformation(string leaseOption, string leasingDetails)
        {
            SelectLeasedOptionAs(leaseOption);
            EnterLeasingDetails(leaseOption, leasingDetails);
        }

        public void SelectLeasedOptionAs(string option)
        {
            var leasedOption = (LeasedEnum)Enum.Parse(typeof(LeasedEnum), option);
            switch (leasedOption)
            {
                case LeasedEnum.MyHome:
                    SelectMyHome();
                    break;

                case LeasedEnum.VacantProperty:
                    SelectVacantProperty();
                    break;

                case LeasedEnum.TenantedProperty:
                    SelectTanantedProperty();
                    break;

                default:
                    return;
            }
        }

        public void SelectMyHome()
        {
            _myHome.WaitForSlideOptionToBecomeActive();
            _myHome.Click();
        }

        public void SelectVacantProperty()
        {
            _vacantProperty.WaitForSlideOptionToBecomeActive();
            _vacantProperty.Click();
        }

        public void SelectTanantedProperty()
        {
            _tenantedProperty.WaitForSlideOptionToBecomeActive();
            _tenantedProperty.Click();
        }

        private void SetValueInLeasingDetailsAs(string leasingDetails)
        {
            _leasingDetails.SendKeys(leasingDetails);
        }

        public void ClickNext()
        {
            _next.Click();
        }

        private void EnterLeasingDetails(string leasingoption, string leasingDetails)
        {
            var leasedOption = (LeasedEnum) Enum.Parse(typeof(LeasedEnum), leasingoption);
            if (leasedOption != LeasedEnum.VacantProperty && leasedOption != LeasedEnum.TenantedProperty) return;
            SetValueInLeasingDetailsAs(leasingDetails);
            ClickNext();
        }

    }
}
