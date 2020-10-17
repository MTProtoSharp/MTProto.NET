using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xda13538a)]
    public class TLChatParticipantCreator : TLAbsChatParticipant
    {
        public override uint Constructor
        {
            get
            {
                return 0xda13538a;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }


    }
}
