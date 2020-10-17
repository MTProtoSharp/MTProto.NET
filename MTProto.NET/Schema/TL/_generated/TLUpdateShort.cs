using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x78d4dec1)]
    public class TLUpdateShort : TLAbsUpdates
    {
        public override uint Constructor
        {
            get
            {
                return 0x78d4dec1;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsUpdate Update { get; set; }
        [MTParameter(Order = 1)]
        public int Date { get; set; }


    }
}
