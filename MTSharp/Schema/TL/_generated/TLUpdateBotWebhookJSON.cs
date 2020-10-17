using MTSharp.Attributes;

namespace MTSharp.Schema.TL
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
        public MTSharp.Schema.TL.TLDataJSON Data { get; set; }


    }
}
