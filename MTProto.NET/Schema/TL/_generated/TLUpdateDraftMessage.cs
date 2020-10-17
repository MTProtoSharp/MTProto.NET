using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xee2bb969)]
    public class TLUpdateDraftMessage : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xee2bb969;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsDraftMessage Draft { get; set; }


    }
}
