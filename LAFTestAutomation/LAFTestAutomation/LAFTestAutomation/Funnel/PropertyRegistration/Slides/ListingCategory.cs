using System;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration.Slides
{
    public class ListingCategory
    {
        private readonly TestObject _sell;
        private readonly TestObject _rent;
        private readonly TestObject _eltListingCategorySlide;
        private readonly TestObject _lnkForward;



        public ListingCategory(Browser browser, TestObjectProperties eltListingCategorySlide, 
                                TestObjectProperties lnkSell, TestObjectProperties lnkRent, 
                                TestObjectProperties lnkForward)
        {
            _eltListingCategorySlide = new TestObject(browser,eltListingCategorySlide);
            _sell = new TestObject(browser, lnkSell);
            _rent = new TestObject(browser, lnkRent);
            _lnkForward = new TestObject(browser, lnkForward);
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltListingCategorySlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyListingCategorySellTextWith(string listingCategoryText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = listingCategoryText;
            info.Actual = _sell.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyListingCategoryRentTextWith(string listingCategoryText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = listingCategoryText;
            info.Actual = _rent.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void SelectSell()
        {
            _sell.WaitForSlideOptionToBecomeActive();
            _sell.Click();
        }

        public void SelectRent()
        {
            _rent.WaitForSlideOptionToBecomeActive();
            _rent.Click();
        }

        public void MoveForwardToPropertyType()
        {
            _lnkForward.Click();
        }

        public void SelectListingCategoryAs(string listingCategory)
        {
            var option = (ListingCategoryEnum) Enum.Parse(typeof(ListingCategoryEnum), listingCategory);

            switch (option)
            {
                case ListingCategoryEnum.Sell:
                    SelectSell();
                    break;

                case ListingCategoryEnum.Rent:
                    SelectRent();
                    break;

                default:
                    return;
            }
        }

        
        public VerificationInfo ShouldVerifyTheColorOfSellOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _sell.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfRentOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _rent.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
    }
}
