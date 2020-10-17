using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Channels
{
    [MTObject(0x3514b3de)]
    public class TLUpdateUsername : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3514b3de;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public string Username { get; set; }


    }
}
