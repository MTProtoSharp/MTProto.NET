using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x1b3f4df7)]
    public class TLUpdateEditChannelMessage : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x1b3f4df7;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsMessage Message { get; set; }
        [MTParameter(Order = 1)]
        public int Pts { get; set; }
        [MTParameter(Order = 2)]
        public int PtsCount { get; set; }


    }
}
