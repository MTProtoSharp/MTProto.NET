using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x3bb3b94a)]
    public class TLInputPhoto : TLAbsInputPhoto
    {
        public override uint Constructor
        {
            get
            {
                return 0x3bb3b94a;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 2)]
        public byte[] FileReference { get; set; }


    }
}
