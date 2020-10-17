using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xf351d7ab)]
    public class TLSendMessageUploadAudioAction : TLAbsSendMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xf351d7ab;
            }
        }

        [MTParameter(Order = 0)]
        public int Progress { get; set; }


    }
}
