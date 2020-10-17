using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Channels
{
    [MTObject(0xcc104937)]
    public class TLReadHistory : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcc104937;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public int MaxId { get; set; }


    }
}
