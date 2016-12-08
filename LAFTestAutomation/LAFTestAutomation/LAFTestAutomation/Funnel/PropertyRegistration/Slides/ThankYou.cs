using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration.Slides
{
    public class ThankYou
    {
        private readonly TestObject _thanksSection;
        private readonly TestObject _confirmMsgOneToUser;
        private readonly TestObject _confirmMsgTwoToUser;
        private readonly TestObject _infoMsgToUser;
        private readonly TestObject _agentCount;
        private readonly TestObject _agentIndicatorText;
        private readonly TestObject _customerEmailText;
        private readonly TestObject _emailMessage;
        private readonly TestObject _eltEstimateTimeMsg;


        public ThankYou(Browser browser, TestObjectProperties eltThanksSection, 
                        TestObjectProperties eltconfirmMsgOneToUser, TestObjectProperties eltconfirmMsgTwoToUser,
                        TestObjectProperties eltinfMsgToUser, TestObjectProperties eltagentCount,
                        TestObjectProperties eltagentIndicatorText, TestObjectProperties eltcustomerEmailText,
                        TestObjectProperties eltEMailMsg, TestObjectProperties eltEstimateTimeMsg)
        {
            _thanksSection = new TestObject(browser, eltThanksSection);
            _confirmMsgOneToUser = new TestObject(browser, eltconfirmMsgOneToUser);
            _confirmMsgTwoToUser = new TestObject(browser, eltconfirmMsgTwoToUser);
            _infoMsgToUser = new TestObject(browser, eltinfMsgToUser);
            _agentCount = new TestObject(browser, eltagentCount);
            _agentIndicatorText = new TestObject(browser, eltagentIndicatorText);
            _customerEmailText = new TestObject(browser, eltcustomerEmailText);
            _emailMessage = new TestObject(browser, eltEMailMsg);
            _eltEstimateTimeMsg = new TestObject(browser, eltEstimateTimeMsg);
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_thanksSection.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThankYouMessageOneWith(string sMsg)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sMsg;
            info.Actual = _confirmMsgOneToUser.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThankYouMessageTwoWith(string sMsg)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sMsg;
            info.Actual = _confirmMsgTwoToUser.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThankYouInfoMessageWith(string sMsg)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sMsg;
            info.Actual = _infoMsgToUser.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyEmailAddressWith(string sEmail)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sEmail;
            info.Actual = _customerEmailText.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyEmailAddressMsgWith(string sEmailMsg)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sEmailMsg;
            info.Actual = _emailMessage.GetText();
            if (_emailMessage.GetText().Replace("\r\n", "")== info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyEstimateTimeMsgWith(string sEstimateTimeMsg)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = sEstimateTimeMsg;
            info.Actual = _eltEstimateTimeMsg.GetText();
            if (_eltEstimateTimeMsg.GetText().Replace("\r\n", "") == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
    }
}
