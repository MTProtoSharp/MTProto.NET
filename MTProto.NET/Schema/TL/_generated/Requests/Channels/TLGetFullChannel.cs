using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Channels
{
    [MTObject(0x8736a09)]
    public class TLGetFullChannel : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8736a09;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }


    }
}
