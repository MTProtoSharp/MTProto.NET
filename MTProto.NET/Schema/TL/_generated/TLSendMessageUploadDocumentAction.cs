using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xaa0cd9e4)]
    public class TLSendMessageUploadDocumentAction : TLAbsSendMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xaa0cd9e4;
            }
        }

        [MTParameter(Order = 0)]
        public int Progress { get; set; }


    }
}
