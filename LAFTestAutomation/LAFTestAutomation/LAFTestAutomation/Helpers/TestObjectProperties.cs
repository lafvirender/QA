
using LAFTestAutomationFramework.ApplicationBasedHelpers;

namespace LAFTestAutomationFramework.Helpers
{
    public class TestObjectProperties
    {
       public Locator LocateBy { get; set; }
       public string Value { get; set; }

        public TestObjectProperties(Locator locateBy, string value)
        {
            this.LocateBy = locateBy;
            this.Value = value;
        }
    }
} 
