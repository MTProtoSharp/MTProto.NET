using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Contacts
{
    [MTObject(0xa356056)]
    public class TLGetLocated : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa356056;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputGeoPoint GeoPoint { get; set; }


    }
}
