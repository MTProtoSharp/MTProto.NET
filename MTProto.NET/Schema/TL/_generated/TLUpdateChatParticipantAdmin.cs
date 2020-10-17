using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xb6901959)]
    public class TLUpdateChatParticipantAdmin : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xb6901959;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }
        [MTParameter(Order = 1)]
        public int UserId { get; set; }
        [MTParameter(Order = 2)]
        public bool IsAdmin { get; set; }
        [MTParameter(Order = 3)]
        public int Version { get; set; }


    }
}
