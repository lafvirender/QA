using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentRegistration.Slides
{
    public class BeginAgentRegistration
    {
        private readonly TestObject _beforeYouStartSlide;
        private readonly TestObject _heading;
        private readonly TestObject _next;

        public BeginAgentRegistration(Browser browser, TestObjectProperties eltbeforeYouStartSlide, TestObjectProperties eltHeading,
                               TestObjectProperties btnNext)
        {
            _beforeYouStartSlide = new TestObject(browser, eltbeforeYouStartSlide);
            _heading = new TestObject(browser, eltHeading);
            _next = new TestObject(browser, btnNext);
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_beforeYouStartSlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;
            info.Actual = _beforeYouStartSlide.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyHeadingTextWith(string headingText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = headingText;
            info.Actual = _heading.GetText();
            if (info.Expected==info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void ShouldTakeMeToInterestSelection()
        {
            _next.Click();
        }

    }
}
