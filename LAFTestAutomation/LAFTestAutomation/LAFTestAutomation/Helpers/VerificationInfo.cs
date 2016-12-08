using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAFTestAutomationFramework.Helpers
{
    public class VerificationInfo
    {
        public bool Result;
        public string Actual;
        public string Expected;
        public string Message;

        public VerificationInfo()
        {
            Actual = "";
            Expected = "";
            Message = "";
        }
    }
}
