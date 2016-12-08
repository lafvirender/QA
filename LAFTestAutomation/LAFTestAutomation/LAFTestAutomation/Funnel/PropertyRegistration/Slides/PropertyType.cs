using System;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration.Slides
{
    public class PropertyType
    {
        private readonly TestObject _house;
        private readonly TestObject _unit;
        private readonly TestObject _land;
        private readonly TestObject _apartment;
        private readonly TestObject _townHouse;
        private readonly TestObject _villa;
        private readonly TestObject _lnkBack;
        private readonly TestObject _eltPropertyTypeSlide;

        public PropertyType(Browser browser, TestObjectProperties eltPropertyTypeSlide, 
                            TestObjectProperties lnkHouse, TestObjectProperties lnkUnit, 
                            TestObjectProperties lnkLand, TestObjectProperties lnkApartment,
                            TestObjectProperties lnkTownHouse, TestObjectProperties lnkVilla, 
                            TestObjectProperties lnkBack)
        {
            _eltPropertyTypeSlide = new TestObject(browser, eltPropertyTypeSlide);
            _house = new TestObject(browser, lnkHouse);
            _unit = new TestObject(browser, lnkUnit);
            _land = new TestObject(browser, lnkLand);
            _apartment = new TestObject(browser, lnkApartment);
            _townHouse = new TestObject(browser, lnkTownHouse);
            _villa = new TestObject(browser, lnkVilla);
            _lnkBack = new TestObject(browser, lnkBack);
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltPropertyTypeSlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltPropertyTypeSlide.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfHouseOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _house.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfUnitOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _unit.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLandOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _land.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfApartmentOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _apartment.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfTownhouseOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _townHouse.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfVillaOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _villa.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyPropertyTypeHouseTextWith(string propTypeText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = propTypeText;
            info.Actual = _house.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyPropertyTypeUnitTextWith(string propTypeText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = propTypeText;
            info.Actual = _unit.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyPropertyTypeLandTextWith(string propTypeText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = propTypeText;
            info.Actual = _land.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyPropertyTypeApartmentTextWith(string propTypeText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = propTypeText;
            info.Actual = _apartment.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyPropertyTypeTownhouseTextWith(string propTypeText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = propTypeText;
            info.Actual = _townHouse.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyPropertyTypeVillaTextWith(string propTypeText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = propTypeText;
            info.Actual = _villa.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void MoveBackToPropertyListing()
        {
            _lnkBack.IsEnabled();
            _lnkBack.Click();
        }

        private void SelectHouse()
        {
            _house.WaitForSlideOptionToBecomeActive();
            _house.Click();
        }

        private void SelectUnit()
        {
            _unit.WaitForSlideOptionToBecomeActive();
            _unit.Click();
        }

        private void SelectLand()
        {
            _land.WaitForSlideOptionToBecomeActive();
            _land.Click();
        }

        private void SelectApartment()
        {
            _apartment.WaitForSlideOptionToBecomeActive();
            _apartment.Click();
        }

        private void SelectTownhouse()
        {
            _townHouse.WaitForSlideOptionToBecomeActive();
            _townHouse.Click();
        }

        private void SelectVilla()
        {
            _villa.WaitForSlideOptionToBecomeActive();
            _villa.Click();
        }

        public void SelectPropertyTypeAs(string propertyType)
        {
            var option = (PropertyTypeEnum) Enum.Parse(typeof(PropertyTypeEnum), propertyType);

            switch (option)
            {
                case PropertyTypeEnum.House:
                    SelectHouse();
                    break;

                case PropertyTypeEnum.Unit:
                    SelectUnit();
                    break;

                case PropertyTypeEnum.Land:
                    SelectLand();
                    break;

                case PropertyTypeEnum.Apartment:
                    SelectApartment();
                    break;

                case PropertyTypeEnum.Townhouse:
                    SelectTownhouse();
                    break;

                case PropertyTypeEnum.Villa:
                    SelectVilla();
                    break;

                default:
                    return;
            }
        }
    }
}
