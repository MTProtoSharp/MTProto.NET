using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Channels
{
    [MTObject(0xd10dd71b)]
    public class TLDeleteUserHistory : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd10dd71b;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputUser UserId { get; set; }


    }
}
