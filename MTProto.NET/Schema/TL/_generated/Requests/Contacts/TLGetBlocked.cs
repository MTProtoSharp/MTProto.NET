using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Contacts
{
    [MTObject(0xf57c350f)]
    public class TLGetBlocked : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf57c350f;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Limit { get; set; }


    }
}
