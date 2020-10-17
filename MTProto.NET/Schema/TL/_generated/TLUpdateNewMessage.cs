using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x1f2b0afd)]
    public class TLUpdateNewMessage : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x1f2b0afd;
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
