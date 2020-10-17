using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xe10db349)]
    public class TLUpdateChatPinnedMessage : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xe10db349;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }
        [MTParameter(Order = 1)]
        public int Id { get; set; }
        [MTParameter(Order = 2)]
        public int Version { get; set; }


    }
}
