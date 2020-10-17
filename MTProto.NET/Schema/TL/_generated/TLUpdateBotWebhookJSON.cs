using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x8317c0c3)]
    public class TLUpdateBotWebhookJSON : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x8317c0c3;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.TLDataJSON Data { get; set; }


    }
}
