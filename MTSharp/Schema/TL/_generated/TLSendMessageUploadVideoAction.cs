using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe9763aec)]
    public class TLSendMessageUploadVideoAction : TLAbsSendMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xe9763aec;
            }
        }

        [MTParameter(Order = 0)]
        public int Progress { get; set; }


    }
}
