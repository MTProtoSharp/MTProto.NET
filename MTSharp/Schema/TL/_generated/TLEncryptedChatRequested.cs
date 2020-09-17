using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xc878527e)]
    public class TLEncryptedChatRequested : TLAbsEncryptedChat
    {
        public override uint Constructor
        {
            get
            {
                return 0xc878527e;
            }
        }

        [MTParameter(Order = 0)]
        public int Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 2)]
        public int Date { get; set; }
        [MTParameter(Order = 3)]
        public int AdminId { get; set; }
        [MTParameter(Order = 4)]
        public int ParticipantId { get; set; }
        [MTParameter(Order = 5)]
        public byte[] GA { get; set; }


    }
}
