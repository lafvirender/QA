
namespace LAFTestAutomationFramework.ApplicationBasedHelpers
{
    public class AddressFields
    {
        public string UnitAppNo { get; set; }
        public string StreetNo { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }

        public AddressFields()
        {
        }

        public AddressFields(string addString)
        {
            var addArr = addString.Split(',');
            if (addArr[0] != null) UnitAppNo = addArr[0];
            if (addArr[1] != null) StreetNo = addArr[1];
            if (addArr[2] != null) Street = addArr[2];
            if (addArr[3] != null) Suburb = addArr[3];
            if (addArr[4] != null) State = addArr[4];
            if (addArr[5] != null) PostCode = addArr[5];
        }
    }
}
