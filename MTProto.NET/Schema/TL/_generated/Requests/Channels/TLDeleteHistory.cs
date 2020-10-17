using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Channels
{
    [MTObject(0xaf369d42)]
    public class TLDeleteHistory : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xaf369d42;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public int MaxId { get; set; }


    }
}
