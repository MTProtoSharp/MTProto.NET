using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x3bf703dc)]
    public class TLEncryptedChatWaiting : TLAbsEncryptedChat
    {
        public override uint Constructor
        {
            get
            {
                return 0x3bf703dc;
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


    }
}
