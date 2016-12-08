using LAFTestAutomationFramework.Helpers;
using LAFTestAutomationFramework.ApplicationBasedHelpers;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForSell.Slides
{
    public class SalesMethods
    {
        private readonly TestObject _privateSale;
        private readonly TestObject _auctions;
        private readonly TestObject _offMarket;
        private readonly TestObject _fixedDate;
        private readonly TestObject _next;
        private readonly TestObject _forward;
        private readonly TestObject _backward;
        private readonly TestObject _salesMethodsSlide;
        private readonly TestObject _eltSalesMethodQuestion;


        public SalesMethods(Browser browser, TestObjectProperties btnPrivateSale,
            TestObjectProperties btnAuctions, TestObjectProperties btnOffMarket,
            TestObjectProperties btnFixedDate, TestObjectProperties btnNext,
            TestObjectProperties lnkForward, TestObjectProperties lnkBackward,
            TestObjectProperties eltSalesMethodsSlide, TestObjectProperties eltSalesMethodQuestion)
        {
            _privateSale = new TestObject(browser, btnPrivateSale);
            _auctions = new TestObject(browser, btnAuctions);
            _offMarket = new TestObject(browser, btnOffMarket);
            _fixedDate = new TestObject(browser, btnFixedDate);
            _next = new TestObject(browser, btnNext);
            _forward = new TestObject(browser, lnkForward);
            _backward = new TestObject(browser, lnkBackward);
            _salesMethodsSlide = new TestObject(browser, eltSalesMethodsSlide);
            _eltSalesMethodQuestion = new TestObject(browser, eltSalesMethodQuestion);
        }

        public void ClickForwardLink()
        {
            _forward.Click();
        }
        public void GoBackToLanguageSelection()
        {
            _backward.Click();
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
            return _eltSalesMethodQuestion.GetText();
        }

        public VerificationInfo IsDisplayed()
        {

            return _salesMethodsSlide.VerifyDisplayStyleWith("block");
        }

        public VerificationInfo ShouldVerifyOptionPrivateSaleTextWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = _privateSale.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyOptionAuctionsTextWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = _auctions.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyOptionOffMarketTextWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = _offMarket.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyOptionFixedDateTextWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = _fixedDate.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void SelectPrivateSale()
        {
            _privateSale.Click();
        }

        public void SelectAuctions()
        {
            _auctions.Click();
        }

        public void SelectOffMarket()
        {
            _offMarket.Click();
        }

        public void SelectFixedDate()
        {
            _fixedDate.Click();
        }

        public void ClickNext()
        {
            _next.Click();
        }

    public void SelectSaleMethodsAs(string saleMethods)
        {
            var methods = saleMethods.Split(',');
            foreach (var method in methods)
            {
                var option = (SaleMethodsEnum) System.Enum.Parse(typeof(SaleMethodsEnum), method);

                switch (option)
                {
                    case SaleMethodsEnum.PrivateSale:
                        SelectPrivateSale();
                        break;

                    case SaleMethodsEnum.Auctions:
                        SelectAuctions();
                        break;

                    case SaleMethodsEnum.FixedDate:
                        SelectFixedDate();
                        break;

                    case SaleMethodsEnum.OffMarket:
                        SelectOffMarket();
                        break;

                    default:
                        return;
                }
            }

        }

        public VerificationInfo ShouldVerifyTheColorOfPrivateSaleOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _privateSale.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfAuctionsOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _auctions.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfOffMarketOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _offMarket.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfFixedOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _fixedDate.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
    }
}
