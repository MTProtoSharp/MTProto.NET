using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xd1d34a26)]
    public class TLSendMessageUploadPhotoAction : TLAbsSendMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xd1d34a26;
            }
        }

        [MTParameter(Order = 0)]
        public int Progress { get; set; }


    }
}
