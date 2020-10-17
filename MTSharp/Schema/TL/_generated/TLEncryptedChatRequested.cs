using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x62718a82)]
    public class TLEncryptedChatRequested : TLAbsEncryptedChat
    {
        public override uint Constructor
        {
            get
            {
                return 0x62718a82;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? FolderId { get; set; }
        [MTParameter(Order = 2)]
        public int Id { get; set; }
        [MTParameter(Order = 3)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 4)]
        public int Date { get; set; }
        [MTParameter(Order = 5)]
        public int AdminId { get; set; }
        [MTParameter(Order = 6)]
        public int ParticipantId { get; set; }
        [MTParameter(Order = 7)]
        public byte[] GA { get; set; }


    }
}
