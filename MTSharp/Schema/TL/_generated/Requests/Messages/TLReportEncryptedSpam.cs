using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x4b0c8c0f)]
    public class TLReportEncryptedSpam : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x4b0c8c0f;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLInputEncryptedChat Peer { get; set; }


    }
}
