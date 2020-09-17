using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x1e8caaeb)]
    public class TLPostAddress : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1e8caaeb;
            }
        }

        [MTParameter(Order = 0)]
        public string StreetLine1 { get; set; }
        [MTParameter(Order = 1)]
        public string StreetLine2 { get; set; }
        [MTParameter(Order = 2)]
        public string City { get; set; }
        [MTParameter(Order = 3)]
        public string State { get; set; }
        [MTParameter(Order = 4)]
        public string CountryIso2 { get; set; }
        [MTParameter(Order = 5)]
        public string PostCode { get; set; }


    }
}
