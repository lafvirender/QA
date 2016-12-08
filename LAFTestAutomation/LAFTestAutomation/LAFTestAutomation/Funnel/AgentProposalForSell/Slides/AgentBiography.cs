using LAFTestAutomationFramework.Helpers;
namespace LAFTestAutomationFramework.Funnel.AgentProposalForSell.Slides
{
    public class AgentBiography
    {

        private readonly TestObject _next;
        private readonly TestObject _forward;
        private readonly TestObject _back;
        private readonly TestObject _agentBiographySlide;
        private readonly TestObject _aboutYou;
        private readonly TestObject _aboutYouDetails;
        private readonly TestObject _aboutYourAgency;
        private readonly TestObject _aboutYourAgencyDetails;
        private readonly TestObject _marketingSellingApproach;
        private readonly TestObject _marketingSellingApproachDetails;
        private readonly TestObject _agentBiographyQ;

        public AgentBiography(Browser browser, TestObjectProperties eltAgentBiographySlide,
            TestObjectProperties lnkForward, TestObjectProperties lnkBack,
            TestObjectProperties btnNext, TestObjectProperties lnkAboutYou,
            TestObjectProperties txtAboutYouDetails, TestObjectProperties lnkAboutYourAgency,
            TestObjectProperties txtAboutYourAgencyDetails, TestObjectProperties lnkMarketingSellingApproach,
            TestObjectProperties txtMarketingSellingApproachDetails, TestObjectProperties EltAgentBiographyQuestion)
        {
            _agentBiographySlide = new TestObject(browser, eltAgentBiographySlide);
            _next = new TestObject(browser, btnNext);
            _forward = new TestObject(browser, lnkForward);
            _back = new TestObject(browser, lnkBack);
            _aboutYou = new TestObject(browser, lnkAboutYou);
            _aboutYouDetails = new TestObject(browser, txtAboutYouDetails);
            _aboutYourAgency = new TestObject(browser, lnkAboutYourAgency);
            _aboutYourAgencyDetails = new TestObject(browser, txtAboutYourAgencyDetails);
            _marketingSellingApproach = new TestObject(browser, lnkMarketingSellingApproach);
            _marketingSellingApproachDetails = new TestObject(browser, txtMarketingSellingApproachDetails);
            _agentBiographyQ = new TestObject(browser, EltAgentBiographyQuestion);
        }

        public VerificationInfo ShouldVerifyTheQuestionWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = GetQuestionText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        private string GetQuestionText()
        {
            return _agentBiographyQ.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            return _agentBiographySlide.VerifyDisplayStyleWith("block");
        }

        public void ClickNext()
        {
            _next.Click();
        }

        public void SelectAboutYou()
        {
            _aboutYou.Click();
        }

        public void EnterAboutYouDetails(string text)
        {
            _aboutYouDetails.SendKeys(text);
        }

        public void SetAboutYouDetailsAs(string details)
        {
            SelectAboutYou();
            EnterAboutYouDetails(details);
        }

        public void SelectAboutYourAgency()
        {
            _aboutYourAgency.Click();
        }

        public void EnterAboutYourAgencyDetails(string text)
        {
            _aboutYourAgencyDetails.SendKeys(text);
        }

        public void SetAboutYourAgencyDetailsAs(string details)
        {
            SelectAboutYourAgency();
            EnterAboutYourAgencyDetails(details);
        }

        public void SelectMarketingAndSellingApproach()
        {
            _marketingSellingApproach.Click();
        }

        public void EnterMarketingAndSellingApproachDetails(string text)
        {
            _marketingSellingApproachDetails.SendKeys(text);
        }

        public void SetMarketingAndSellingApproachDetailsAs(string details)
        {
            SelectMarketingAndSellingApproach();
            EnterMarketingAndSellingApproachDetails(details);
        }

        public void SetAgentBiographyDetailsAs(string abtYouDetails, string abtAgencyDetails, string marSellAppDetails)
        {
            SetAboutYouDetailsAs(abtYouDetails);
            SetAboutYourAgencyDetailsAs(abtAgencyDetails);
            SetMarketingAndSellingApproachDetailsAs(marSellAppDetails);
            ClickNext();
        }

        public VerificationInfo ShouldVerifyThatTabsForEnteringBiographyShouldBeDisplayed()
        {
            VerificationInfo info = new VerificationInfo();

            if (_aboutYou.IsDisplayed() && _aboutYourAgency.IsDisplayed() && _marketingSellingApproach.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
    }
}
