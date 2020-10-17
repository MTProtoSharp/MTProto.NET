using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x6c50051c)]
    public class TLImportChatInvite : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6c50051c;
            }
        }

        [MTParameter(Order = 0)]
        public string Hash { get; set; }


    }
}
