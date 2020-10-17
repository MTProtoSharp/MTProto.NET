using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x208e68c9)]
    public class TLInputMessageEntityMentionName : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x208e68c9;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputUser UserId { get; set; }


    }
}
