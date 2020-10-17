using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfa56ce36)]
    public class TLEncryptedChat : TLAbsEncryptedChat
    {
        public override uint Constructor
        {
            get
            {
                return 0xfa56ce36;
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
        public byte[] GAOrB { get; set; }
        [MTParameter(Order = 6)]
        public long KeyFingerprint { get; set; }


    }
}
