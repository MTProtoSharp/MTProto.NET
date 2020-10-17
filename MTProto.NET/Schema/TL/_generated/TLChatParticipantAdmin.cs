using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xe2d6e436)]
    public class TLChatParticipantAdmin : TLAbsChatParticipant
    {
        public override uint Constructor
        {
            get
            {
                return 0xe2d6e436;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public int InviterId { get; set; }
        [MTParameter(Order = 2)]
        public int Date { get; set; }


    }
}
