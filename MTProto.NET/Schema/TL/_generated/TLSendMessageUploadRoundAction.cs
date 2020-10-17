using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x243e1c66)]
    public class TLSendMessageUploadRoundAction : TLAbsSendMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x243e1c66;
            }
        }

        [MTParameter(Order = 0)]
        public int Progress { get; set; }


    }
}
